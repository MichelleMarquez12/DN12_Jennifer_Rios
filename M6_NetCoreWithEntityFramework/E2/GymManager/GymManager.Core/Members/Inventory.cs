using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Inventory
    {
       // public int Id { get; set; }
        public int CantidadProduct { get; set; }
        public int CantidadEquipament { get; set; }
        public int EquipamentType_Id { get; set; }
        public int Products_Id { get; set; }
    }
}
