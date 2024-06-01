using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextChecker : SmartTextReader
    {
        private SmartTextReader _smartTextReader;

        public SmartTextChecker(SmartTextReader smartTextReader)
        {
            _smartTextReader = smartTextReader;
        }

        public new char[][] ReadFile(string filePath)
        {
            Console.WriteLine("Attempting to open file: " + filePath);
            char[][] result = _smartTextReader.ReadFile(filePath);
            Console.WriteLine("Successfully read file: " + filePath);

            int lineCount = result.Length;
            int charCount = 0;
            foreach (var line in result)
            {
                charCount += line.Length;
            }
            Console.WriteLine($"File contains {lineCount} lines and {charCount} characters.");

            return result;
        }
    }
}
