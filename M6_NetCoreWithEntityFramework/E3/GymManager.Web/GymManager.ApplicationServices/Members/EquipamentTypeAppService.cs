using GymManager.Core.Members;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class EquipamentTypeAppService : IEquipamentTypeAppService
    {
        private readonly IRepository<int, EquipamentType> _repository;
        public EquipamentTypeAppService(IRepository<int, EquipamentType> repository) 
        {
            _repository = repository;
        }

        public async Task<int> AddEquipamentTypeAsync(EquipamentType equipamentType)
        {
            await _repository.AddAsync(equipamentType);
            return equipamentType.Id;
        }

        public async Task DeleteEquipamentTypeAsync(int equipamentTypeId)
        {
            await _repository.DeleteAsync(equipamentTypeId);
        }

        public async Task EditEquipamentTypeAsync(EquipamentType equipamentType)
        {
            await _repository.UpdateAsync(equipamentType);
        }

        public async Task<EquipamentType> GetEquipamentTypeAsync(int equipamentTypeId)
        {
            return await _repository.GetAsync(equipamentTypeId);
        }

        public async Task<List<EquipamentType>> GetEquipamentTypesAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
    }
}
