using GymManager.Accounts.Dto;
using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public interface IMembershipTypesAppService
    {
        Task<List<MembershipTypesDto>> GetMembershipTypesAsync();

        Task<int> AddMembershipTypesAsync(MembershipTypesDto membershipTypes);

        Task DeleteMembershipTypesAsync(int membershipTypesId);

        Task<MembershipTypesDto> GetMembershipTypesAsync(int membershipTypesId);

        Task EditMembershipTypesAsync(MembershipTypesDto membershipTypes);
    }
}
