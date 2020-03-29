using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Order = new HashSet<Order>();
            Orderoffer = new HashSet<Orderoffer>();
            Personservice = new HashSet<Personservice>();
        }

        public int Id { get; set; }
        public int Personid { get; set; }

        public virtual Person Person { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Orderoffer> Orderoffer { get; set; }
        public virtual ICollection<Personservice> Personservice { get; set; }
    }
}
