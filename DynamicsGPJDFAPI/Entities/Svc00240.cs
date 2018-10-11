using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00240
    {
        public string Callnbr { get; set; }
        public short Srvrectype { get; set; }
        public string Srvccd { get; set; }
        public string Taskcd { get; set; }
        public byte Taskreq { get; set; }
        public byte Taskcomp { get; set; }
        public string Taskuserid { get; set; }
        public DateTime Taskdate { get; set; }
        public DateTime Tasktime { get; set; }
        public string Taskettc { get; set; }
        public string Taskattc { get; set; }
        public string Techid { get; set; }
        public int DexRowId { get; set; }
    }
}
