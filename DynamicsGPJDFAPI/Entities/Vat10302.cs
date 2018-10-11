using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Vat10302
    {
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; }
        public decimal Sqncline { get; set; }
        public string Custnmbr { get; set; }
        public string Ccode { get; set; }
        public string Txrgnnum { get; set; }
        public string Tcc { get; set; }
        public decimal Numass { get; set; }
        public decimal Quantity { get; set; }
        public decimal Lmass { get; set; }
        public string Tmcode { get; set; }
        public string Transnature { get; set; }
        public decimal Suppunits { get; set; }
        public string Tradref { get; set; }
        public decimal Goodsvalue { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime ReferenceDate { get; set; }
        public byte Posted { get; set; }
        public short Voidstts { get; set; }
        public decimal Orgdsval { get; set; }
        public decimal Ortaxamt { get; set; }
        public short Currnidx { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public string Prt { get; set; }
        public string Rgn { get; set; }
        public string Cntryorgn { get; set; }
        public string Prcdrrgm { get; set; }
        public string Inctrms { get; set; }
        public decimal Sttstclvl { get; set; }
        public decimal Orgntngsttstclvl { get; set; }
        public byte IncludedOnReturn { get; set; }
        public string Intrsttrtrnid { get; set; }
        public string Declid { get; set; }
        public string Locncode { get; set; }
        public string Arrdisp { get; set; }
        public string Period { get; set; }
        public string Audittrail { get; set; }
        public int DexRowId { get; set; }
    }
}
