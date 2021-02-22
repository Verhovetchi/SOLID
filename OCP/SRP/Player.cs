using System;

namespace ViolOCP
{
     public class Player
     {
          private int age;

          private ILogger log;

          public Player(ILogger log)
          {
               this.log = log;
          }

          public int Age
          {
               get
               {
                    return age;
               }
               set
               {
                    try
                    {
                         if (value < 0)
                              throw new Exception();
                         else
                              age = value;

                         Console.WriteLine("The value has been set!!!");
                    }
                    catch (Exception)
                    {
                         log.Log();
                    }
               }
          }
     }
}
