using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop10210
    {
        public string PoprequisitionNumber { get; set; }
        public int Ord { get; set; }
        public short RequisitionLineStatus { get; set; }
        public short LineNumber { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public decimal ItemNumberNoteIndex { get; set; }
        public string Vendorid { get; set; }
        public decimal VendorNoteIndex { get; set; }
        public short Noninven { get; set; }
        public string Uofm { get; set; }
        public decimal Umqtyinb { get; set; }
        public string Locncode { get; set; }
        public decimal LocationCodeNoteIndex { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycmtbase { get; set; }
        public decimal Qtyuncmtbase { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Orextcst { get; set; }
        public DateTime Reqdate { get; set; }
        public string Reqstdby { get; set; }
        public int Invindx { get; set; }
        public decimal Accntntindx { get; set; }
        public string Curncyid { get; set; }
        public decimal CurrencyNoteIndex { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public short Odecplcu { get; set; }
        public short Itmtrkop { get; set; }
        public short Vctnmthd { get; set; }
        public string Adrscode { get; set; }
        public string Cmpnynam { get; set; }
        public string Contact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Ccode { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public short PrintPhoneNumberGb { get; set; }
        public short Addrsource { get; set; }
        public short Flags { get; set; }
        public string Shipmthd { get; set; }
        public decimal ShippingMethodNoteIndex { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public int InvalidDataFlag { get; set; }
        public string Commntid { get; set; }
        public decimal CommentNoteIndex { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
