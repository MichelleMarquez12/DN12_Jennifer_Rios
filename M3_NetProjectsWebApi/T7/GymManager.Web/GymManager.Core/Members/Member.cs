using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GymManager.Core.Members
{
    public class Member
    {
        public int Id { get; set; }
        [StringLength (25)]

        [Required(ErrorMessage = "Enter member name, try again")]
        public string Name { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Enter member Lastname, try again")]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        //Es de tipo int porque en vista se presentara como liista despegable de ciudades
        //por ello se crea su modelo City.cs
        [Range (1, 100)]
        public int CityId { get; set; }

        [EmailAddress]

        [Required(ErrorMessage = "Enter member Email, try again")]
        public string Email { get; set; }
        public bool AllowsNewsLetter { get; set; }
    }
}
