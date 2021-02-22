using System;

namespace OCP
{
     class Player
     {
          private int age;

          Logger logger;

          public Player(Logger log)
          {
               logger = log;
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
                              throw new Exception(logger.Message);
                         else
                              age = value;

                         Console.WriteLine("The value has been set!!!");
                    }
                    catch(Exception e)
                    {
                         logger.LogFile(e.Message);
                    }
               }
          }

          //public void logError(string error) => Console.WriteLine(error);
     }
}
