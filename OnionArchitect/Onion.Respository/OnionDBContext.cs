using System;
using Microsoft.EntityFrameworkCore;
using Onion.Domain;
using Onion.Domain.Entities;
using Onion.Domain.EntityConfigurations;
using Onion.Domain.PasswordHelper;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Onion.Respository
{
	public class OnionDBContext : IdentityDbContext<User>
	{
        DbSet<User> users { set; get; }
        DbSet<UserInfomation> userInfomations { set; get; }
        DbSet<IdentityUserLogin<string>> userLogins {set; get;}
		public OnionDBContext(DbContextOptions<OnionDBContext> options) : base(options)
		{
            
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<UserInfomation>(new UserInfomationConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }

    
}

