using Onion.API.DTOs;
namespace Onion.API.InterfaceServices;

public interface IUserService
{
    public void Register(UserDTO user);
}
