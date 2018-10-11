using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00660
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; }
        public string Custnmbr { get; set; }
        public string Custname { get; set; }
        public string Adrscode { get; set; }
        public string Cnttype { get; set; }
        public short ContractLength { get; set; }
        public short ContractPeriod { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte Prepaid { get; set; }
        public string Pricshed { get; set; }
        public short Billngth { get; set; }
        public short Bilprd { get; set; }
        public DateTime Bilstrt { get; set; }
        public DateTime Bilend { get; set; }
        public short Bilondy { get; set; }
        public short Bilcyc { get; set; }
        public short SvcLiabilityType { get; set; }
        public string BillToCustomer { get; set; }
        public string SvcBillToAddressCode { get; set; }
        public string Pordnmbr { get; set; }
        public byte SvcInvoiceDetail { get; set; }
        public decimal Partpct { get; set; }
        public decimal Labpct { get; set; }
        public decimal Miscpct { get; set; }
        public decimal Pmprtpct { get; set; }
        public decimal Pmlabpct { get; set; }
        public decimal Pmmscpct { get; set; }
        public byte SvcPaidContract { get; set; }
        public short Dscpctam { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short SvcBillingFrequency { get; set; }
        public short SvcFrequencyQty { get; set; }
        public int DexRowId { get; set; }
    }
}
