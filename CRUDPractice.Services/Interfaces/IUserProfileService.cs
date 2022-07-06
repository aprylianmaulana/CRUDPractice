using CRUDPractice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPractice.Services.Interfaces
{
    public interface IUserProfileService
    {
        Task<IEnumerable<UserProfileData>> GetAllUserProfileData();
        Task<UserProfileData> GetUserProfileDataById(int id);
    }
}
