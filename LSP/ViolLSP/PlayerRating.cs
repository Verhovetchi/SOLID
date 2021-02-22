using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
