using GymManager.Accounts.Dto;
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

        Task<List<EquipamentTypeDto>> GetEquipamentTypesAsync();

        Task<int> AddEquipamentTypeAsync(EquipamentTypeDto equipamentType);

        Task DeleteEquipamentTypeAsync(int equipamentTypeId);

        Task<EquipamentTypeDto> GetEquipamentTypeAsync(int equipamentTypeId);

        Task EditEquipamentTypeAsync(EquipamentTypeDto equipamentType);
    }
}
