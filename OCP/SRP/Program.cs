using System;

namespace ViolOCP
{
     class Program
     {
          static void Main(string[] args)
          {
               ILogger log = new FileLogger("Age can't be negative!!");
               
               Player player = new Player(log);

               player.Age = -10;

               Console.ReadKey();
          }
     }
}
