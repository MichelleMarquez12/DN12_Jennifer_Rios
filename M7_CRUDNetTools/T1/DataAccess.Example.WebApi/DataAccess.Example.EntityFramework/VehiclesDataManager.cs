using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class VehiclesDataManager : IVehiclesDataManager
    {
        private readonly VehiclesDataContext _dataContext;

        public VehiclesDataManager(VehiclesDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Delete(int Id)
        {
            //var entity = _dataContext.Vehicles.Find(Id);
            //_dataContext.Vehicles.Remove(entity);
            //_dataContext.SaveChanges();
        }

        public Vehicle Get(int Id)
        {
            throw new NotImplementedException();
        }

        //como no esta implementado el metodo marca el error
        public IList<Vehicle> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void Update(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
