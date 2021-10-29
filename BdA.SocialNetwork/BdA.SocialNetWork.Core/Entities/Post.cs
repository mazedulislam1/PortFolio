using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public IList<PostImage> PostImages{ get; set; }

        public string UserId { get; set; }
        public SocialUser User { get; set; }

        public Post()
        {
            PostImages = new List<PostImage>();
        }
    }
}
