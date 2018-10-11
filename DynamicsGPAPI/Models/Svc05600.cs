using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc05600
    {
        public string RtvNumber { get; set; }
        public string RtvType { get; set; }
        public string RtvReturnStatus { get; set; }
        public short RtvStatus { get; set; }
        public string VrmaDocumentId { get; set; }
        public string Retdocid { get; set; }
        public decimal Lnseqnbr { get; set; }
        public string Dscriptn { get; set; }
        public string Vendorid { get; set; }
        public string Vendname { get; set; }
        public string Adrscode { get; set; }
        public string ShipAddressName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipState { get; set; }
        public string Zipcode { get; set; }
        public string ShipCountry { get; set; }
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Prmdate { get; set; }
        public DateTime PromisedTime { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime ShippedTime { get; set; }
        public DateTime Receiptdate { get; set; }
        public DateTime ReceiptTime { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public string Loccodeb { get; set; }
        public string Locncode { get; set; }
        public decimal PartPrice { get; set; }
        public decimal PartCost { get; set; }
        public decimal LaborPrice { get; set; }
        public decimal LaborCost { get; set; }
        public decimal ExpensePrice { get; set; }
        public decimal ExpenseCost { get; set; }
        public decimal TravelPrice { get; set; }
        public decimal TravelCost { get; set; }
        public string BillOfLadingOut { get; set; }
        public string ShippingMethodOut { get; set; }
        public string BillOfLading { get; set; }
        public string Shipmthd { get; set; }
        public string Offid { get; set; }
        public decimal Noteindx { get; set; }
        public string Vchnumwk { get; set; }
        public string VoucherNumberInvoice { get; set; }
        public string VoucherNumberReimburse { get; set; }
        public byte Custown { get; set; }
        public string Userid { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public string Usrdef03 { get; set; }
        public string Usrdef04 { get; set; }
        public string Usrdef05 { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; }
        public string Exgtblid { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public short Decplacs { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public short Viewmode { get; set; }
        public short Ismctrx { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal OriginatingPartPrice { get; set; }
        public decimal OriginatingPartCost { get; set; }
        public decimal OriginatingLaborPrice { get; set; }
        public decimal OriginatingLaborCost { get; set; }
        public decimal OriginatingExpensePrice { get; set; }
        public decimal OriginatingExpenseCost { get; set; }
        public decimal OriginatingTravelPrice { get; set; }
        public decimal OriginatingTravelCost { get; set; }
        public short Voidstts { get; set; }
        public int DexRowId { get; set; }
    }
}
