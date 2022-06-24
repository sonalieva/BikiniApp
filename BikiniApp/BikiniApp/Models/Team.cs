using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikiniApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Desc { get; set; }
        public string Image { get; set; }
    }
}
