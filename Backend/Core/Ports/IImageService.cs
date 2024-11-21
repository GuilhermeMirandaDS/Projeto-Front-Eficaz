using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginEficaz.Core.Entities;

namespace LoginEficaz.Core.Ports
{
    public interface IImageService
    {
        public Task<string> UploadImage(FileData file, string folderName, string fileName);
    }
}
