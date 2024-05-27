using GymManager.Accounts.Dto;
using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace GymManager.Web.Models
{
    public class MembershipTypesListViewModel
    {
        public int NewMembershipTypesCount { get; set; }

        public List<MembershipTypesDto> MembershipTypess { get; set; }
    }
}
