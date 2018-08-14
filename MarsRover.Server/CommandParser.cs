using MarsRover.Server.Commands;
using MarsRover.Server.Factories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover.Server
{
    public class CommandParser
    {
        private IRover Rover { get; set; }

        private List<ICommandFactory> Commands { get; set; }

        public CommandParser(IRover rover)
        {
            Rover = rover;

            Commands = new List<ICommandFactory>();
            Commands.Add(new LeftCommandFactory(rover));
            Commands.Add(new RightCommandFactory(rover));
            Commands.Add(new PlaceCommandFactory(rover));
            Commands.Add(new MoveCommandFactory(rover));
            Commands.Add(new ReportCommandFactory(rover));
            Commands.Add(new ExitCommandFactory(rover));
        }

        public ICommand Parse(string cmd)
        {
            ICommand result = null;

            var args = cmd.Split(new char[] { ' ', ',' });

            if (args.Length >= 1)
            {
                var factory = Commands.FirstOrDefault(i => i.Name.Equals(args[0], StringComparison.CurrentCultureIgnoreCase));

                result = factory != null ? factory.Create(args) : new InvalidCommand();
            }
            else
                result = new InvalidCommand();

            return result;
        }
    }
}