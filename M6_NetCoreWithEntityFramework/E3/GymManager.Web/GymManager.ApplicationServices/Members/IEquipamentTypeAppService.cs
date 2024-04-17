using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public interface IEquipamentTypeAppService
    {

        Task<List<EquipamentType>> GetEquipamentTypesAsync();

        Task<int> AddEquipamentTypeAsync(EquipamentType equipamentType);

        Task DeleteEquipamentTypeAsync(int equipamentTypeId);

        Task<EquipamentType> GetEquipamentTypeAsync(int equipamentTypeId);

        Task EditEquipamentTypeAsync(EquipamentType equipamentType);
    }
}
