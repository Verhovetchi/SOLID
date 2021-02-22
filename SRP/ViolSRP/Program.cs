using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolSRP
{
     class Program
     {
          static void Main(string[] args)
          {
               Player player = new Player();

               try
               {
                    player.Age = -20;
               }
               catch (Exception e)
               {
                    Console.WriteLine(e.Message);
               }

               Console.ReadKey();
          }
     }
}
