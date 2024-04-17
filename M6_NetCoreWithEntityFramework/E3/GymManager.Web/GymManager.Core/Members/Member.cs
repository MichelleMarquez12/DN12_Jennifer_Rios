using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Core.Members
{
    public class Member
    {
        public int Id { get; set; }

        [StringLength (45)]

        [Required(ErrorMessage = "Enter member name, try again")]
        public string Name { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Enter member Lastname, try again")]
        public string LastName { get; set; }

        [EmailAddress]

        [Required(ErrorMessage = "Enter member Email, try again")]
        public string Email { get; set; }

        [StringLength(250)]

        [Required(ErrorMessage = "Enter address, try again")]
        public string Address { get; set; }

        [Phone]

        [Required(ErrorMessage = "Enter phone number, try again")]
        public string Phone { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        public bool AllowsNewsLetter { get; set; }

        [Range(1, 100)]
        public int City_Id { get; set; }
        public int MembershipTypes_Id { get; set; }
    }
}
