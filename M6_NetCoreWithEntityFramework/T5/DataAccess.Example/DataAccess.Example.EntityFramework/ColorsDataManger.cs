using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class ColorsDataManger : IColorsDataManager
    {
        private readonly VehicleDataContext _dataContext;
        public ColorsDataManger(VehicleDataContext dataContext) 
        {
            _dataContext = dataContext;
        }
        public void Insert(Color color)
        {
            _dataContext.Colors.Add(color);
            _dataContext.SaveChanges();
        }

        public void Update(Color color)
        {
            var entity = _dataContext.Colors.Find(color.Id);

            entity.Name = color.Name;
            entity.Code = color.Code;

            _dataContext.SaveChanges();
        }

        public Color Get(int id)
        {
            var entity = _dataContext.Colors.Find(id);
            return entity;
        }

        public IList<Color> GetAll()
        {
            var result = _dataContext.Colors.ToList();
            return result;
        }

        public void Delete(int id)
        {
            var entity = _dataContext.Colors.Find(id);
            _dataContext.Colors.Remove(entity);

            _dataContext.SaveChanges();
        }
    }
}
