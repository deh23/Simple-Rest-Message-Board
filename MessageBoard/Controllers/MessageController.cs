using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        // GET api/<MessageController>
        [HttpGet]
        public IActionResult GetMessages()
        {
            var result = _messageRepository.GetAll();
            
            return Ok(result);
        }

        // POST api/<MessageController>
        [HttpPost]
        public IActionResult AddMessage([FromBody] MessageRequest request)
        {
            if(request == null ||string.IsNullOrEmpty(request.Message))
            {
                return BadRequest("Request is invalid.");
            }

            _messageRepository.Add(request.Message);

            return Ok();
        }
    }
}
