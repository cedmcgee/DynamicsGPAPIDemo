using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DynamicsGPAPI.Models
{
    public partial class Ksync
    {
        [Key]
        public string Section { get; set; }
        [Key]
        public string Keyname { get; set; }
        public string Keyvalue { get; set; }
    }
}
