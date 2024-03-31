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
        List<MembershipTypes> GetMembershipTypes();

        int AddMembershipTypes(MembershipTypes membershipTypes);

        void DeleteMembershipTypes(int membershipTypesId);

        MembershipTypes GetMembershipTypes(int membershipTypesId);

        void EditMembershipTypes(MembershipTypes membershipTypes);
    }
}
