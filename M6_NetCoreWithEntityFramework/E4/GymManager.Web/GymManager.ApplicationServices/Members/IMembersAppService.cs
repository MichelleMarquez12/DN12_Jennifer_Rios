﻿using GymManager.Core.Members;
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
        Task<List<Member>> GetMembersAsync();

        Task<int> AddMemberAsync(Member member);

        Task DeleteMemberAsync(int memberId);

        Task<Member> GetMemberAsync(int memberId);

        Task EditMemberAsync(Member member);
        Task<Member> GetMemberByIdAsync(int id);
    }
}
