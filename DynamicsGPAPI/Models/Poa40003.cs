using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Poa40003
    {
        public string Ponumber { get; set; }
        public string Vendorid { get; set; }
        public short Statgrp { get; set; }
        public DateTime Docdate { get; set; }
        public string PoaCreatedBy { get; set; }
        public short PoaPoApprovalStatus { get; set; }
        public decimal Remsubto { get; set; }
        public string PoaApprovedBy { get; set; }
        public DateTime Apprvldt { get; set; }
        public DateTime PoaApprovalTime { get; set; }
        public int DexRowId { get; set; }
    }
}
