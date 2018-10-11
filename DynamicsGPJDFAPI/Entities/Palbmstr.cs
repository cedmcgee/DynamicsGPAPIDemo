using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Palbmstr
    {
        public string LockboxId { get; set; }
        public string LockboxDescription { get; set; }
        public short PaLockboxFormatType { get; set; }
        public string Strga255 { get; set; }
        public string LockboxFileName { get; set; }
        public short Xprtftyp { get; set; }
        public string Chekbkid { get; set; }
        public short PaApplyMethod { get; set; }
        public short PaApplyMethodInvoice { get; set; }
        public short Decplcur { get; set; }
        public int OmitStartRecords { get; set; }
        public int OmitLastRecords { get; set; }
        public string PaHeaderRowIndicator { get; set; }
        public string PaDeailRowIndicator { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
