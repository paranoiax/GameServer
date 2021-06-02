using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Title = "Game Server";

            Server.Start(50, 26950);

            Console.ReadKey();
        }
    }
}
