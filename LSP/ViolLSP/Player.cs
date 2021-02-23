using System;

namespace ViolLSP
{
     class Player
     {
          protected int Rating { get; set; }
          protected int Coefficient { get; set; }
          protected int Goals { get; set; }

          public Player(){}

          public Player(int coefficient, int goals)
          {
               Coefficient = coefficient;
               Goals = goals;
          }

          public virtual int playerRating()
          {
               Rating = 10;
               return Rating;
          }

     }
}
