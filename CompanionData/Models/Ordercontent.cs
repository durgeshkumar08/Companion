using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Ordercontent
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }

        public virtual Order Order { get; set; }
    }
}
