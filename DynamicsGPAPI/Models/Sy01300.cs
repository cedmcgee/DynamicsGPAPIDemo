using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Sy01300
    {
        public short ProcessId { get; set; }
        public short Prodid { get; set; }
        public short LanguageId { get; set; }
        public short Dpseries { get; set; }
        public short LoadFactor { get; set; }
        public string ServiceName { get; set; }
        public short Priority { get; set; }
        public DateTime QueueTime { get; set; }
        public DateTime QueueDate { get; set; }
        public short RecurranceInterval { get; set; }
        public string ScriptName { get; set; }
        public byte Deletable { get; set; }
        public byte DeletableWhenRunning { get; set; }
        public byte Remote { get; set; }
        public string BeginGroupProcessName { get; set; }
        public byte Trkpsatv { get; set; }
        public string ServerNotifyScriptName { get; set; }
        public int DexRowId { get; set; }
    }
}
