using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pa00002
    {
        public short Index1 { get; set; }
        public string PaNextDocumentNumber { get; set; }
        public int Actindx { get; set; }
        public byte PaAutoCreateVendors { get; set; }
        public byte PaAutoCreateCustomerVend { get; set; }
        public short PaCreateVendorType { get; set; }
        public string PaDefaultVendorClass { get; set; }
        public string PaNextVendorId { get; set; }
        public string PaDebitDescriptionPrefix { get; set; }
        public string PaVoucherDescrPrefix { get; set; }
        public byte PaAutoOpenSelectChecks { get; set; }
        public byte PaIntegrateEft { get; set; }
        public short PaCreateCustomerType { get; set; }
        public string PaDefaultCustomerClass { get; set; }
        public string PaNextCustomerId { get; set; }
        public string PaPmprefix { get; set; }
        public string PaPmnextDocument { get; set; }
        public string PaRmprefix { get; set; }
        public int PaConsolidationIndex { get; set; }
        public byte Crtmpvnd { get; set; }
        public int DexRowId { get; set; }
    }
}
