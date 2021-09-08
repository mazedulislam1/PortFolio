using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Entities
{
    public class ProfileImage : Image
    {
        public int ProfileId { get; set; }
        public Profile Profile{ get; set; }

        public override void SetImageSize()
        {
            MinSize = 100;
            MaxSize = 200;
        }
    }
}
