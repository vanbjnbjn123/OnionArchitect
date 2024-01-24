using System;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using Onion.Domain.Entities;
using Onion.Domain.PasswordHelper;

namespace Onion.Domain.EntityConfigurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
    {
		public UserConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(t => t.UserInfomation)
            .WithOne(t => t.User)
            .HasForeignKey<UserInfomation>(t => t.UserId)
            .IsRequired();
            builder.Property(t => t.SaltValue).HasColumnType<string>("varchar").HasMaxLength(256);
            
        }

        
    }
}

