using Onion.Domain;
using Onion.Domain.Entities;
namespace Onion.Service;

public class UserLoginRespose
{
    public virtual UserInfomation UserInfomation {set; get;}
    public virtual string AccessToken {set; get;}
    public virtual string RefreshToken {set; get;}
}
