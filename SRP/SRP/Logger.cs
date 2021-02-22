using System;

namespace SRP
{
     public class Logger
     {
          public string Message { get; set; }

          private void saveToFile(string message) => Console.WriteLine("Save to File:\n" + message);

          public void Log(string message) => saveToFile(message);
     }
}
