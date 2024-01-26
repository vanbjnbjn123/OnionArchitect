using System;
using Onion.Service.Models.DTOs;

namespace Onion.Service.Interfaces
{
	public interface IIdentityService
	{
        public void Register(UserDTO user);
        public void Login(UserLoginDTO userLogin);
    }
}

