using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10203
    {
        public string Userid { get; set; }
        public short Pyrntype { get; set; }
        public string Employid { get; set; }
        public int Trxnumber { get; set; }
        public string Payrcord { get; set; }
        public short Prcssqnc { get; set; }
        public short Paytype { get; set; }
        public string Bspayrcd { get; set; }
        public short Bspaytyp { get; set; }
        public decimal Bsdonrte { get; set; }
        public decimal Payrtamt { get; set; }
        public string Payunit { get; set; }
        public short Payunper { get; set; }
        public short Payperod { get; set; }
        public decimal Payprprd { get; set; }
        public decimal Payadvnc { get; set; }
        public short TimetypeI { get; set; }
        public decimal Timeavailable { get; set; }
        public byte Acruvacn { get; set; }
        public byte Acrustim { get; set; }
        public byte Rptaswgs { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public decimal Receipts { get; set; }
        public short TipType { get; set; }
        public string Deprtmnt { get; set; }
        public string Jobtitle { get; set; }
        public string Statecd { get; set; }
        public string Localtax { get; set; }
        public string Sutastat { get; set; }
        public string Wrkrcomp { get; set; }
        public decimal Untstopy { get; set; }
        public decimal Adjunits { get; set; }
        public decimal Totalpay { get; set; }
        public string Bchsourc { get; set; }
        public int Prtrxsrc { get; set; }
        public string Lastuser { get; set; }
        public DateTime Lstdtedt { get; set; }
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public byte[] Bldchwrg { get; set; }
        public byte[] Bldcherr { get; set; }
        public string Shftcode { get; set; }
        public decimal Shftprem { get; set; }
        public int DexRowId { get; set; }
    }
}
