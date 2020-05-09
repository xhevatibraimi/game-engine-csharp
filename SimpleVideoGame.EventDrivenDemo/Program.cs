using System;

namespace SimpleVideoGame.EventDrivenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC to exit");
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                switch (keyinfo.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("\nMoving Left");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("\nMoving Down");
                        break;
                    case ConsoleKey.W:
                        Console.WriteLine("\nMoving Up");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("\nMoving Right");
                        break;
                }
            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
    }
}
