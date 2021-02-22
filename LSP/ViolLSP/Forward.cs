using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
