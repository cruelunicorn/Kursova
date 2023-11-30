using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace Interface_Proj.Classes
{
    /// <summary>
    /// Allows you to work with remote storage, download and upload files
    /// </summary>
    internal class MicrosoftStorageHandler
    {
        private readonly string accountName = "kursovaoop";
        private readonly string accessKey = "iTyPAiN1hZeTu1jHgs7ebHPN4n0/OB+rKMsHposb0rKcHfEqyeIbQWix3PWeLefAbQzDgCA/Z6/D+AStrdbjmg==";
        private readonly string documentFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private readonly string debugFolderPath = Directory.GetCurrentDirectory();
        private readonly BlobServiceClient client;
        private readonly BlobContainerClient container;

        public MicrosoftStorageHandler()
        {
            var credentials = new StorageSharedKeyCredential(accountName, accessKey);
            var blobUri = $"https://{accountName}.blob.core.windows.net";
            client = new BlobServiceClient(new Uri(blobUri), credentials);
            container = client.GetBlobContainerClient("files");
            if (!Directory.Exists(Path.Combine(documentFolderPath, "StorageFiles")))
                Directory.CreateDirectory(Path.Combine(documentFolderPath, "StorageFiles"));
            documentFolderPath = Path.Combine(documentFolderPath, "StorageFiles");

        }

        /// <summary>Downloads file to debug folder</summary>
        /// <returns>Returns status string</returns>
        public async Task<string> DownloadFile(string downloadFileName, string folderName = "students", string fileName = "")
        {
            if (!IsInternetAvailable()) throw new InternetConectionException();
            BlobClient blob = container.GetBlobClient($"{folderName}/{downloadFileName}");
            if (!await blob.ExistsAsync()) { return "File or folder doesn't exist"; }
            await blob.DownloadToAsync(Path.Combine(debugFolderPath, downloadFileName));
            return "Success";
        }

        /// <summary>Uploads file to remoted storage</summary>
        /// <returns>Returns status string</returns>
        public async Task<string> UploadFile(string uploadFileName, string folderName, string fileText = "", params string[] metadata)
        {
            if (!IsInternetAvailable()) throw new InternetConectionException();
            //if (!uploadFileName.Contains('.')) uploadFileName += ".txt";
            bool exists = File.Exists(uploadFileName);
            File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), uploadFileName), fileText);
            BlobClient blob = container.GetBlobClient($"{folderName}/{uploadFileName}");
            await blob.UploadAsync(uploadFileName, true);
            Dictionary<string, string> metadataDictionary = new();
            foreach (var item in metadata)
            {
                if (Regex.IsMatch(item.Split(":")[1], @"\p{IsCyrillic}"))
                {
                    metadataDictionary.Add(item.Split(":")[0],
                        Convert.ToBase64String(Encoding.UTF8.GetBytes(item.Split(":")[1])));
                }
                else
                    metadataDictionary.Add(item.Split(":")[0], item.Split(":")[1]);
            }
            await blob.SetMetadataAsync(metadataDictionary);
            if (!exists) File.Delete(Path.Combine(Directory.GetCurrentDirectory(), uploadFileName));
            return "Success";
        }

        public async Task<string> CheckAuthorization(string login, string password)
        {
            if (!IsInternetAvailable()) return "No internet access";
            BlobClient personBlob = container.GetBlobClient($"students/{login}");
            if (personBlob.Exists() && personBlob.GetProperties() != null)
            {
                BlobProperties bp = await personBlob.GetPropertiesAsync();
                if (bp.Metadata["password"] == password) return "student authorized";
                else return "wrong password";
            }
            personBlob = container.GetBlobClient($"professors/{login}");
            if (personBlob.Exists() && personBlob.GetProperties() != null)
            {
                BlobProperties bp = await personBlob.GetPropertiesAsync();
                if (bp.Metadata["password"] == password) return "professor authorized";
                else return "wrong password";
            }
            return "wrong login";
        }

        public async Task<string> GetNameAndLastName(string login)
        {
            if (!IsInternetAvailable()) throw new InternetConectionException();
            BlobClient personBlob = container.GetBlobClient($"students/{login}");
            if (personBlob.Exists() && personBlob.GetProperties() != null)
            {
                BlobProperties bp = await personBlob.GetPropertiesAsync();
                string name = Encoding.UTF8.GetString(Convert.FromBase64String(bp.Metadata["name"]));
                string lastname = Encoding.UTF8.GetString(Convert.FromBase64String(bp.Metadata["lastname"]));
                return $"{name} {lastname}";
            }
            else
                return "not found";
        }

        public async Task<string> DeleteFile(string fileName, string folderName)
        {
            if (!IsInternetAvailable()) return "No internet access";
            BlobClient fileForDeleting = container.GetBlobClient($"{folderName}/{fileName}");
            await fileForDeleting.DeleteIfExistsAsync();
            return "Success";
        }

        public void DeleteStudent(string name, string lastname)
        {
            if (!IsInternetAvailable()) throw new InternetConectionException();
            var blobs = container.GetBlobs(prefix: "students/", traits: BlobTraits.Metadata).ToList();
            string encodedName = Convert.ToBase64String(Encoding.UTF8.GetBytes(name));
            string encodedLastName = Convert.ToBase64String(Encoding.UTF8.GetBytes(lastname));

            Parallel.For(0, blobs.Count, new ParallelOptions { MaxDegreeOfParallelism = 2} , (i, loopstate) =>
            {
                if (blobs[i].Metadata.ContainsKey("name") && blobs[i].Metadata["name"] == encodedName && blobs[i].Metadata["lastname"] == encodedLastName)
                {
                    _ = container.GetBlobClient(blobs[i].Name).DeleteAsync();
                    loopstate.Break();
                }
            });

            blobs = container.GetBlobs(prefix: "AttendanceFolder/").ToList();

            Parallel.ForEach(blobs, new ParallelOptions { MaxDegreeOfParallelism = 2 }, async (blob, loopstate) =>
            {
                string fileName = blob.Name.Split('/')[1];
                await DownloadFile(fileName, "AttendanceFolder");
                JObject jsonObj = JObject.Parse(File.ReadAllText(fileName));
                if (jsonObj[$"{name} {lastname}"] != null)
                {
                    jsonObj.Remove($"{name} {lastname}");
                    File.WriteAllText(fileName, jsonObj.ToString());
                    await UploadFile(fileName, "AttendanceFolder");
                    File.Delete(fileName);
                    loopstate.Break();
                }
                File.Delete(fileName);
            });
        }

        public async Task<string> GetLoginAndPasswordByName(string name, string lastname)
        {
            string result = "";
            if (!IsInternetAvailable()) throw new InternetConectionException();
            var blobs = container.GetBlobs(prefix: "students/");
            string encodedName = Convert.ToBase64String(Encoding.UTF8.GetBytes(name));
            string encodedLastName = Convert.ToBase64String(Encoding.UTF8.GetBytes(lastname));

            var tasks = blobs.Select(async blob =>
            {
                BlobClient blobToDelete = container.GetBlobClient(blob.Name);
                BlobProperties bp = await blobToDelete.GetPropertiesAsync();
                if (bp.Metadata.ContainsKey("name") && bp.Metadata["name"] == encodedName && bp.Metadata["lastname"] == encodedLastName)
                    result = $"{blobToDelete.Name.Split('/')[1]} {bp.Metadata["password"]}";
            });
            await Task.WhenAll(tasks);
            return result;
        }

        private static bool IsInternetAvailable()
        {
            using Ping ping = new();
            try
            {
                PingReply reply = ping.Send("www.google.com");
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}