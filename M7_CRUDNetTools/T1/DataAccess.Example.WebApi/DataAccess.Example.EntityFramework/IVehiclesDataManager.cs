﻿using DataAccess.Example.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public interface IVehiclesDataManager
    {
        void Insert(Vehicle vehicle);

        void Update(Vehicle vehicle);

        Vehicle Get(int Id);

        IList<Vehicle> GetAll();

        void Delete(int Id);
    }
}
