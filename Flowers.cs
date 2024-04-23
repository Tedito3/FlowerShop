using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerShop3.Models
{
    public class Flowers
    {
        public int Id { get; set; }

        [Display(Name = "Type of the Flower")]
        [StringLength(10)]
        public string FlowerName { get; set; }
        [Display(Name = "Colour of the Flower")]
        [StringLength(10)]
        public string FlowerColour { get; set; }

        [Display(Name = "Flower Amount")]
        [Range(1, 100.00,
            ErrorMessage = "You can only take between 1 and 100 flowers, sorry")]
        public int FlowerAmount { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}