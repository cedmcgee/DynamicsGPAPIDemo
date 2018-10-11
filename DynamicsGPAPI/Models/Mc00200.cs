using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Mc00200
    {
        public int Actindx { get; set; }
        public string Curncyid { get; set; }
        public byte Revalue { get; set; }
        public short Revluhow { get; set; }
        public short PostResultsTo { get; set; }
        public short CurrencyTranslationType { get; set; }
        public DateTime DexRowTs { get; set; }
        public int DexRowId { get; set; }
    }
}
