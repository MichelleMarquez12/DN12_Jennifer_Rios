using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Sales
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Cantidad { get; set; }
        public int ProductTypes_Id { get; set;}
        public int Users_Id { get; set; }

    }
}
