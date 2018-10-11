using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop50200
    {
        public short Doctype { get; set; }
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public string Locncode { get; set; }
        public string Custnmbr { get; set; }
        public string Userid { get; set; }
        public int Seqnumbr { get; set; }
        public int Docprintseq { get; set; }
        public string ShipToName { get; set; }
        public string Cntcprsn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Shipmthd { get; set; }
        public byte Reprint { get; set; }
        public short EmailType { get; set; }
        public string Phonname { get; set; }
        public int DexRowId { get; set; }
    }
}
