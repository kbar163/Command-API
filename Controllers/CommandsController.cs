using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers;

[Route("api/commands")]
[ApiController]
public class CommandsController : ControllerBase
{
    private readonly ICommandRepo _repository;

    public CommandsController(ICommandRepo repository)
    {
        _repository = repository;
    }

    //GET api/commands/
    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
        var commandItems = _repository.GetAllCommands();
        return Ok(commandItems);
    }

    //GET api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int id)
    {
        var commandItem = _repository.GetCommandById(id);
        return Ok(commandItem);
    }
}