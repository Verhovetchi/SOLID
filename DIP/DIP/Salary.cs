using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
     class Salary : IExchange
     {
          public virtual void Withdraw() => Console.WriteLine("Withdraw the salary!!!");
     }

     class SalaryEuro : Salary, IExchange
     {
          public override void Withdraw()
          {
               base.Withdraw();
               Console.WriteLine("currency: Euros");
          }
     }

     class SalaryPound : Salary, IExchange
     {
          public override void Withdraw()
          {
               base.Withdraw();
               Console.WriteLine("currency: Pounds");
          }
     }
}
