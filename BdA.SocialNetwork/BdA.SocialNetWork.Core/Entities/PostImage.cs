using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Entities
{
    public class PostImage : Image
    {
        public int PostId { get; set; }
        public Post Post{ get; set; }


        public override void SetImageSize()
        {
            MinSize = 80;
            MaxSize = 250;
        }
    }
}
