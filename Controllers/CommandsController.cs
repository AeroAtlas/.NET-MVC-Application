using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;


namespace Commander.Controllers 
{
  //api/commands
  [Route("api/commands")] //or [Route("api/[controller]")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private readonly MockCommanderRepo _repository = new MockCommanderRepo();
    //Adds Route for GET (GET api/commands)
    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();
      return Ok(commandItems);
    }
    //Adds route for GET/id (GET api/commands/{id})
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }
}