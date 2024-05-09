using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Web.Accounts.Dto
{
    public class ProfileDto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(15)]
        [Required]
        public string ProfileName { get; set; }

        public List<MemberDto> Members { get; set; }

        public ProfileDto()
        {
            Members = new List<MemberDto>();
        }
    }
}
