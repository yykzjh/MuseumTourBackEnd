using System;
using System.Collections.Generic;

namespace MuseumTourBackEnd.Models
{
    public partial class Collection
    {
        public int Oid { get; set; }
        public int Midex { get; set; }
        public string Oname { get; set; }
        public string Ointro { get; set; }
        public string Ophoto { get; set; }
    }
}
