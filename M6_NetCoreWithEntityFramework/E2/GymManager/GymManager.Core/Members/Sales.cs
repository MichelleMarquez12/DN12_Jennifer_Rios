using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Cantidad { get; set; }
        public int Members_Id { get; set; }
        public int Products_Id { get; set; }

    }
}
