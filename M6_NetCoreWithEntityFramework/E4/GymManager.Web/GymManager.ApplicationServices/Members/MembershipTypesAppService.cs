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
        private readonly IRepository<int, MembershipTypes> _repository;
        public MembershipTypesAppService(IRepository<int, MembershipTypes> repository)
        {
            _repository = repository;
        }
        public async Task<int> AddMembershipTypesAsync(MembershipTypes membershipTypes)
        {
            await _repository.AddAsync(membershipTypes);
            return membershipTypes.Id;
        }

        public async Task DeleteMembershipTypesAsync(int membershipTypesId)
        {
            await _repository.DeleteAsync(membershipTypesId);
        }

        public async Task EditMembershipTypesAsync(MembershipTypes membershipTypes)
        {
            await _repository.UpdateAsync(membershipTypes);
        }

        public async Task<MembershipTypes> GetMembershipTypesAsync(int membershipTypesId)
        {
            return await _repository.GetAsync(membershipTypesId);
        }

        public async Task<List<MembershipTypes>> GetMembershipTypesAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
    }
}
