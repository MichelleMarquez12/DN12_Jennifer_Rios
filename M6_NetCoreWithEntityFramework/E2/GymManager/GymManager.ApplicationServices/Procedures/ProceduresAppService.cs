using GymManager.ApplicationServices.Procedures;
using GymManager.Core.Members;
using GymManager.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Member
{
    public class ProceduresAppService : IProceduresAppService
    {
        private readonly GymManagerContext _managercontext;
        public ProceduresAppService(GymManagerContext managerContext) 
        { 
            _managercontext = managerContext;
        }


        public async Task<List<Members>> GetMembersAsync()
        {
            try
            {
                return await _managercontext.Members.FromSqlRaw("CALL GetAllMembers").ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los miembros");
            }
        }

        public async Task<List<Products>> GetProductsAsync(string ProductType)
        {
            try
            {
                return await _managercontext.Products.FromSqlRaw("CALL ListProducts({0})", ProductType).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los productos", ex);
            }
        }

        public async Task<int> SalesAsync(DateTime fecha, int cantidad, int idMiembro, int idProducto)
        {
            // Crea un nuevo objeto Sale con los parámetros proporcionados
            var sale = new Sales
            {
                Date = fecha,
                Cantidad = cantidad,
                Members_Id = idMiembro,
                Products_Id = idProducto
            };

            // Agrega el objeto Sale al DbSet Sales
            _managercontext.Sales.Add(sale);

            // Guarda los cambios en la base de datos
            await _managercontext.SaveChangesAsync();

            // Devuelve el valor del ID que se le asigno a la venta
            return sale.Id; 
        }
    }
}
