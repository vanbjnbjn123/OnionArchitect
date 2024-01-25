using Onion.Domain.Models;

namespace Onion.Domain.Entities
{
	public class UserInfomation : EntityBase
	{
		public UserInfomation()
		{
			this.UserInfomationId = Guid.NewGuid().ToString();
		}
		public string UserInfomationId { set; get; }
		public string FirstName { set; get; }
		public string LastName { set; get; }
		public string Address { set; get; }
		public string PhoneNumber { set; get; }
		public string UserId { set; get; }
		public User User {set; get;} = null!;
	}
}

