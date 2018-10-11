using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00700
    {
        public string Orddocid { get; set; }
        public string Rfrncdoc { get; set; }
        public string Techid { get; set; }
        public string Offid { get; set; }
        public short Status { get; set; }
        public DateTime Ordrdate { get; set; }
        public DateTime Etadte { get; set; }
        public string Custname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Shipmthd { get; set; }
        public string Trnsfloc { get; set; }
        public string Itlocn { get; set; }
        public string Locncode { get; set; }
        public decimal Noteindx { get; set; }
        public short SvcAddressOption { get; set; }
        public string SvcMiscAddressCode { get; set; }
        public string Address3 { get; set; }
        public string Country { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
