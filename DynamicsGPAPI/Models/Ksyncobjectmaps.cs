using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ksyncobjectmaps
    {
        public string Tablename { get; set; }
        public string Sproc { get; set; }
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
