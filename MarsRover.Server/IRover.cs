using System.Drawing;

namespace MarsRover.Server
{
    public interface IRover
    {
        Size Area { get; }

        Point Position { get; }

        Direction Direction { get; }

        void Stand(Point position, Direction direction);

        void TurnLeft();

        void TurnRight();

        void Move();
    }
}