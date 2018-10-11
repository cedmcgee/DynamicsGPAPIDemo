using System;
using System.Collections.Generic;

namespace DynamicsGPAPI.Models
{
    public partial class Wf00100
    {
        public short Setupkey { get; set; }
        public byte EnableWfnotifService { get; set; }
        public string WebServiceServer { get; set; }
        public int WebServiceServerPort { get; set; }
        public byte WebServiceServerSsl { get; set; }
        public byte EnableWorkflowEmail { get; set; }
        public string Email { get; set; }
        public string Dsplname { get; set; }
        public string Serverid { get; set; }
        public int ServerPort { get; set; }
        public byte IsSsl { get; set; }
        public short SmtpAuthentication { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public int DexRowId { get; set; }
    }
}
