using BdA.SocialNetwork.Data;
using BdA.SocialNetWork.Core.Contexts;
using BdA.SocialNetWork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        private ISocialContext _socialContext;

        public PostRepository(ISocialContext socialContext)
            :base((SocialContext)socialContext)
        {
            _socialContext = socialContext;
        }
    }
}
