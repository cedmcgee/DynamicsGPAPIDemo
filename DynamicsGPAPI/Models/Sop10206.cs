using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sop10206
    {
        public string Bachnumb { get; set; }
        public string Locncode { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime BulkPrintDate { get; set; }
        public short Timesprt { get; set; }
        public int DexRowId { get; set; }
    }
}
