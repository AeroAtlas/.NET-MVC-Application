using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
  public interface ICommanderRepo
  { //list of method signatures
    //Give all command objects
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById(int id);
  }
}