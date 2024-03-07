using DataAccess.Example.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class QueriesExample : IQueriesExample
    {

        private readonly VehicleDataContext _dataContext;
        public QueriesExample(VehicleDataContext dataContext) 
        { 
            _dataContext = dataContext;
        }
        public List<Make> GetMakes()
        {
            //las tablas se muestran como propiedades y se pueden usar como listas atraves de linq con toList
            //List<Make> makes = _dataContext.Makes.ToList();

            //consulta por marca ordenado por pais
            List<Make> makes = _dataContext.Makes.Include(x => x.Vehicles).OrderBy(x => x.Country).ToList();
            return makes;
        }

        public List<Vehicle> GetVehiclesByPrice(decimal _from, decimal to)
        {
            //consulta de vehiculos con determinado precio
            //List<Vehicle> vehicles = _dataContext.Inventories.Where(x => x.Price >= from && x.Price <= to).Select(x => x.Vehicle).ToList();
            //return vehicles;

            //consulta de vehiculos con determinado precio con Linq
            var vehicles = (from i in _dataContext.Inventories join v in _dataContext.Vehicles on i.Vehicle.Id
                           equals v.Id 
                           where i.Price >= _from && i.Price <= to select v).ToList();

            return vehicles;
        }
    }
}
