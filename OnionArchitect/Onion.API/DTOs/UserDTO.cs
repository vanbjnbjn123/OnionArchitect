namespace Onion.API.DTOs;

public class UserDTO
{
    public virtual string UserName {set; get;}
    public virtual string Password {set; get;}
    public virtual string Email {set; get;}
    public virtual string FirstName { set; get; }
	public virtual string LastName { set; get; }
	public virtual string Address { set; get; }
	public virtual string PhoneNumber { set; get; }

}
