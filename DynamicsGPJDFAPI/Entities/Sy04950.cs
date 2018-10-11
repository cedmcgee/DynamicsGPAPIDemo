using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy04950
    {
        public short Prodid { get; set; }
        public decimal Rtgrsbin { get; set; }
        public string ReportOptionName { get; set; }
        public string Rprtname { get; set; }
        public byte EmailSendAttachments { get; set; }
        public short EmailFileFormat { get; set; }
        public int DexRowId { get; set; }
        public string EmailToAddress { get; set; }
        public string EmailCcAddress { get; set; }
        public string EmailBccAddress { get; set; }
    }
}
