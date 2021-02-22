using System;

namespace SRP
{
     class Program
     {
          static void Main(string[] args)
          {
               Logger logger = new Logger();

               Player player = new Player(logger);
               player.Age = -20;

               Console.ReadKey();
          }
     }
}
