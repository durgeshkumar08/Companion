using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Personservice
    {
        public Personservice()
        {
            Personservicephotolink = new HashSet<Personservicephotolink>();
        }

        public int Id { get; set; }
        public string Additionalinfo { get; set; }
        public int Sellerid { get; set; }

        public virtual Seller Seller { get; set; }
        public virtual ICollection<Personservicephotolink> Personservicephotolink { get; set; }
    }
}
