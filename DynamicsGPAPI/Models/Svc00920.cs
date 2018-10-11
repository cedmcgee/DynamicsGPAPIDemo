using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00920
    {
        public string Srvtype { get; set; }
        public string Dscriptn { get; set; }
        public string Labitmst { get; set; }
        public string Labitmov { get; set; }
        public string Labitmdb { get; set; }
        public string HotlineLaborItem { get; set; }
        public string TravelLaborItem { get; set; }
        public string Techid { get; set; }
        public byte Pmflag { get; set; }
        public byte Contflag { get; set; }
        public string SvcServiceBatchId { get; set; }
        public string SvcServiceDocumentId { get; set; }
        public byte SvcSalesOnly { get; set; }
        public string SvcSCreditBatchId { get; set; }
        public string SvcSCreditDocumentId { get; set; }
        public string SvcZeroBatchId { get; set; }
        public string SvcZeroDocumentId { get; set; }
        public string SvcMinimumLabor { get; set; }
        public string SvcMinimumTravel { get; set; }
        public string SvcMinimumHotline { get; set; }
        public string SvcRoundedLabor { get; set; }
        public string SvcRoundedTravel { get; set; }
        public string SvcRoundedHotline { get; set; }
        public int SvcSalesIndexPart { get; set; }
        public int SvcSalesIndexLabor { get; set; }
        public int SvcSalesIndexMisc { get; set; }
        public int SvcSalesIndexExpense { get; set; }
        public int SvcCogsIndexPart { get; set; }
        public int SvcCogsIndexLabor { get; set; }
        public int SvcCogsIndexMisc { get; set; }
        public int SvcCogsIndexExpense { get; set; }
        public int SvcSalesReturnIndex { get; set; }
        public string SvcPayableBatchId { get; set; }
        public byte SvcSubcontractor { get; set; }
        public int DexRowId { get; set; }
    }
}
