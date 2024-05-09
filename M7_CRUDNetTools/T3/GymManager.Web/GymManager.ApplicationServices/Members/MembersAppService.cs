using GymManager.Core.Members;
using GymManager.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GymManager.Web.Accounts.Dto;
using Microsoft.EntityFrameworkCore;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {

        //public static List<Member> Members = new List<Member>();

        private readonly IRepository<int, MemberDto> _repository;
        private readonly IMapper _mapper;
        public MembersAppService(IRepository<int, MemberDto> repository, IMapper mapper) 
        { 
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> AddMemberAsync(MemberDto member)
        {
            var p = _mapper.Map<MemberDto>(member);
            await _repository.AddAsync(p);
            return member.Id;
        }

        public async Task DeleteMemberAsync(int memberId)
        {
            await _repository.DeleteAsync(memberId);
        }

        public async Task EditMemberAsync(MemberDto member)
        {
            var p = _mapper.Map<MemberDto>(member);
            await _repository.UpdateAsync(p);
        }

        public async Task<MemberDto> GetMemberAsync(int memberId)
        {
            return _mapper.Map<MemberDto>(await _repository.GetAsync(memberId));
        }

        public async Task<MemberDto> GetMemberByIdAsync(int id)
        {
            var member = await _repository.GetAsync(id);    

            MemberDto dto = _mapper.Map<MemberDto>(member);

            return dto;
        }

        public async Task<List<MemberDto>> GetMembersAsync()
        {
            var u = await _repository.GetAll().ToListAsync();

            List<MemberDto> members = _mapper.Map<List<MemberDto>>(u);

            //foreach (var member in u)
            //{
            //    members.Add(new MemberDto
            //    {
            //        FechaRegistro = member.FechaRegistro,
            //        Id = member.Id,
            //        Name = member.Name,
            //        LastName = member.LastName,
            //        Email = member.Email,
            //        Address = member.Address,
            //        Phone = member.Phone
            //    });
            //}
            return members;
        }
    }
}
