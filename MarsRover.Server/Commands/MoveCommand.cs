namespace MarsRover.Server.Commands
{
    public class MoveCommand : Command
    {
        public MoveCommand(IRover rover)
            : base(rover)
        {
        }

        public override bool Validate()
        {
            var result = false;

            if (Rover != null && !Rover.Area.IsEmpty)
            {
                var position = new int[] { Rover.Position.X, Rover.Position.Y };

                switch (Rover.Direction)
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

                result = position[0] >= 0 && position[0] < Rover.Area.Width && position[1] >= 0 && position[1] < Rover.Area.Height;
            }

            return result;
        }

        public override void Execute()
        {
            Rover.Move();
        }
    }
}