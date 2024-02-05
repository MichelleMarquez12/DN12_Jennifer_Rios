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
        List<Member> GetMembers();

        int AddMember(Member member);

        void DeleteMember(int memberId);

        Member GetMember(int memberId);

        void EditMember(Member member);
    }
}
