using NistApi.Request.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistApi.Request
{
    public interface IFileService
    {
        public bool Write(List<Root> models, string filePath);
    }
}
