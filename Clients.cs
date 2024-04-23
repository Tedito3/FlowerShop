using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowerShop3.Models
{
    public class Clients
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [StringLength(10)]
        public string FirstName { get; set; }

        [DisplayName("Surname")]
        [StringLength(10)]
        public string FamilyName { get; set; }

        [DisplayName("Address")]
        [StringLength(30)]
        public string Address { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}