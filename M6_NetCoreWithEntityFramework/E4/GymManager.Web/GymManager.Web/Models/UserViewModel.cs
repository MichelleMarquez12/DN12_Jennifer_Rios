using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class UserViewModel
    {
        [EmailAddress]
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Password { get; set; }

        public string Id { get; set; }
    }
}
