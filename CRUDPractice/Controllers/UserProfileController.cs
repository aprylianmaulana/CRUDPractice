using CRUDPractice.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private IUserProfileService _userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [Route("GetAllUserProfile")]
        [HttpGet]
        public async Task<IActionResult> GetAllUserProfile()
        {
            var data = await _userProfileService.GetAllUserProfileData();
            return Ok(data);
        }

        [Route("GetUserById")]
        [HttpGet]
        public async Task<IActionResult> GetUserProfileById(int id)
        {
            var data = await _userProfileService.GetUserProfileDataById(id);
            return Ok(data);
        } 
    }
}
