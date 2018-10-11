using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Bm10200
    {
        public string TrxId { get; set; }
        public short BmTrxStatus { get; set; }
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public decimal BatchIdNoteIndex { get; set; }
        public DateTime CompletionDate { get; set; }
        public DateTime BmStartDate { get; set; }
        public DateTime Trxdate { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Refrence { get; set; }
        public short QuantityShortageStatus { get; set; }
        public byte[] BmTrxErrors { get; set; }
        public byte[] BmComponentErrors { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Modifdt { get; set; }
        public string User2ent { get; set; }
        public DateTime Creatddt { get; set; }
        public string Ptdusrid { get; set; }
        public DateTime Posteddt { get; set; }
        public string Trxsorce { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public string Usrdef03 { get; set; }
        public string Usrdef04 { get; set; }
        public int DexRowId { get; set; }
    }
}
