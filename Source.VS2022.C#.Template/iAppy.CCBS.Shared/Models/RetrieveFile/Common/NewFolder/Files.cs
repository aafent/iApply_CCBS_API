using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    public class Files
    {
        public string CategoryId { get; set; }
        public byte[] ImageFile { get; set; }
        public string CbsId { get; set; }
        public string CuId { get; set; }
        public string DocumentId { get; set; }
        public string Filename { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool HasImage { get { return (ImageFile != null || ImageFile.Length != 0); } }
    }
}
