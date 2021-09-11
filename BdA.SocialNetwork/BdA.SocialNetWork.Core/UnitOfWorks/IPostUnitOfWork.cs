using BdA.SocialNetWork.Core.Contexts;
using BdA.SocialNetWork.Core.Repositories;
using BdA.SocialNetWork.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.UnitOfWorks
{
    public interface IPostUnitOfWork : IUnitOfWork<SocialContext>
    {
        IPostRepository PostRepository { get; set; }
    }
}
