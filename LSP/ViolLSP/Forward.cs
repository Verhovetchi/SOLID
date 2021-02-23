using System;

namespace ViolLSP
{
     class Forward : Player
     {
          public Forward(int coefficient, int goals) : base(coefficient, goals){}

          public override int playerRating()
          {
               Rating = Coefficient * Goals;
               return Rating;
          }
     }
}
