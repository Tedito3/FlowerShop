using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerShop3.Models
{
    public class Sales
    {
        public int Id { get; set; }

        [Display(Name = "Take Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TakeDate { get; set; }
        [DisplayName("Client")]
        public int ClientId { get; set; }
        [DisplayName("Flower")]
        public int FlowerId { get; set; }

        public virtual Clients Client { get; set; }

        public virtual Flowers Flower { get; set; }

    }
}