using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class LightTextNode : LightNode
    {
        public string Text { get; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Text);
                return sb.ToString();
            }
        }
    }
}
