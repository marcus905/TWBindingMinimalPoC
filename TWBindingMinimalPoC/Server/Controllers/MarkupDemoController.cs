using Microsoft.AspNetCore.Mvc;
using TWBindingMinimalPoC.Shared;

namespace TWBindingMinimalPoC.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarkupDemoController : ControllerBase
    {

        private readonly ILogger<MarkupDemoController> _logger;

        public MarkupDemoController(ILogger<MarkupDemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get([FromQuery] DemoDTO demoDTO)
        {
            return 
                $"<demo-input @bind={demoDTO.VarName} /> \n" +
                $"<demo-method @onchange={demoDTO.MethodName} /> \n" +
                $"<button @onclick={demoDTO.MethodName} />";
        }
    }
}