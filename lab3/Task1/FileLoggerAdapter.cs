using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FileLoggerAdapter : Logger
    {
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public new void Log(string message)
        {
            fileWriter.WriteLine($"Log: {message}");
        }

        public new void Error(string message)
        {
            fileWriter.WriteLine($"Error: {message}");
        }

        public new void Warn(string message)
        {
            fileWriter.WriteLine($"Warn: {message}");
        }
    }
}
