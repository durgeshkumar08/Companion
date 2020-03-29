using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Orderoffer
    {
        public int Id { get; set; }
        public float? OrderCost { get; set; }
        public float? BuyerOrderCost { get; set; }
        public bool? Activ { get; set; }
        public int? OrderId { get; set; }
        public int? SellerId { get; set; }
        public int? ChatcontentId { get; set; }

        public virtual Chatcontent Chatcontent { get; set; }
        public virtual Order Order { get; set; }
        public virtual Seller Seller { get; set; }
    }
}
