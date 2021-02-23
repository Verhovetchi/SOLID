using System;

namespace ViolLSP
{
     class PoolPlayer : Player
     {
          public PoolPlayer(int? coefficient, int? goals)
          {
               Coefficient = coefficient.Value;
               Goals = goals.Value;
          }

          public override int playerRating()
          {
               return Coefficient * Goals;
          }
     }
}
