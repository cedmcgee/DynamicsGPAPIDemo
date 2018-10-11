using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Tx00201
    {
        public string Taxdtlid { get; set; }
        public string Txdtldsc { get; set; }
        public short Txdtltyp { get; set; }
        public int Actindx { get; set; }
        public string Txidnmbr { get; set; }
        public short Txdtlbse { get; set; }
        public decimal Txdtlpct { get; set; }
        public decimal Txdtlamt { get; set; }
        public short Tdtlrndg { get; set; }
        public string Txdbodtl { get; set; }
        public decimal Tdtabmin { get; set; }
        public decimal Tdtabmax { get; set; }
        public decimal Tdtaxmin { get; set; }
        public decimal Tdtaxmax { get; set; }
        public short Tdrngtyp { get; set; }
        public short Txdtqual { get; set; }
        public byte Tdtaxtax { get; set; }
        public byte Txdtlpdc { get; set; }
        public string Txdtlpch { get; set; }
        public byte Txdxdisc { get; set; }
        public string Cmnytxid { get; set; }
        public decimal Noteindx { get; set; }
        public string Name { get; set; }
        public string Cntcprsn { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Txusrdf1 { get; set; }
        public string Txusrdf2 { get; set; }
        public byte Vatregtx { get; set; }
        public byte TaxInvReqd { get; set; }
        public short TaxPostToAcct { get; set; }
        public byte[] TaxBoxes { get; set; }
        public byte Ignrgrssamnt { get; set; }
        public decimal Tdtabpct { get; set; }
        public int DexRowId { get; set; }
    }
}
