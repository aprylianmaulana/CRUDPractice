using CRUDPractice.DataAccess.Dapper.Interfaces;
using CRUDPractice.Domain.Models;
using CRUDPractice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPractice.Services.Services
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }

        public async Task<IEnumerable<UserProfileData>> GetAllUserProfileData()
        {
            return await _userProfileRepository.GetAllUserProfileData();
        }

        public async Task<UserProfileData> GetUserProfileDataById(int id)
        {
            return await _userProfileRepository.GetUserProfileDataById(id);
        }
    }
}
