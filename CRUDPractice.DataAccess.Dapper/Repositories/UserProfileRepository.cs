using CRUDPractice.DataAccess.Dapper.Interfaces;
using CRUDPractice.Domain.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPractice.DataAccess.Dapper.Repositories
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly IConfiguration _config;
        public UserProfileRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        //create IDbConnection
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DatabaseConnection"));
            }
        }

        public async Task<IEnumerable<UserProfileData>> GetAllUserProfileData()
        {
            try
            {
                using(IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var sql = $"Select * from UserProfile";
                    var result = await dbConnection.QueryAsync<UserProfileData>(sql);
                    return result;
                }
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<UserProfileData> GetUserProfileDataById(int id)
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    var sql = $"exec GetUserProfileByID @id = {id}";
                    var result = await dbConnection.QueryFirstOrDefaultAsync<UserProfileData>(sql);
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
