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
    public class MembershipTypesAppService : IMembershipTypesAppService
    {
        private readonly IRepository<int, MembershipTypesDto> _repository;
        private readonly IMapper _mapper;
        public MembershipTypesAppService(IRepository<int, MembershipTypesDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<int> AddMembershipTypesAsync(MembershipTypesDto membershipTypes)
        {
            var p = _mapper.Map<MembershipTypesDto>(membershipTypes);
            await _repository.AddAsync(p);
            return membershipTypes.Id;
        }

        public async Task DeleteMembershipTypesAsync(int membershipTypesId)
        {
            await _repository.DeleteAsync(membershipTypesId);
        }

        public async Task EditMembershipTypesAsync(MembershipTypesDto membershipTypes)
        {
            var p = _mapper.Map<MembershipTypesDto>(membershipTypes);
            await _repository.UpdateAsync(p);
        }

        public async Task<MembershipTypesDto> GetMembershipTypesAsync(int membershipTypesId)
        {
            return _mapper.Map<MembershipTypesDto>(await _repository.GetAsync(membershipTypesId));
        }

        public async Task<List<MembershipTypesDto>> GetMembershipTypesAsync()
        {
            var u = await _repository.GetAll().ToListAsync();

            List<MembershipTypesDto> membershipTypes = _mapper.Map<List<MembershipTypesDto>>(u);

            return membershipTypes;
        }
    }
}
