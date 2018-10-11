using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Gl00100
    {
        public int Actindx { get; set; }
        public string Actnumbr1 { get; set; }
        public string Actnumbr2 { get; set; }
        public string Actnumbr3 { get; set; }
        public string Actnumbr4 { get; set; }
        public string Actnumbr5 { get; set; }
        public string Actalias { get; set; }
        public string Mnacsgmt { get; set; }
        public short Accttype { get; set; }
        public string Actdescr { get; set; }
        public short Pstngtyp { get; set; }
        public short Accatnum { get; set; }
        public byte Active { get; set; }
        public short Tpclblnc { get; set; }
        public short Decplacs { get; set; }
        public short Fxdorvar { get; set; }
        public short Balfrclc { get; set; }
        public byte[] Dsplkups { get; set; }
        public short Cnvrmthd { get; set; }
        public decimal Hstrclrt { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string Userdef1 { get; set; }
        public string Userdef2 { get; set; }
        public short PostSlsIn { get; set; }
        public short PostIvIn { get; set; }
        public short PostPurchIn { get; set; }
        public short PostPrin { get; set; }
        public byte Adjinfl { get; set; }
        public int Inflarev { get; set; }
        public int Inflaequ { get; set; }
        public byte Acctentr { get; set; }
        public string Usrdefs1 { get; set; }
        public string Usrdefs2 { get; set; }
        public byte ClearBalance { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
