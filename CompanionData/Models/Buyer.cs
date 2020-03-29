using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Buyer
    {
        public Buyer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int Personid { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
