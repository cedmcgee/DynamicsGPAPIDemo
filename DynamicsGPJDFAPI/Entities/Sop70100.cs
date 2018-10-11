using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop70100
    {
        public string Inqid { get; set; }
        public byte History { get; set; }
        public byte Unpsttrx { get; set; }
        public short Sortby { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string User2ent { get; set; }
        public string Stcustid { get; set; }
        public string Encustid { get; set; }
        public string Stcustnm { get; set; }
        public string Encstnam { get; set; }
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public string Stdocnum { get; set; }
        public string Endocnum { get; set; }
        public short Stsoptyp { get; set; }
        public short Edsoptyp { get; set; }
        public string Sttdocid { get; set; }
        public string Enddocid { get; set; }
        public string Sttitnum { get; set; }
        public string Enitmnbr { get; set; }
        public int Stmstnmb { get; set; }
        public int Edmasnmb { get; set; }
        public string Sttphon1 { get; set; }
        public string Endphon1 { get; set; }
        public DateTime Stquoexd { get; set; }
        public DateTime Edquoexd { get; set; }
        public DateTime Streqdat { get; set; }
        public DateTime Endreqdt { get; set; }
        public string Stsprsid { get; set; }
        public string Enspsnid { get; set; }
        public string Sttudef1 { get; set; }
        public string Enusrdf1 { get; set; }
        public short StartPurchasingStatus { get; set; }
        public short EndPurchasingStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
