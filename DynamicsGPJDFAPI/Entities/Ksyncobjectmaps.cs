using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace DynamicsGPAPI.Models
{
    public partial class Ksyncobjectmaps
    {
        [Key]
        public string Tablename { get; set; }
        [Key]
        public string Sproc { get; set; }
        [Key]
        public string Param { get; set; }
        public string Iskey { get; set; }
        public string Field { get; set; }
        public string InsertDefvalue { get; set; }
        public string UpdateDefvalue { get; set; }
        public string DeleteDefvalue { get; set; }
        public string ResultParam { get; set; }
        public string ExecuteDefvalue { get; set; }
    }
}
