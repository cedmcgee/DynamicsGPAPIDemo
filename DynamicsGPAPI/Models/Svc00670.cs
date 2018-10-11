using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Svc00670
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; }
        public short SvcContractVersion { get; set; }
        public string Cnttype { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public string Custnmbr { get; set; }
        public string Adrscode { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public byte History { get; set; }
        public short Rencnttyp { get; set; }
        public string Userid { get; set; }
        public int DexRowId { get; set; }
    }
}
