using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Order
    {
        public Order()
        {
            Ordercontent = new HashSet<Ordercontent>();
            Orderfoto = new HashSet<Orderfoto>();
            Orderoffer = new HashSet<Orderoffer>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string Additionalinfo { get; set; }
        public DateTime? Orderbegindatetime { get; set; }
        public DateTime? Orderenddatetime { get; set; }
        public int? Orderbuyerid { get; set; }
        public int? Ordersellerid { get; set; }

        public virtual Buyer Orderbuyer { get; set; }
        public virtual Seller Orderseller { get; set; }
        public virtual ICollection<Ordercontent> Ordercontent { get; set; }
        public virtual ICollection<Orderfoto> Orderfoto { get; set; }
        public virtual ICollection<Orderoffer> Orderoffer { get; set; }
    }
}
