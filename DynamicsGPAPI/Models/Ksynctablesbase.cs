﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Ksynctablesbase
    {
        public string Tablename { get; set; }
        public string Owner { get; set; }
        public string SubjectArea { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public string Updatable { get; set; }
        public string Hidden { get; set; }
        public string DrsObject { get; set; }
        public string BaseTables { get; set; }
        public string Remarks { get; set; }
        public string FieldInfo { get; set; }
    }
}
