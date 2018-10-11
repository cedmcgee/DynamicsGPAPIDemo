using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pop40900
    {
        public short Setupkey { get; set; }
        public string DocDelivTempPath { get; set; }
        public string DocDelivEmailSubj { get; set; }
        public string DocDelivFaxSubj { get; set; }
        public string DocDelivStatusRecipient { get; set; }
        public int DexRowId { get; set; }
        public string DocDelivEmailBodyText { get; set; }
        public string DocDelivFaxCoverPgText { get; set; }
    }
}
