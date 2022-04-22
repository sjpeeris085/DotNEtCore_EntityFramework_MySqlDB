using System;
using System.Collections.Generic;

#nullable disable

namespace DotNEtCore_EntityFramework_MySqlDB
{
    public partial class Hire
    {
        public int HireId { get; set; }
        public int ClientId { get; set; }
        public int CarId { get; set; }
        public string Status { get; set; }
    }
}
