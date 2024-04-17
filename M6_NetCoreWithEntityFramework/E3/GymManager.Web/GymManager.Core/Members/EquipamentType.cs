using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class EquipamentType
    {
        public int Id { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Enter equipament name, try again")]
        public string Name { get; set; }
    }
}
