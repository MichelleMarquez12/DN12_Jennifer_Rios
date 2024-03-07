using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public interface IQueriesExample
    {
        //metodo que devuelve las marcas de vehiculos
        List<Make> GetMakes();

        //metodo que devuelve el inventario de vehiculos que tengan determinado precio
        List<Vehicle> GetVehiclesByPrice(decimal from, decimal to);
    }
}
