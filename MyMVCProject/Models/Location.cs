using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCProject.Models
{
    public class Location
    {
        [Key]
        public int Myproperty { get; set; }
        public string Name { get; set; }
    }
}
