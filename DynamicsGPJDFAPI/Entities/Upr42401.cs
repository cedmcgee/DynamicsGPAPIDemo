using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Upr42401
    {
        public string RestrictionCode { get; set; }
        public short RestrictionType { get; set; }
        public byte PerDayCb { get; set; }
        public byte PerPayPeriodCb { get; set; }
        public byte RequiredStartStopCb { get; set; }
        public byte DepartmentCb { get; set; }
        public byte PositionCb { get; set; }
        public byte StateTaxCb { get; set; }
        public byte LocalTaxCb { get; set; }
        public byte ShiftCb { get; set; }
        public byte DaysWorkedCb { get; set; }
        public byte WeeksWorkedCb { get; set; }
        public byte NotesCb { get; set; }
        public byte RequireElectronicSigna { get; set; }
        public short PerDayMax { get; set; }
        public short PerPeriodMin { get; set; }
        public short PerPeriodMax { get; set; }
        public int DexRowId { get; set; }
    }
}
