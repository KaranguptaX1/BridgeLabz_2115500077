using System;
using RepositoryLayer.Interface;
using ModelLayer.DTO;
namespace BusinessLayer.Interface
{
	public interface IRegisterHelloBL
	{
		string Registration(string name);
		bool LoginUser(LoginDTO loginDTO);
		bool CheckUsernamePassword(string frontendUsername, string frontendPassword, LoginDTO result);
	}
}

