﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr10301
    {
        public string Bachnumb { get; set; }
        public short Uprbchor { get; set; }
        public string Bchcomnt { get; set; }
        public short Uprbchfr { get; set; }
        public DateTime Posteddt { get; set; }
        public byte Uprbchmk { get; set; }
        public string Mkdbyusr { get; set; }
        public short Mscbdinc { get; set; }
        public short Recpstgs { get; set; }
        public DateTime Rclpstdt { get; set; }
        public short Nofpstgs { get; set; }
        public int Cntrltrx { get; set; }
        public short Ctrlempct { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
