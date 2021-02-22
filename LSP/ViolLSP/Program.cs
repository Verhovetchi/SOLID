using System;

namespace ViolLSP
{
     class Program
     {
          static void Main(string[] args)
          {
               Player forward = new Driver();

               int points = forward.playerRating();

               Console.WriteLine(points);

               Console.ReadKey();
          }
     }
}
