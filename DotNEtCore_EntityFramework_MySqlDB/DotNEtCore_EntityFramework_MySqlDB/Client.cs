using System;
using System.Collections.Generic;

#nullable disable

namespace DotNEtCore_EntityFramework_MySqlDB
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string Fname { get; set; }
        public string Email { get; set; }
        public int IdNo { get; set; }
        public int Phone { get; set; }
        public string Location { get; set; }
        public string Gender { get; set; }
        public int CarId { get; set; }
        public string Status { get; set; }
        public string Mpesa { get; set; }
    }
}
