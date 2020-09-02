using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OptionMV.Interfaces;
using OptionMV.Models;
using Azure.Storage.Blobs;

namespace OptionMV.Services
{
    public class BlobService :IBlobService 
    {
        private readonly BlobServiceClient _blobServiceClient;
        
        public BlobService(BlobServiceClient blobServiceClient)
        {
            _blobServiceClient = blobServiceClient;
        }
        public async Task<BlobInfo> GetBlobAsync(string blobName)
        {
            var containerClient = _blobServiceClient.GetBlobContainerClient("youtube");
            var blobClient = containerClient.GetBlobClient(blobName);
            var blobDownloadInfo = await blobClient.DownloadAsync();
            return new BlobInfo(blobDownloadInfo.Value.Content, blobDownloadInfo.Value.ContentType) ;
        }

        public Task<IEnumerable<string>> ListBlobAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UploadFileBlobAsync(string filePath, string fileName)
        {
            throw new System.NotImplementedException();
        }

        public Task UploadContentBlobAsync(string content, string fileName)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBlobAsync(string blobName)
        {
            throw new System.NotImplementedException();
        }
    }
}
