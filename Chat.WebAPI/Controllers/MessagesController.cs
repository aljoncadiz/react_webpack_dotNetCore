using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

using Chat.Model;

namespace Chat.WebAPI.Controllers
{
    [Route("api/messages")]
    public class MessagesController : Controller
    {
        private List<ChatMessage> messages = 
            new List<ChatMessage>()
            {
                new ChatMessage
                {
                    AuthorTwitterHandle = "Pusher",
                    Text = "Hi There!"
                },
                new ChatMessage
                {
                    AuthorTwitterHandle = "Pusher",
                    Text = "Welcome to chat app!"
                },
            };       

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(messages);
        } 

        [HttpPost]
        public IActionResult Post(ChatMessage message)
        {
            if(message == null && !ModelState.IsValid)
            {
                return BadRequest("Invalid Request");
            }
            else
            {
                messages.Add(message);
                return Ok(true);
            }
        }
    }
}
