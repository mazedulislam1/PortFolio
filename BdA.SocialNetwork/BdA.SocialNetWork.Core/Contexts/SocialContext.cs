using BdA.SocialNetWork.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BdA.SocialNetWork.Core.Contexts
{
    public class SocialContext : IdentityDbContext<SocialUser>, ISocialContext
    {
        private readonly string connectionString;
        private readonly string migrationAssemblyName;

        public SocialContext(string connectionString, string migrationAssemblyName)
        {
            this.connectionString = connectionString;
            this.migrationAssemblyName = migrationAssemblyName;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString, m => m.MigrationsAssembly(migrationAssemblyName));
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SocialUser>()
               .HasMany(su => su.Posts)
               .WithOne(p => p.User)
               .HasForeignKey(p => p.UserId)
               .OnDelete(DeleteBehavior.Cascade);


            builder.Entity<SocialUser>()
                .HasOne(su => su.Profile)
                .WithOne(p => p.User)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            
            builder.Entity<Profile>()
                .HasOne(p => p.ProfileImage)
                .WithOne(Pi => Pi.Profile)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Post>()
               .HasMany(p => p.PostImages)
               .WithOne(pi => pi.Post)
               .HasForeignKey(pi => pi.PostId)
               .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts{ get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<SocialUser> SocialUsers { get; set; }
    }
}
