using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuseumTourBackEnd.Models
{
    public partial class Admin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Roles { get; set; }
    }
}
