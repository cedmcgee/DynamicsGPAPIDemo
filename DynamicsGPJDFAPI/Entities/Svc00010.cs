using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00010
    {
        public string Interid { get; set; }
        public short SvcMajorRelease { get; set; }
        public short SvcMinorRelease { get; set; }
        public string SvcBuildRelease { get; set; }
        public DateTime SvcInstallDate { get; set; }
        public DateTime SvcUpdateDate { get; set; }
        public string SvcServerUpd { get; set; }
        public string SvcClientUpd { get; set; }
        public int DexRowId { get; set; }
    }
}
