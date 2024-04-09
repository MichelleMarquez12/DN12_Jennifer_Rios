using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Procedures
{
    public interface IProceduresAppService
    {
        Task<List<Members>> GetMembersAsync();

        Task<List<Products>> GetProductsAsync(string ProductType);

        Task<int> SalesAsync(DateTime Date, int Cantidad, int Members_idMembers, int Products_idProducts);
    }
}
