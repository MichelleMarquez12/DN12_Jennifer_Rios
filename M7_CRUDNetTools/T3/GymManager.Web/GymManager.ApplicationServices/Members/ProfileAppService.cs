using GymManager.Core.Members;
using GymManager.DataAccess.Repositories;
using GymManager.Web.Accounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.Execution;

namespace GymManager.ApplicationServices.Members
{
    public class ProfileAppService : IProfileAppService
    {
        private readonly IRepository<int, Profilee> _repository;
        private readonly IMapper _mapper;
        public ProfileAppService(IRepository<int, Profilee> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<int> AddProfileAsync(ProfileDto profile)
        {
            var p = _mapper.Map<Profilee>(profile);
            await _repository.AddAsync(p);

            return profile.Id;
        }

        public async Task DeleteProfileAsync(int profileId)
        {
            await _repository.DeleteAsync(profileId);
        }

        public async Task EditProfileAsync(ProfileDto profile)
        {
            var p = _mapper.Map<Profilee>(profile);
            await _repository.UpdateAsync(p);
        }

        public async Task<List<ProfileDto>> GetProfilesAsync()
        {
            var members = _mapper.Map<List<ProfileDto>>(await _repository.GetAll().ToListAsync());


            return members;
        }

        public async Task<ProfileDto> GetProfilesAsync(int profileId)
        {
            return _mapper.Map<ProfileDto>( await _repository.GetAsync(profileId));
        }
    }
}
