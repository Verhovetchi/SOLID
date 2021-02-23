using System;

namespace ViolLSP
{
     class Program
     {
          static void Main(string[] args)
          {
               Player forward = new Forward(2, 24);

               int points = forward.playerRating();

               Console.WriteLine(points);

               Console.ReadKey();
          }
     }
}
