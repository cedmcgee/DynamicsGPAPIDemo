﻿using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Pp000030
    {
        public short PpUserSecurityType { get; set; }
        public string Userid { get; set; }
        public string PpProfileName { get; set; }
        public byte PpUserAccess { get; set; }
        public byte PpEditProfileOriginal { get; set; }
        public byte PpEditProfileOffsetA { get; set; }
        public byte PpEditProfileDeferred { get; set; }
        public byte PpEditProfileCiAccou { get; set; }
        public byte PpEditProfileTransfer { get; set; }
        public byte PpEditProfileStartDa { get; set; }
        public byte PpEditProfileCalculat { get; set; }
        public byte PpEditProfilePeriods { get; set; }
        public byte PpEditProfileMiscella { get; set; }
        public byte PpEditDebitCredit { get; set; }
        public short PpModule { get; set; }
        public int DexRowId { get; set; }
    }
}
