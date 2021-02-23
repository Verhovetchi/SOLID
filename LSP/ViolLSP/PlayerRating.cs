using System;

namespace ViolLSP
{
     class PlayerRating : Player
     {
          private Player player;

          public PlayerRating(Player player)
          {
               this.player = player;
          }

          public void position()
          {
               Rating = player.playerRating();
          }
     }
}
