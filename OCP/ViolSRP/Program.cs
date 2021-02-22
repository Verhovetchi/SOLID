using System;

namespace OCP
{
     class Program
     {
          static void Main(string[] args)
          {
               Logger logger = new Logger("Age can't be negative!!!");

               Player player = new Player(logger);

               player.Age = -10;

               Console.ReadKey();
          }
     }
}
