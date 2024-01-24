using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Onion.Domain.Entities;
using Onion.Domain.Models;

namespace Onion.Domain
{
	public class User : IdentityUser
	{
		[PersonalData]
		public string SaltValue { set; get; }
		[PersonalData]
		public DateTime ActivatedDate { set; get; }
		[PersonalData]
		public DateTime? ExpiratedDate { set; get; }
		[PersonalData]
		public UserInfomation? UserInfomation { set; get; }
    }
}

