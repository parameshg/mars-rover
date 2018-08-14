namespace MarsRover.Server.Commands
{
    public interface ICommand
    {
        bool Validate();

        void Execute();
    }
}