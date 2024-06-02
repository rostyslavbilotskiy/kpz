using System;
using task5;

class Program
{
    static void Main(string[] args)
    {
        // cтворення текстового документу та редактора
        TextDocument document = new TextDocument("Initial content");
        TextEditor editor = new TextEditor(document);

        // відображення  вмісту документа
        editor.PrintDocument();

        // зміна вмісту документа та збереження
        editor.ModifyContent("Modified content");
        editor.Save();
        editor.PrintDocument();

        // cкасування змін та відновлення попереднього стану
        editor.Undo();
        editor.PrintDocument();
    }
}
