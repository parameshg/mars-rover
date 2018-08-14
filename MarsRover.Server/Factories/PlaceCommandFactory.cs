using MarsRover.Server.Commands;
using System;
using System.Drawing;

namespace MarsRover.Server.Factories
{
    public class PlaceCommandFactory : CommandFactory
    {
        public override string Name => "PLACE";

        public override string Description => "Places the rover in the specified postion";

        public PlaceCommandFactory(IRover rover)
            : base(rover)
        {
        }

        public override ICommand Create(params string[] args)
        {
            ICommand result = null;

            if (!args.Length.Equals(4))
                throw new ArgumentException("invalid number of arguments");

            var x = 0;
            var y = 0;
            var direction = Direction.NORTH;

            if (!int.TryParse(args[1], out x))
                throw new ArgumentException("invalid position coordinates (x)");


            if (!int.TryParse(args[2], out y))
                throw new ArgumentException("invalid position coordinates (y)");

            if (!Enum.TryParse<Direction>(args[3], out direction))
                throw new ArgumentException("invalid direction");

            result = new PlaceCommand(Rover, new Point(x, y), direction);

            return result;
        }
    }
}