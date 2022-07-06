using CRUDPractice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPractice.DataAccess.Dapper.Interfaces
{
    public interface IUserProfileRepository
    {
        Task<IEnumerable<UserProfileData>> GetAllUserProfileData();
        Task<UserProfileData> GetUserProfileDataById(int id);
    }
}
