using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDPractice.Domain.Models
{
    public class UserProfileData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
