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
        Task<List<MembershipTypes>> GetMembershipTypesAsync();

        Task<int> AddMembershipTypesAsync(MembershipTypes membershipTypes);

        Task DeleteMembershipTypesAsync(int membershipTypesId);

        Task<MembershipTypes> GetMembershipTypesAsync(int membershipTypesId);

        Task EditMembershipTypesAsync(MembershipTypes membershipTypes);
    }
}
