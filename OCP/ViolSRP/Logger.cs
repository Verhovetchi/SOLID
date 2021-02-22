using System;

namespace OCP
{
     public class Logger
     {
          public string Message { get; set; }
          
          public Logger(string message) => Message = message;

          private void saveToFile(string message) => Console.WriteLine(message);

          private void saveToDB(string message) => Console.WriteLine(message);

          public void LogFile(string message) => saveToFile(message);

          public void LogDB(string message) => saveToDB(message);
     }
}
