using System;
using System.Collections.Generic;

namespace DynamicsGPJDFAPI.Models
{
    public partial class Rm10201DTO
    {
        public string Bachnumb { get; set; }
        public string Bchsourc { get; set; }
        public string Docnumbr { get; set; }
        public string Custnmbr { get; set; }
        public short Rmdtypal { get; set; }
        public DateTime Docdate { get; set; }
        public short Cshrctyp { get; set; }
        public string Cheknmbr { get; set; }
        public string Chekbkid { get; set; }
        public string Crcardid { get; set; }
        public decimal Disamchk { get; set; }
        public string Curncyid { get; set; }
        public decimal Ndstamnt { get; set; }
        public string Trxdscrn { get; set; }
        public short Onhold { get; set; }
        public byte Posted { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lstedtdt { get; set; }
        public string Lstusred { get; set; }
        public decimal Ortrxamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public byte[] Rmtremsg { get; set; }
        public byte[] Rmdpemsg { get; set; }
        public DateTime Glpostdt { get; set; }
        public byte[] Rmtremsg2 { get; set; }
        public short Pstgstus { get; set; }
        public byte Eftflag { get; set; }
        public int DexRowId { get; set; }
    }
}
