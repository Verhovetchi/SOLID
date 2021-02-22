using System;

namespace ViolationISP
{
     class Program
     {
          static void Main(string[] args)
          {
               Player player = new Midfield();

               try
               {
                    player.Show();
               }
               catch (Exception e)
               {
                    Console.WriteLine(e.Message);
               }
               

               Console.ReadKey();
          }
     }
}
