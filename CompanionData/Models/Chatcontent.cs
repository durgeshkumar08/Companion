using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Chatcontent
    {
        public Chatcontent()
        {
            Orderoffer = new HashSet<Orderoffer>();
        }

        public int Id { get; set; }
        public DateTime? Begin { get; set; }
        public DateTime? End { get; set; }

        public virtual ICollection<Orderoffer> Orderoffer { get; set; }
    }
}
