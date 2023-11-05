using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Proj
{
    /// <summary>
    /// Allows you to work with remote storage, download and upload files
    /// </summary>
    internal class MicrosoftStorageHandler
    {
        private readonly string accountName = "kursovaoop";
        private readonly string accessKey = "iTyPAiN1hZeTu1jHgs7ebHPN4n0/OB+rKMsHposb0rKcHfEqyeIbQWix3PWeLefAbQzDgCA/Z6/D+AStrdbjmg==";
        private readonly string documentFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private readonly BlobServiceClient client;
        private readonly BlobContainerClient container;

        public MicrosoftStorageHandler()
        {
            var credentials = new StorageSharedKeyCredential(accountName, accessKey);
            var blobUri = $"https://{accountName}.blob.core.windows.net";
            client = new BlobServiceClient(new Uri(blobUri), credentials);
            this.container = client.GetBlobContainerClient("files");
            if (!Directory.Exists(Path.Combine(documentFolderPath, "StorageFiles")))
                Directory.CreateDirectory(Path.Combine(documentFolderPath, "StorageFiles"));
            documentFolderPath = Path.Combine(documentFolderPath, "StorageFiles");

        }

        /// <summary>Downloads file to C:/Users/User/Documents/StorageFiles </summary>
        /// <returns>Returns status string</returns>
        public async Task<string> DownloadFile(string downloadFileName, string folderName = "students")
        {
            if (!isInternetAvailable()) return "No internet access";
            BlobClient blob = container.GetBlobClient($"{folderName}/{downloadFileName}");
            if (!await blob.ExistsAsync()) { return "File or folder doesn't exist"; }
            await blob.DownloadToAsync(Path.Combine(documentFolderPath, downloadFileName));
            return "Downloaded successfully";
        }

        /// <summary>Uploads file to remoted storage </summary>
        /// <returns>Returns status string</returns>
        public async Task<string> UploadFile(string uploadFileName, string folderName, string fileText = "", params string[] metadata)
        {
            if (!isInternetAvailable()) return "No internet access";
            if (!uploadFileName.Contains('.')) uploadFileName += ".txt";
            bool exists = File.Exists(uploadFileName);
            File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), uploadFileName), fileText);
            BlobClient blob = container.GetBlobClient($"{folderName}/{uploadFileName}");
            await blob.UploadAsync(uploadFileName, true);
            Dictionary<string, string> metadataDictionary = new();
            foreach (var item in metadata)
            {
                metadataDictionary.Add(item.Split(":")[0], item.Split(":")[1]);
            }
            await blob.SetMetadataAsync(metadataDictionary);
            if (!exists) File.Delete(Path.Combine(Directory.GetCurrentDirectory(), uploadFileName));
            return "Uploaded successfully";
        }

        public async Task<string> CheckAuthorization(string login, string password)
        {
            BlobClient personBlob = container.GetBlobClient($"students/{login}.txt");
            if (personBlob.Exists() && personBlob.GetProperties() != null)
            {
                BlobProperties bp = await personBlob.GetPropertiesAsync();
                if (bp.Metadata["password"] == password) return "student authorized";
                else return "wrong password";
            }
            personBlob = container.GetBlobClient($"professors/{login}.txt");
            if (personBlob.Exists() && personBlob.GetProperties() != null)
            {
                BlobProperties bp = await personBlob.GetPropertiesAsync();
                if (bp.Metadata["password"] == password) return "professor authorized";
                else return "wrong password";
            }
            return "wrong login";
        }
        private bool isInternetAvailable()
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