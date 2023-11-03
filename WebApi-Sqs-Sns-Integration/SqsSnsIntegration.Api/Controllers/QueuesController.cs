using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SqsSnsIntegration.Api.Models;
using SqsSnsIntegration.Api.Services;

namespace SqsSnsIntegration.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuesController : ControllerBase
    {

        private readonly ISqsService _qsService;

        public QueuesController(ISqsService qsService)
        {
            _qsService = qsService;
        }


        [HttpPost]
        public async Task<IActionResult> SendMessage(NotificationRequest request)
        {
            return Ok(await _qsService.SendMessageToSqsQueue(request));
        }
    }
}
