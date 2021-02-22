using System;

namespace ViolOCP
{
     public class FileLogger: ILogger
     {
          public FileLogger(string message) => Message = message;

          public string Message { get; set; }

          private void saveToFile(string message) => Console.WriteLine($"saveToFile:\n{message}");

          public void Log() => saveToFile(Message);
     }
}
