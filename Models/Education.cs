using System;
using System.Collections.Generic;

namespace MuseumTourBackEnd.Models
{
    public partial class Education
    {
        public int Aid { get; set; }
        public int? Mid { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
