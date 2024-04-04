using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GymManager.Web.Models
{
    public class MembershipTypesListViewModel
    {
        public int NewMembershipTypesCount { get; set; }

        public List<MembershipTypes> MembershipTypess { get; set; }
    }
}
