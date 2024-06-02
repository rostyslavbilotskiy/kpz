using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class FlyweightFactory
    {
        private Dictionary<string, LightElementNode> elements = new Dictionary<string, LightElementNode>();

        public LightElementNode GetElement(string tagName, DisplayType display, ClosingType closing)
        {
            string key = $"{tagName}-{display}-{closing}";

            if (!elements.ContainsKey(key))
            {
                elements[key] = new LightElementNode(tagName, display, closing);
            }

            return elements[key];
        }
    }
}
