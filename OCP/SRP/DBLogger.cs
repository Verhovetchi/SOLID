using System;

namespace ViolOCP
{
     public class DBLogger : ILogger
     {
          public DBLogger(string message) => Message = message;

          public string Message { get; set; }

          private void saveToDB(string message) => Console.WriteLine($"saveToDB:\n{message}");

          public void Log() => saveToDB(Message);
     }
}
