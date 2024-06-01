using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

class Program
{
    static void Main(string[] args)
    {
        FileWriter fileWriter = new FileWriter();

        Logger fileLogger = new FileLoggerAdapter(fileWriter);

        fileLogger.Log("This is a log message");
        fileLogger.Error("This is an error message");
        fileLogger.Warn("This is a warning message");

        Console.ReadLine();
    }
}
