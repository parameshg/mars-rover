using MarsRover.Server;
using System;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parser = new CommandParser(new Rover());

            var executor = new CommandExecutor();

            Console.WriteLine("Type EXIT to quit program");

            while (true)
            {
                executor.Execute(parser.Parse(Console.ReadLine()));
            }
        }
    }
}