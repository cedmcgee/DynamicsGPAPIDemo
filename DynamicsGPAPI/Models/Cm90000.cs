using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Cm90000
    {
        public string Filename { get; set; }
        public short EftfileStatus { get; set; }
        public string Chekbkid { get; set; }
        public DateTime Time1 { get; set; }
        public string FilePath { get; set; }
        public short EftfileType { get; set; }
        public short EfttransmissionType { get; set; }
        public DateTime EftfileGeneratedDate { get; set; }
        public string EftfileGeneratedUserId { get; set; }
        public DateTime EftfileSentDate { get; set; }
        public string EftfileSentUserId { get; set; }
        public int DexRowId { get; set; }
    }
}
