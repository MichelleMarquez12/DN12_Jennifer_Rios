using AutoMapper;
using AutoMapper.Execution;
using GymManager.Accounts.Dto;
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
        private readonly IRepository<int, EquipamentTypeDto> _repository;
        private readonly IMapper _mapper;
        public EquipamentTypeAppService(IRepository<int, EquipamentTypeDto> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> AddEquipamentTypeAsync(EquipamentTypeDto equipamentType)
        {
            var p = _mapper.Map<EquipamentTypeDto>(equipamentType);
            await _repository.AddAsync(p);
            return equipamentType.Id;
        }

        public async Task DeleteEquipamentTypeAsync(int equipamentTypeId)
        {
            await _repository.DeleteAsync(equipamentTypeId);
        }

        public async Task EditEquipamentTypeAsync(EquipamentTypeDto equipamentType)
        {
            var p = _mapper.Map<EquipamentTypeDto>(equipamentType);
            await _repository.UpdateAsync(p);
        }

        public async Task<EquipamentTypeDto> GetEquipamentTypeAsync(int equipamentTypeId)
        {
            return _mapper.Map<EquipamentTypeDto>(await _repository.GetAsync(equipamentTypeId));
        }

        public async Task<List<EquipamentTypeDto>> GetEquipamentTypesAsync()
        {
            var u = await _repository.GetAll().ToListAsync();

            List<EquipamentTypeDto> equipamentType = _mapper.Map<List<EquipamentTypeDto>>(u);

            return equipamentType;
        }
    }
}
