using System;
namespace ModelLayer.DTO
{
	public class LoginDTO
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public override string ToString()
		{
			return Username + ":" + Password;
		}
		
	}
}

