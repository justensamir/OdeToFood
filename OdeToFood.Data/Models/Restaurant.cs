using OdeToFood.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
    public class Restaurant
    {

        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:100, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        public Cuisine Cuisine { get; set; }
    }
}
