using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Person
    {
        public Person()
        {
            Buyer = new HashSet<Buyer>();
            Seller = new HashSet<Seller>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Telefon { get; set; }
        public string AdditionalInfo { get; set; }

        public virtual ICollection<Buyer> Buyer { get; set; }
        public virtual ICollection<Seller> Seller { get; set; }
    }
}
