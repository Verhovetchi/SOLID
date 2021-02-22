using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolLSP
{
     class Duck : Bird
     {
          public int SwimSpeed { get; set; }
          public override int Fly()
          {
               FlySpeed = 8;
               return FlySpeed;
          }

          public int swim()
          {
               SwimSpeed = 2;
               return SwimSpeed;
          }
     }
}
