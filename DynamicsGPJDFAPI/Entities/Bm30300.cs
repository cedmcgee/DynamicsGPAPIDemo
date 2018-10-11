using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Bm30300
    {
        public string TrxId { get; set; }
        public int ComponentId { get; set; }
        public int ParentComponentId { get; set; }
        public string Itemnmbr { get; set; }
        public string Itemdesc { get; set; }
        public string Uofm { get; set; }
        public string Locncode { get; set; }
        public decimal LocationCodeNoteIndex { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal AssembleQuantity { get; set; }
        public short BmStockMethod { get; set; }
        public short CostType { get; set; }
        public int Invindx { get; set; }
        public string InventoryAccountReference { get; set; }
        public int VarianceIndex { get; set; }
        public string VarianceAccountReference { get; set; }
        public decimal DesignQuantity { get; set; }
        public short ScrapPercentage { get; set; }
        public decimal Stndcost { get; set; }
        public decimal StandardQuantity { get; set; }
        public decimal ExtendedStandardCost { get; set; }
        public decimal ExtendedStandardQuantity { get; set; }
        public decimal ExtAssembleQtyPostingCost { get; set; }
        public decimal ExtStockReceiptCost { get; set; }
        public decimal ExtStockQtyPostingCost { get; set; }
        public decimal ExtSubasmPostingCost { get; set; }
        public decimal ExtSubasmReceiptCost { get; set; }
        public short BmComponentType { get; set; }
        public short Lvl { get; set; }
        public decimal Qtybsuom { get; set; }
        public decimal AssembleSerialLotCount { get; set; }
        public decimal StockSerialLotCount { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short Itmtrkop { get; set; }
        public decimal Noteindx { get; set; }
        public decimal InventoryAccountNoteI { get; set; }
        public decimal VarianceAccountNoteIn { get; set; }
        public byte[] BmComponentErrors { get; set; }
        public string Trxsorce { get; set; }
        public string Bin { get; set; }
        public int DexRowId { get; set; }
    }
}
