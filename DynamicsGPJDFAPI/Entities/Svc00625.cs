﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00625
    {
        public string Userid { get; set; }
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public string Cnttype { get; set; }
        public string Custnmbr { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public decimal TransactionAmount { get; set; }
        public decimal OrigTransactionAmount { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; }
        public string Ermsgtx2 { get; set; }
        public int DexRowId { get; set; }
    }
}
