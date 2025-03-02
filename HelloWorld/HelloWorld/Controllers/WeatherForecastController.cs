using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Services;
using ModelLayer.DTO;
using Microsoft.Extensions.Logging;
namespace HelloWorld.Controllers;
[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    private readonly RegisterHelloBL _registerHelloBL;
    private readonly ILogger<HelloWorldController> _logger;
    public HelloWorldController(RegisterHelloBL registerHelloBL, ILogger<HelloWorldController> logger)
    {
        _registerHelloBL = registerHelloBL;
        _logger = logger;
    }
    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("Get method called");
        string result = _registerHelloBL.Registration("Value from Controller.");
        _logger.LogInformation("Get method executed successfully with result: {Result}", result);
        return result;
    }
    [HttpPost]
    public ResponseBody<LoginDTO> LoginUser([FromBody] LoginDTO loginDTO)
    {
        _logger.LogInformation("LoginUser method called with username: {Username}", loginDTO.Username);
        var response = new ResponseBody<LoginDTO>();
        try
        {
            bool result = _registerHelloBL.LoginUser(loginDTO);
            response.Success = result;
            response.Message = result ? "Data Received Successfully" : "Data Not Saved";
            response.Data = result ? loginDTO : new LoginDTO();
            _logger.LogInformation("LoginUser method executed successfully. Success: {Success}", result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in LoginUser method with username: {Username}", loginDTO.Username);
            response.Success = false;
            response.Message = "An error occurred while processing the request.";
            response.Data = new LoginDTO();
        }
        return response;
    }
    [HttpGet]
    [Route("Second")]
    public string Get2()
    {
        _logger.LogInformation("Get2 method called");
        return "Second";
    }
    [HttpGet("error")]
    public IActionResult SimulateError()
    {
        _logger.LogError("An error occurred in HelloWorldController.");
        return BadRequest("Something went wrong.");
    }
}