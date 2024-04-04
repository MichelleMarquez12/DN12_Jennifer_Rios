using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class MemberViewModel
    {
        public int Id { get; set; }

        [StringLength(45)]

        [Required(ErrorMessage = "Enter member name, try again")]
        public string Name { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Enter member Lastname, try again")]
        public string LastName { get; set; }

        [EmailAddress]

        [Required(ErrorMessage = "Enter member Email, try again")]
        public string Email { get; set; }

        [Phone]

        [Required(ErrorMessage = "Enter phone number, try again")]
        public string Phone { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        [Range(1, 100)]
        public int IdCities { get; set; }

        public bool AllowsNewsLetter { get; set; }
    }
}
