using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Domain.EntityConfigurations
{
	public class UserInfomationConfiguration : IEntityTypeConfiguration<UserInfomation>
    {
		public UserInfomationConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<UserInfomation> builder)
        {
        }
    }
}

