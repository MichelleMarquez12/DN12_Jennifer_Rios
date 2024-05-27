using AutoMapper;
using GymManager.Accounts.Dto;
using GymManager.Core.Members;
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
            CreateMap<MemberDto, Member>();

            CreateMap<MembershipTypes, MembershipTypesDto>();
            CreateMap<MembershipTypesDto, MembershipTypes>();
        }
    }
}
