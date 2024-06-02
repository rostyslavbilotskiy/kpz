using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextDocumentMemento
    {
        private readonly string _content;

        public TextDocumentMemento(string content)
        {
            _content = content;
        }

        public string GetSavedContent()
        {
            return _content;
        }
    }
}
