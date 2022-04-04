using System;

namespace Gra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(10, 20);
            Console.WriteLine("Hello World!");
            player.update();
            Console.ReadLine();
        }
    }
}
