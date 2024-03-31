using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class MembershipTypes
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Enter member name, try again")]
        public string Name { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Enter member Lastname, try again")]
        public string LastName { get; set; }

        [Range(typeof(double), "0.01", "9999999999.99")]
        [Required(ErrorMessage = "Enter a valid value.")]
        public double Cost { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }

        [RegularExpression(@"^(1[0-2]?|[1-9])$", ErrorMessage = "El valor debe ser un entero entre 1 y 12")]
        public int Duration { get; set; }
        public bool AllowsNewsLetter { get; set; }
    }
}
