using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItens = _repository.GetAppCommands();
            return Ok(commandItens);
        }
        //GET api/commands/id
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetcommandById(id);
            return Ok(commandItem);
        }
    }
}