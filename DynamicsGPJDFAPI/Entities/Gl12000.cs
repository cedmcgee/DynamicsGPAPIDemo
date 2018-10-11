using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl12000
    {
        public string Bchsourc { get; set; }
        public string Bachnumb { get; set; }
        public int Jrnentry { get; set; }
        public string Budgetid { get; set; }
        public string Refrence { get; set; }
        public DateTime Trxdate { get; set; }
        public short Pstgstus { get; set; }
        public string Lastuser { get; set; }
        public DateTime Lstdtedt { get; set; }
        public string Uswhpstd { get; set; }
        public string Sourcdoc { get; set; }
        public string Trxsorce { get; set; }
        public int Errstate { get; set; }
        public byte[] Glhdrval { get; set; }
        public byte[] Glhdrmsg { get; set; }
        public byte[] Glhdrms2 { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
