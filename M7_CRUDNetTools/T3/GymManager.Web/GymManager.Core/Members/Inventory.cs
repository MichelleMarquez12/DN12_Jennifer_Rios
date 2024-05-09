using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.Members
{
    public class Inventory
    {
        public int CantidadProduct { get; set; }
        public int CantidadEquipament { get; set; }
        public int ProductTypes_Id { get; set; }
        public int EquipamentType_Id { get; set; }
    }
}
