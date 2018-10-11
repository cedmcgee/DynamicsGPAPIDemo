using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Do10100
    {
        public string Custnmbr { get; set; }
        public string Docnumbr { get; set; }
        public short Soptype { get; set; }
        public short Rmdtypal { get; set; }
        public int Seqnumbr { get; set; }
        public int Lnitmseq { get; set; }
        public string Paymentserviceref { get; set; }
        public DateTime Date1 { get; set; }
        public short Paymentserviceop { get; set; }
        public decimal Trxamnt { get; set; }
        public short Paymentservicesstatus { get; set; }
        public string Paymentservicessource { get; set; }
        public string DoAuthcode { get; set; }
        public string Ermsgtxt { get; set; }
        public string Addressresult { get; set; }
        public int DexRowId { get; set; }
    }
}
