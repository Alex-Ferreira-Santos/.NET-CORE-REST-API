using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, Howto="Boil an egg", Line="Boil water", Platform="Kettle & pan"},
                new Command{Id=0, Howto="Cut Bread", Line="Get a knife", Platform="knife & chopping board"},
                new Command{Id=0, Howto="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & cup"}
            };
            return commands;
        }

        public Command GetcommandById(int id)
        {
            return new Command{Id=0, Howto="Boil an egg", Line="Boil water", Platform="Kettle & pan"};
        }
    }
}