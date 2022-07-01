using CommandAPI.Models;

namespace CommandAPI.Data;

public class MockCommandRepo : ICommandRepo
{
    public IEnumerable<Command> GetAllCommands()
    {
        var commands = new List<Command>
        {
            new Command{Id=0, HowTo="A",Line="B", Platform="C"},
            new Command{Id=1, HowTo="A",Line="B", Platform="C"},
            new Command{Id=2, HowTo="A",Line="B", Platform="C"}
        };
        
        return commands;
    }

    public Command GetCommandById(int Id)
    {
        return new Command{Id=0, HowTo="A",Line="B", Platform="C"};
    }
}