using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa01100
    {
        public int FaApPostIndex { get; set; }
        public byte Marked { get; set; }
        public short Faprimary { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Orappamt { get; set; }
        public int PurchasedQuantity { get; set; }
        public int AppliedQuantity { get; set; }
        public string Assetid { get; set; }
        public short Assetidsuf { get; set; }
        public string Shrtname { get; set; }
        public string Assetdesc { get; set; }
        public string Extassetdesc { get; set; }
        public string MasterAssetId { get; set; }
        public string Structureid { get; set; }
        public string Assetclassid { get; set; }
        public string Locatnid { get; set; }
        public DateTime Acqdate { get; set; }
        public decimal AcquisitionCost { get; set; }
        public decimal OrigAcquisitionCost { get; set; }
        public short Assettype { get; set; }
        public short Proptype { get; set; }
        public int Assetqty { get; set; }
        public int Assetbegqty { get; set; }
        public decimal Assetcurrmaint { get; set; }
        public decimal Assetytdmaint { get; set; }
        public decimal Assetltdmaint { get; set; }
        public DateTime Lastmaintdate { get; set; }
        public decimal Assessedvalue { get; set; }
        public string Vendorid { get; set; }
        public string Docnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public string Trxsorce { get; set; }
        public string Orctrnum { get; set; }
        public string Pordnmbr { get; set; }
        public string PoLine { get; set; }
        public string Mfgrname { get; set; }
        public string Serlnmbr { get; set; }
        public string Modelnumber { get; set; }
        public DateTime Warrentydate { get; set; }
        public string Custodian { get; set; }
        public DateTime Dateadded { get; set; }
        public DateTime Deletedate { get; set; }
        public string PhysicalLocationId { get; set; }
        public string AssetLabel { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; }
        public string Curncyid { get; set; }
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public string Exgtblid { get; set; }
        public string Ratetpid { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int DexRowId { get; set; }
    }
}
