using System;
using Onion.Domain;
using Onion.Respository.Interfaces;

namespace Onion.Respository.Respositories
{
	public interface IUserResponsitory
	{

	}

    public class UserRespository : RespositoryBase<User>, IUserResponsitory
    {
        public UserRespository(OnionDBContext dbContext) : base(dbContext)
        {
        }
    }
}

