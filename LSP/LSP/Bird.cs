using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolLSP
{
     class Bird
     {
          protected int FlySpeed { get; set; }
          public virtual int Fly()
          {
               FlySpeed = 10;
               return FlySpeed;
          }

     }
}
