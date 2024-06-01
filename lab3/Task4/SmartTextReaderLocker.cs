using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private SmartTextReader _smartTextReader;
        private Regex _regex;

        public SmartTextReaderLocker(SmartTextReader smartTextReader, string pattern)
        {
            _smartTextReader = smartTextReader;
            _regex = new Regex(pattern);
        }

        public new char[][] ReadFile(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            else
            {
                return _smartTextReader.ReadFile(filePath);
            }
        }
    }
}
