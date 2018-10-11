using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Do50100
    {
        public string Custnmbr { get; set; }
        public short AddressVerificationOpt { get; set; }
        public string Adrscode { get; set; }
        public string Cntcprsn { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int NextElectronicNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
