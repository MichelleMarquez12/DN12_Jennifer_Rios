using GymManager.Accounts.Dto;
using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public interface IMembersAppService
    {
        //firma de metodo que devuelve el listado de los miembros
        Task<List<MemberDto>> GetMembersAsync();

        Task<int> AddMemberAsync(MemberDto member);

        Task DeleteMemberAsync(int memberId);

        Task<MemberDto> GetMemberAsync(int memberId);

        Task EditMemberAsync(MemberDto member);
        Task<MemberDto> GetMemberByIdAsync(int id);
    }
}
