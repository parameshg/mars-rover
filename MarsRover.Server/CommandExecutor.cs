using MarsRover.Server.Commands;

namespace MarsRover.Server
{
    public class CommandExecutor
    {
        private ICommand Previous { get; set; }

        public void Execute(ICommand command)
        {
            if (command is InvalidCommand)
                return;

            if (command is ExitCommand)
            {
                command.Execute();
                return;
            }

            if (Previous == null && !(command is PlaceCommand))
                return;

            if (command.Validate())
            {
                command.Execute();

                Previous = command;
            }
        }
    }
}