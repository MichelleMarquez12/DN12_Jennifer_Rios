using GymManager.Web.Accounts.Dto;

namespace GymManager.Web.Models
{
    public class MemberListViewModel
    {
        public int NewMembersCount { get; set; }

        public List<MemberDto> Members { get; set; }
    }
}
