using System;
using System.Collections.Generic;

#nullable disable

namespace DotNEtCore_EntityFramework_MySqlDB
{
    public partial class Car
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public string Image { get; set; }
        public int HireCost { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
    }
}
