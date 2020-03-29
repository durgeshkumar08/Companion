using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Orderfoto
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public int? Orderid { get; set; }

        public virtual Order Order { get; set; }
    }
}
