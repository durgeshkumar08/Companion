using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Personservicetype
    {
        public int Servicetypeid { get; set; }
        public int Personserviceid { get; set; }

        public virtual Personservice Personservice { get; set; }
        public virtual Servicetype Servicetype { get; set; }
    }
}
