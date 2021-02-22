using System;

namespace ISPP
{
     class Program
     {
          static void Main(string[] args)
          {
               Player player = new Forward();

               player.Show();
               
               Console.ReadKey();
          }
     }
}