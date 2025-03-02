using System;
using RepositoryLayer.Interface;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using Microsoft.Extensions.Logging;
namespace BusinessLayer.Services
{
	public class RegisterHelloBL: IRegisterHelloBL
    {
		private readonly IRegistrationHelloRL _registerHelloRL;
		private readonly ILogger<RegisterHelloBL> _logger;

        public RegisterHelloBL(IRegistrationHelloRL registerHelloRL,ILogger<RegisterHelloBL> logger)
		{
			_registerHelloRL = registerHelloRL;
            _logger = logger;
        }
		public string Registration(string name)
		{
			_logger.LogInformation("Registration method called with name: {Name}", name);
            string result = "This is business layer data = " + _registerHelloRL.GetHello(name);
            _logger.LogInformation("Recieved response from repository layer succesfully with result: {Result}", result);
            return result;
        }
		public bool LoginUser(LoginDTO loginDTO)
		{
            _logger.LogInformation("LoginUser method called with username: {Username}", loginDTO.Username);
            string frontendUsername = loginDTO.Username;
			string frontendPassword = loginDTO.Password;
			LoginDTO databasedata = _registerHelloRL.GetUsernamePassword(loginDTO);
            if (databasedata == null)
            {
                _logger.LogWarning("No user found in database for username: {Username}", frontendUsername);
                return false;
            }
            bool isAuthenticated = CheckUsernamePassword(frontendUsername, frontendPassword, databasedata);
            if (isAuthenticated)
                _logger.LogInformation("Login successful for username: {Username}", frontendUsername);
            else
                _logger.LogWarning("Login failed for username: {Username}", frontendUsername);
            return isAuthenticated;
        }
		public bool CheckUsernamePassword(string frontendUsername, string frontendPassword,LoginDTO result)
		{
            _logger.LogDebug("Checking credentials for username: {Username}", frontendUsername);
            if (frontendUsername.Equals(result.Username) && frontendPassword.Equals(result.Password))
            {
                _logger.LogInformation("User authenticated successfully: {Username}", frontendUsername);
                return true;
            }
            _logger.LogWarning("Invalid credentials for username: {Username}", frontendUsername);
            return false;
        }
	}
}