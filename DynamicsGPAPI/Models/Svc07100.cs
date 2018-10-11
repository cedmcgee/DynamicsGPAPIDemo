using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc07100
    {
        public int SvcIssueNumber { get; set; }
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; }
        public string SvcCbrNumber { get; set; }
        public short SvcAction { get; set; }
        public byte SvcTemplateCallNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
