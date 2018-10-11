using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DynamicsGPAPI.Models
{
    public partial class Ksyncfields
    {
        [Key]
        public string Tablename { get; set; }
        [Key]
        public string Fieldname { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string DefaultType { get; set; }
        public string DefaultValue { get; set; }
        public string IsUpdatable { get; set; }
        public string IsRequired { get; set; }
        public string IsHidden { get; set; }
        public string AllowFkeyAssign { get; set; }
        public string AllowLookuplink { get; set; }
        public string AllowDatalink { get; set; }
        public string ParamType { get; set; }
        public string ResultParam { get; set; }
        public int? VType { get; set; }
        public int? VSize { get; set; }
        public string Remarks { get; set; }
    }
}
