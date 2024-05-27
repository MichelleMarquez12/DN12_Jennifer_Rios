using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Accounts.Dto
{
    public class MembershipTypesDto
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Enter member name, try again")]
        public string Name { get; set; }

        [Range(typeof(double), "0.01", "9999999999.99")]
        [Required(ErrorMessage = "Enter a valid value.")]
        public double Costo { get; set; }
    }
}
