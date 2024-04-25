using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class StaffAttendance
    {
        [Key]
        public int Id { get; set; }
        public int Members_Id { get; set; }
        [ForeignKey("Members_Id")]
        public Member Member { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public int Count { get; set; }
    }
}
