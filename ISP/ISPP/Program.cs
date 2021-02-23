using System;

namespace ISPP
{
     class Program
     {
          static void Main(string[] args)
          {
               Player player = new Goalkeeper();

               player.Show();
               
               Console.ReadKey();
          }
     }
}