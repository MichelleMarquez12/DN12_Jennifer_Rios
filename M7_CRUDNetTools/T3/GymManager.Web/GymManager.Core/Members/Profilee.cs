using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Profilee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        [Required]
        public string ProfileName { get; set; }

        public List<Member> Members { get; set; }

        public Profilee() 
        { 
            Members = new List<Member>();
        }
    }
}
