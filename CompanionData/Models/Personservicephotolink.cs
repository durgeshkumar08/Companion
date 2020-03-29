using System;
using System.Collections.Generic;

namespace CompanionData.Models
{
    public partial class Personservicephotolink
    {
        public int Id { get; set; }
        public int? Personserviceid { get; set; }
        public string Link { get; set; }

        public virtual Personservice Personservice { get; set; }
    }
}
