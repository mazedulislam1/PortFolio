using BdA.SocialNetWork.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Entities
{
    public class SocialUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Password{ get; set; }
        public Gender Gender { get; set; }
        public UserStatus Status { get; set; }

        public ICollection<Post> Posts { get; set; }
        public Profile Profile { get; set; }

        public string GetFullName()
        {
            return FirstName + LastName;
        }
    }
}
