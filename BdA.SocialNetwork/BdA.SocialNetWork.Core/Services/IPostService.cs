using BdA.SocialNetWork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Services
{
    public interface IPostService
    {
        void AddPost(Post post);
        void DeletePost(Post post);
        void UpdatePost(Post post);
        Post GetById(int id);
        IEnumerable<Post> GetAll();
    }
}
