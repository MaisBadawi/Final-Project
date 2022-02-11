using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashionista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService service;
        public MessageController(IMessageService service)
        {
            this.service = service;
        }


        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Insert_Msg([FromBody] Message msg)
        {
            return service.Insert_Msg(msg);
        }
       
        
        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Update_Msg([FromBody] Message msg)
        {
            return service.Update_Msg(msg);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<MessagesDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<MessagesDto> GET_All_Msg()
        {
            return service.Get_All_Msg();
        }

       
        
        [HttpGet("GetMsgById/{id}")]
        [ProducesResponseType(typeof(Message), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Message Get_Msg_By_Id(int id)
        {
            return service.Get_Msg_By_Id(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool Delete_Msg(int id)
        {
            return service.Delete_Msg(id);
        }

    }
}
