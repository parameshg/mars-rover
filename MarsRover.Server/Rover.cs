using MarsRover.Server.Tools;
using System;
using System.Drawing;

namespace MarsRover.Server
{
    public class Rover : IRover
    {
        public Size Area { get; private set; }

        public Point Position { get; private set; }

        public Direction Direction { get; private set; }

        private CircularLinkedList<Direction> Directions { get; set; }

        public Rover()
        {
            Area = new Size(5, 5);
            Directions = new CircularLinkedList<Direction>();
            Directions.Add(Direction.NORTH);
            Directions.Add(Direction.EAST);
            Directions.Add(Direction.SOUTH);
            Directions.Add(Direction.WEST);
        }

        public void Stand(Point position, Direction direction)
        {
            if (position.X < 0 || position.X >= Area.Width || position.Y < 0 || position.Y >= Area.Height)
                throw new ApplicationException("invalid position");

            Position = position;
            Direction = direction;
            Directions.GoTo(direction);
        }

        public void TurnLeft()
        {
            Directions.Previous();

            Direction = Directions.Current.Value;
        }

        public void TurnRight()
        {
            Directions.Next();

            Direction = Directions.Current.Value;
        }

        public void Move()
        {
            var position = new int[] { Position.X, Position.Y };

            switch (Direction)
            {
                case Direction.NORTH:
                    position[1]++;
                    break;

                case Direction.SOUTH:
                    position[1]--;
                    break;

                case Direction.EAST:
                    position[0]++;
                    break;

                case Direction.WEST:
                    position[0]--;
                    break;
            }

            if (position[0] < 0 || position[0] >= Area.Width || position[1] < 0 || position[1] >= Area.Height)
                throw new ApplicationException("rover may got out of sigal");

            Position = new Point(position[0], position[1]);
        }
    }
}