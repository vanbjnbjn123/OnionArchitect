using System;
using Microsoft.EntityFrameworkCore;
using Onion.Domain;
using Onion.Domain.Entities;
using Onion.Domain.EntityConfigurations;
using Onion.Domain.PasswordHelper;

namespace Onion.Respository
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(InitialUser);
        }

        private static User InitialUser()
        {
            User item = new User
            {
                Id = "dsdsadsa",
                UserName = "admin",
                PasswordHash = "123456",
                Email = "admin@abccorp.xyz",
                ActivatedDate = DateTime.Today,
                UserInfomation = new UserInfomation
                {
                    Id = Guid.NewGuid().ToString(),
                   FirstName = "Nguyen",
                   LastName = "Minh Tri",
                   Address = "123 duong 123",
                   PhoneNumber = "123456789"
                }

            };
            PasswordHelper.HashPassword(ref item);
            return item;
        }
    }
	public class OnionDBContext : DbContext
	{
        DbSet<User> users { set; get; }
        DbSet<UserInfomation> userInfomations { set; get; }
		public OnionDBContext(DbContextOptions<OnionDBContext> options) : base(options)
		{
            
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<UserInfomation>(new UserInfomationConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }

    
}

