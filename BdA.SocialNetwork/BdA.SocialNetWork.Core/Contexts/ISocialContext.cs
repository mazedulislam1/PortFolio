using BdA.SocialNetWork.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Contexts
{
    public interface ISocialContext
    {
        DbSet<SocialUser> SocialUsers { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Profile> Profiles { get; set; }
    }
}
