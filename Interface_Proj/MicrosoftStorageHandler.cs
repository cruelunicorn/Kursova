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
        // З файлу credentials.txt
        private readonly string accountName = "";
        private readonly string accessKey = "";
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
            if (!IsInternetAvailable()) return "No internet access";
            BlobClient blob = this.container.GetBlobClient($"{folderName}/{downloadFileName}");
            if (!await blob.ExistsAsync()) { return "File or folder doesn't exist"; }
            await blob.DownloadToAsync(Path.Combine(documentFolderPath, downloadFileName));
            return "Downloaded successfully";
        }

        /// <summary>Uploads file to remoted storage </summary>
        /// <returns>Returns status string</returns>
        public async Task<string> UploadFile(string uploadFileName, string folderName = "students")
        {
            if (!IsInternetAvailable()) return "No internet access";
            if (!File.Exists(uploadFileName)) { return "File doesn't exist"; }
            BlobClient blob = this.container.GetBlobClient($"{folderName}/{uploadFileName}");
            await blob.UploadAsync(uploadFileName, true);
            return "Uploaded successfully";
        }

        /// <returns>
        /// <para>"student authorized" when student authorized </para>
        /// <para>"professor authorized" when professor authorized</para>
        /// <para>"wrong password" when login found but password not</para>
        /// <para>"wrong login" when login not found, password is not searched</para>
        /// </returns>
        public async Task<string> CheckAuthorization(string login, string password)
        {
            if (!IsInternetAvailable()) return "";
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