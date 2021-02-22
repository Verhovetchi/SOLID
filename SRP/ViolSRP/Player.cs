using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolSRP
{
     class Player
     {
          private int age;

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
                              throw new Exception("The age can't be negative!!!");
                         else
                              age = value;

                         Console.WriteLine("The age has been set!!!");
                    }
                    catch(Exception e)
                    {
                         logError(e.Message);
                    }
               }
          }

          private void logError(string message) => Console.WriteLine($"Error message: {message} \nSave to file!!!");
          
     }
}
