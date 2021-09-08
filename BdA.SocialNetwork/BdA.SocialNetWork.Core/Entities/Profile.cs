using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public ProfileImage ProfileImage{ get; set; }

        public string UserId { get; set; }
        public SocialUser User{ get; set; }      
    }
}
