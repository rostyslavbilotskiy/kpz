using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextEditor
    {
        private TextDocument _document;
        private TextDocumentMemento _memento;

        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void Save()
        {
            _memento = _document.CreateMemento();
            Console.WriteLine("Document saved.");
        }

        public void Undo()
        {
            if (_memento != null)
            {
                _document.RestoreMemento(_memento);
                Console.WriteLine("Undo changes. ");
            }
            else
            {
                Console.WriteLine("Cannot undo. ");
            }
        }

        public void ModifyContent(string newContent)
        {
            _document.SetContent(newContent);
            Console.WriteLine("Document content modified.");
        }

        public void PrintDocument()
        {
            Console.WriteLine("Current document content:");
            Console.WriteLine(_document.GetContent());
        }
    }

}
