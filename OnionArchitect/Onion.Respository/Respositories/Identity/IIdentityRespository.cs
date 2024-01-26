using System;
namespace Onion.Respository.Respositories.Identity
{
	public interface IIdentityRespository
	{
		public void Login();
		public Task<bool> Resigter();
	}
}

