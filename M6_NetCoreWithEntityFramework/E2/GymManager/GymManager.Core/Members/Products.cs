using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public string Product { get; set; }

        public string ProductType { get; set; }
    }
}
