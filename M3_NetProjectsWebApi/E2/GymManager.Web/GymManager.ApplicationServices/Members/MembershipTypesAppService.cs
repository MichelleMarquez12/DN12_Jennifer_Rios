using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembershipTypesAppService : IMembershipTypesAppService
    {
        public static List<MembershipTypes> MembershipTypes = new List<MembershipTypes>();
        public int AddMembershipTypes(MembershipTypes membershipTypes)
        {
            membershipTypes.Id = new Random().Next();
            MembershipTypes.Add(membershipTypes);
            return membershipTypes.Id;
        }

        public void DeleteMembershipTypes(int membershipTypesId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypesId).FirstOrDefault();
            MembershipTypes.Remove(m);
        }

        public void EditMembershipTypes(MembershipTypes membershipTypes)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypes.Id).FirstOrDefault();
            m.Name = membershipTypes.Name;
            m.LastName = membershipTypes.LastName;
            m.Cost = membershipTypes.Cost;
            m.CreatedOn = membershipTypes.CreatedOn;
            m.Duration = membershipTypes.Duration;
        }

        public List<MembershipTypes> GetMembershipTypes()
        {
            return MembershipTypes;
        }

        public MembershipTypes GetMembershipTypes(int membershipTypesId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypesId).FirstOrDefault();
            return m;
        }
    }
}
