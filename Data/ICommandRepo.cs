using CommandAPI.Models;

namespace CommandAPI.Data;

public interface ICommandRepo
{
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById(int Id);

}