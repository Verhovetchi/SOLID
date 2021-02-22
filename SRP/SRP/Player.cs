using System;

namespace SRP
{
     class Player
     {
          private int age;
          
          private Logger log;

          public Player(Logger log)
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
                              throw new Exception("Age can't be negative");
                         else
                              age = value;

                         Console.WriteLine("The value has been set!!!");
                         
                    }
                    catch (Exception e)
                    {
                         log.Log(e.Message);
                    }
               }
          }
     }
}
