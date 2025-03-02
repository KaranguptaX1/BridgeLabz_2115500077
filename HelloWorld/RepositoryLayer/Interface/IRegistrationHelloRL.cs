using System;
using ModelLayer.DTO;
namespace RepositoryLayer.Interface
{
	public interface IRegistrationHelloRL
	{

		string GetHello(string name);
		LoginDTO GetUsernamePassword(LoginDTO loginDTO);
	}
}

