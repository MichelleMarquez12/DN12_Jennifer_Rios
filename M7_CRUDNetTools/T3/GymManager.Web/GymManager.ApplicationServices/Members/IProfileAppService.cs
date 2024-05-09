using GymManager.Core.Members;
using GymManager.Web.Accounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public interface IProfileAppService
    {
        Task<List<ProfileDto>> GetProfilesAsync();

        Task<int> AddProfileAsync(ProfileDto profile);

        Task DeleteProfileAsync(int profileId);

        Task<ProfileDto> GetProfilesAsync(int profileId);

        Task EditProfileAsync(ProfileDto profile);
    }
}
