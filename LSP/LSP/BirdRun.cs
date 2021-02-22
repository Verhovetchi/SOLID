using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolLSP
{
     class BirdRun : Bird
     {
          private Bird bird;

          public BirdRun(Bird bird)
          {
               this.bird = bird;
          }

          public void run()
          {
               FlySpeed = bird.Fly();
          }
     }
}
