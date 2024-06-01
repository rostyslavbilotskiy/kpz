using System;
using Task5;

    class Program
    {
        static void Main(string[] args)
        {
        //створення таблиці
            LightElementNode table = new LightElementNode("table", DisplayType.Block, ClosingType.Normal);
            table.AddCssClass("my-table");

            LightElementNode tbody = new LightElementNode("tbody", DisplayType.Block, ClosingType.Normal);

            LightElementNode tr1 = new LightElementNode("tr", DisplayType.Block, ClosingType.Normal);
            LightElementNode td1 = new LightElementNode("td", DisplayType.Block, ClosingType.Normal);
            td1.AddChild(new LightTextNode("Row 1, Cell 1"));
            LightElementNode td2 = new LightElementNode("td", DisplayType.Block, ClosingType.Normal);
            td2.AddChild(new LightTextNode("Row 1, Cell 2"));

            tr1.AddChild(td1);
            tr1.AddChild(td2);
            tbody.AddChild(tr1);

            LightElementNode tr2 = new LightElementNode("tr", DisplayType.Block, ClosingType.Normal);
            LightElementNode td3 = new LightElementNode("td", DisplayType.Block, ClosingType.Normal);
            td3.AddChild(new LightTextNode("Row 2, Cell 1"));
            LightElementNode td4 = new LightElementNode("td", DisplayType.Block, ClosingType.Normal);
            td4.AddChild(new LightTextNode("Row 2, Cell 2"));

            tr2.AddChild(td3);
            tr2.AddChild(td4);
            tbody.AddChild(tr2);

            table.AddChild(tbody);

            Console.WriteLine("OuterHTML:");
            Console.WriteLine(table.OuterHTML);

            Console.WriteLine("\nInnerHTML:");
            Console.WriteLine(table.InnerHTML);
        }
    }
