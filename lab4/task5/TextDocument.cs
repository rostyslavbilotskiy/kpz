using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextDocument
    {
        private string _content;

        public TextDocument(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(_content);
        }

        public void RestoreMemento(TextDocumentMemento memento)
        {
            _content = memento.GetSavedContent();
        }
    }
}
