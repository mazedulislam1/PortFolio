using BdA.SocialNetWork.Core.Contexts;
using BdA.SocialNetWork.Core.Entities;
using BdA.SocialNetWork.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BdA.SocialNetwork.Web.Models
{
    public class SocialUserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public UserStatus Status { get; set; }

        public ICollection<Post> Posts { get; set; }
        public Profile Profile { get; set; }


    }
}
