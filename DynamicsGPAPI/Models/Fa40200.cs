using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa40200
    {
        public int Bookindx { get; set; }
        public string Bookid { get; set; }
        public string Bookdesc { get; set; }
        public short Deprperiod { get; set; }
        public short Currfiscalyr { get; set; }
        public short Year1 { get; set; }
        public byte AutoAddBookInfo { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public byte Ptgenled { get; set; }
        public short LedgerId { get; set; }
        public string Calndrid { get; set; }
        public int DexRowId { get; set; }
    }
}
