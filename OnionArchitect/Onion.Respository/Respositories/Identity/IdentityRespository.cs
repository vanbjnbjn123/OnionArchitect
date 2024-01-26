using System;
using Microsoft.AspNetCore.Identity;
using Onion.Domain;

namespace Onion.Respository.Respositories.Identity
{
	public class IdentityRespository : IIdentityRespository
    {
        private readonly UserManager<User> _userManager;
        public IdentityRespository(UserManager<User> userManager)
		{
            _userManager = userManager;
		}

        public void Login()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Resigter(User user)
        {
            try
            {
                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    return true;
                }
                else
                {
                    throw new Exception(result.Errors.First().Description);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}

