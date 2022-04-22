using System;
using System.Collections.Generic;

#nullable disable

namespace DotNEtCore_EntityFramework_MySqlDB
{
    public partial class Message
    {
        public int MsgId { get; set; }
        public int ClientId { get; set; }
        public string Message1 { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
    }
}
