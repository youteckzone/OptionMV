using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace OptionMV.Models
{
    public class BlobInfo
    {
        public BlobInfo(Stream blobContent, string blobType)
        {
            MediaContent = blobContent;
            MediaType = blobType;
        }
        public Stream  MediaContent { get; set; }

        public string MediaType { get; set; }
    }
}
