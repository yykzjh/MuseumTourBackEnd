using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MuseumTourBackEnd.Models
{
    public partial class Uploadvideo
    {
        [Key]
        public int Vid { get; set; }
        public int Oid { get; set; }
        public string OriginName { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
    }
}
