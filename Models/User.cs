using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuseumTourBackEnd.Models
{
    public partial class User
    {
        public string Userid { get; set; }
        public string Nickname { get; set; }
        public string Userpwd { get; set; }
        public int? Coright { get; set; }
    }
}
