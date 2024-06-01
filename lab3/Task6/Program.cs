using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Task6;

namespace LightHTML
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            string text = await DownloadTextAsync(url);
            List<string> lines = new List<string>(text.Split('\n'));

            LightElementNode htmlDocument = CreateHTMLDocument(lines);
            string htmlContent = htmlDocument.OuterHTML;

            // Записуємо результат в файл
            await File.WriteAllTextAsync("output.html", htmlContent);
            Console.WriteLine("HTML content saved to output.html");

            // Показуємо розмір дерева в пам'яті
            long memoryBefore = GC.GetTotalMemory(true);
            _ = htmlContent;
            long memoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used by HTML tree: {memoryAfter - memoryBefore} bytes");

            // Використання Легковаговик
            LightElementNode optimizedDocument = CreateOptimizedHTMLDocument(lines);
            string optimizedHtmlContent = optimizedDocument.OuterHTML;

            // Записуємо оптимізований результат в інший файл
            await File.WriteAllTextAsync("optimized_output.html", optimizedHtmlContent);
            Console.WriteLine("Optimized HTML content saved to optimized_output.html");

            // Показуємо розмір дерева в пам'яті після оптимізації
            memoryBefore = GC.GetTotalMemory(true);
            _ = optimizedHtmlContent;
            memoryAfter = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used by optimized HTML tree: {memoryAfter - memoryBefore} bytes");
        }

        static async Task<string> DownloadTextAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        static LightElementNode CreateHTMLDocument(List<string> lines)
        {
            LightElementNode html = new LightElementNode("html", DisplayType.Block, ClosingType.Normal);
            LightElementNode body = new LightElementNode("body", DisplayType.Block, ClosingType.Normal);

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i].TrimEnd();

                LightNode element;
                if (i == 0)
                {
                    element = new LightElementNode("h1", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }
                else if (line.Length < 20)
                {
                    element = new LightElementNode("h2", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }
                else if (line.StartsWith(" "))
                {
                    element = new LightElementNode("blockquote", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }
                else
                {
                    element = new LightElementNode("p", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }

                body.AddChild(element);
            }

            html.AddChild(body);
            return html;
        }

        static LightElementNode CreateOptimizedHTMLDocument(List<string> lines)
        {
            FlyweightFactory factory = new FlyweightFactory();
            LightElementNode html = new LightElementNode("html", DisplayType.Block, ClosingType.Normal);
            LightElementNode body = new LightElementNode("body", DisplayType.Block, ClosingType.Normal);

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i].TrimEnd();

                LightNode element;
                if (i == 0)
                {
                    element = factory.GetElement("h1", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }
                else if (line.Length < 20)
                {
                    element = factory.GetElement("h2", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }
                else if (line.StartsWith(" "))
                {
                    element = factory.GetElement("blockquote", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }
                else
                {
                    element = factory.GetElement("p", DisplayType.Block, ClosingType.Normal);
                    ((LightElementNode)element).AddChild(new LightTextNode(line));
                }

                body.AddChild(element);
            }

            html.AddChild(body);
            return html;
        }
    }
}
