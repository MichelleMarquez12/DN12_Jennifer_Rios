using AutoMapper;
using GymManager.Core.Members;
using GymManager.Web.Accounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Member, MemberDto>();
            CreateMap<Profilee, ProfileDto>();
            CreateMap<MemberDto, Member>();
        }
    }
}
