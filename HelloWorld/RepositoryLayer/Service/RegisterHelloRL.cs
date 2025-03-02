using System;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using Microsoft.Extensions.Logging;
namespace RepositoryLayer.Service
{
	public class RegisterHelloRL: IRegistrationHelloRL
    {
        private readonly string username="root";
        private readonly string password="root";
        private readonly ILogger<RegisterHelloRL> _logger;
		public RegisterHelloRL(ILogger<RegisterHelloRL> logger)
		{
            _logger = logger;
            _logger.LogInformation("Repository layer initialized.");
        }
        public string GetHello(string name)
        {
            _logger.LogInformation("GetHello method called with name: {Name}", name);
            try
            {
                string result = $"{name} Hello from repository layer.";
                _logger.LogInformation("GetHello executed successfully with result: {Result}", result);
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in GetHello method.");
                throw;
            }

        }
        public LoginDTO GetUsernamePassword(LoginDTO loginDTO)
        {
            _logger.LogDebug("Entering GetUsernamePassword method with username: {Username}", loginDTO.Username);
            try
            {
                loginDTO.Username = username;
                loginDTO.Password = password;
                _logger.LogInformation("GetUsernamePassword method executed successfully for username: {Username}", loginDTO.Username);
                return loginDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in GetUsernamePassword method.");
                throw;
            }
        }
    }
}

