using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl10100
    {
        public string Bsnsfmid { get; set; }
        public int Jrnentry { get; set; }
        public string Curncyid { get; set; }
        public int Offindx { get; set; }
        public DateTime Trxdate { get; set; }
        public decimal Trxbalnc { get; set; }
        public short Pstgstus { get; set; }
        public string Lastuser { get; set; }
        public DateTime Lstdtedt { get; set; }
        public string Uswhpstd { get; set; }
        public decimal Pstdamnt { get; set; }
        public string Refrence { get; set; }
        public string Sourcdoc { get; set; }
        public decimal Sqncline { get; set; }
        public string Trxsorce { get; set; }
        public byte[] Glhdrmsg { get; set; }
        public byte[] Glhdrms2 { get; set; }
        public decimal Noteindx { get; set; }
        public byte[] Glhdrval { get; set; }
        public short Periodid { get; set; }
        public short Openyear { get; set; }
        public short Closedyr { get; set; }
        public int Errstate { get; set; }
        public byte Histrx { get; set; }
        public short Offactyp { get; set; }
        public short Offblclc { get; set; }
        public short Offxvar { get; set; }
        public short Offpstyp { get; set; }
        public DateTime Docdate { get; set; }
        public byte Voided { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
