using System;

namespace DIP
{
     class Player
     {
          public virtual void getSalary() => Console.WriteLine("Get salary method!!!");
     }

     class SimplePlayer : Player
     {
          public override void getSalary()
          {
               Salary salary = new Salary();
               salary.Withdraw();
          }
     }

     class ModernPlayer : Player
     {
          private Salary salary;

          public ModernPlayer(Salary salary) => this.salary = salary;

          public override void getSalary() => salary.Withdraw();
     }

     class theMostModernPlayer : Player
     {
          private IExchange salary;

          public theMostModernPlayer(IExchange salary) => this.salary = salary;

          public override void getSalary() => salary.Withdraw();
     }
}
