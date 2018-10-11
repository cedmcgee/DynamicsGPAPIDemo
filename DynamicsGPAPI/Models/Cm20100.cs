using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm20100
    {
        public decimal Cmdnumwk { get; set; }
        public decimal RecNumControl { get; set; }
        public byte Voided { get; set; }
        public short Cntrltyp { get; set; }
        public string Audittrail { get; set; }
        public string Chekbkid { get; set; }
        public short CmtrxType { get; set; }
        public string CmtrxNum { get; set; }
        public byte[] Cmerrmsg { get; set; }
        public int DexRowId { get; set; }
    }
}
