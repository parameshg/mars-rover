using System;

namespace MarsRover.Server.Commands
{
    public class InvalidCommand : ICommand
    {
        public bool Validate()
        {
            return true;
        }

        public void Execute()
        {
            Console.WriteLine("invalid command");
        }
    }
}