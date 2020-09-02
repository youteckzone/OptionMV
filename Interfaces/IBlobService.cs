using OptionMV.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OptionMV.Interfaces
{
    public interface IBlobService
    {
        public Task<BlobInfo> GetBlobAsync(string blobName);

        public Task<IEnumerable<string>> ListBlobAsync();

        public Task UploadFileBlobAsync(string filePath, string fileName);

        public Task UploadContentBlobAsync(string content, string fileName);

        public Task DeleteBlobAsync(string blobName);
    }
}
