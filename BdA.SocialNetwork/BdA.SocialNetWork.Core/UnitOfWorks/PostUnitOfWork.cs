using BdA.SocialNetWork.Core.Contexts;
using BdA.SocialNetWork.Core.Repositories;
using BdA.SocialNetWork.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.UnitOfWorks
{
    public class PostUnitOfWork : UnitOfWork<SocialContext> , IPostUnitOfWork
    {
        public IPostRepository PostRepository { get; set; }
        public PostUnitOfWork(string connectionString, string migrationAssemblyName)
            :base(connectionString,migrationAssemblyName)
        {
            PostRepository = new PostRepository(_context);
        }
    }
}
