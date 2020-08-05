using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommanderRepo
  {
    public IEnumerable<Command> GetAllCommands()
    {
      var commands = new List<Command>
      {
        new Command{Id=0, HowTo="Boil0", Line="Egg0", Platform="Kettle & Pan0"},
        new Command{Id=1, HowTo="Boil1", Line="Egg1", Platform="Kettle & Pan1"},
        new Command{Id=2, HowTo="Boil2", Line="Egg2", Platform="Kettle & Pan2"}
      };

      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command{Id=0, HowTo="Boil", Line="Egg", Platform="Kettle & Pan"};
    }
  }
}