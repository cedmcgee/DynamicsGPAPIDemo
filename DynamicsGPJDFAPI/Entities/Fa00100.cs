﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Fa00100
    {
        public int Assetindex { get; set; }
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
        public short Assettype { get; set; }
        public short Assetstatus { get; set; }
        public short Proptype { get; set; }
        public int Assetqty { get; set; }
        public int Assetbegqty { get; set; }
        public decimal Assetcurrmaint { get; set; }
        public decimal Assetytdmaint { get; set; }
        public decimal Assetltdmaint { get; set; }
        public DateTime Lastmaintdate { get; set; }
        public decimal Assessedvalue { get; set; }
        public string Mfgrname { get; set; }
        public string Serlnmbr { get; set; }
        public string Modelnumber { get; set; }
        public DateTime Warrentydate { get; set; }
        public string Custodian { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Dateadded { get; set; }
        public DateTime Deletedate { get; set; }
        public string PhysicalLocationId { get; set; }
        public string AssetLabel { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; }
        public int Lastpurchlineseq { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; }
        public int AaAliasId { get; set; }
        public int DexRowId { get; set; }
    }
}
