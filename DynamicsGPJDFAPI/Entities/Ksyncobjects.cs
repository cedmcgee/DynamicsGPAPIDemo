using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DynamicsGPAPI.Models
{
    public partial class Ksyncobjects
    {
        [Key]
        public string Tablename { get; set; }
        public string InsertSproc { get; set; }
        public string UpdateSproc { get; set; }
        public string DeleteSproc { get; set; }
        public string InsertErrorSproc { get; set; }
        public string UpdateErrorSproc { get; set; }
        public string DeleteErrorSproc { get; set; }
        public string ForceUpdatePreseek { get; set; }
        public string ForceDeletePreseek { get; set; }
        public string ExecuteSproc { get; set; }
        public string ExecuteErrorSproc { get; set; }
    }
}
