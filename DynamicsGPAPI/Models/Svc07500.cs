using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc07500
    {
        public string Techid { get; set; }
        public string Userid { get; set; }
        public string Accessidlst { get; set; }
        public DateTime SvcLastConnDate { get; set; }
        public DateTime SvcLastConnTime { get; set; }
        public DateTime SvcLastDisConnDate { get; set; }
        public DateTime SvcLastDisConnTime { get; set; }
        public short SvcETechStatus { get; set; }
        public string SvcMapLocation1 { get; set; }
        public string SvcMapLocation2 { get; set; }
        public byte Active { get; set; }
        public DateTime SvcLastAccessDate { get; set; }
        public DateTime SvcLastAccessTime { get; set; }
        public int DexRowId { get; set; }
    }
}
