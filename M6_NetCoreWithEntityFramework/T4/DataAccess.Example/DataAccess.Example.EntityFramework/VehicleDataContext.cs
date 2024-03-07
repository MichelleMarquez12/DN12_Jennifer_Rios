﻿using DataAccess.Example.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class VehicleDataContext : DbContext
    {
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Incentive> Incentives { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public VehicleDataContext(DbContextOptions<VehicleDataContext> options) : base(options)
        {

        }


        //define que la entidad VehicleIncentive tiene llave con un tipo de dato anonios, asi como las propiedades que lo relacionan
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleIncentive>().HasKey(vi => new {vi.IncentiveId, vi.VehicleId});
        }
    }
}
