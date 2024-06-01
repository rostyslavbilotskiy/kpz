using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{

    public enum DisplayType
    {
        Block,
        Inline
    }

    public enum ClosingType
    {
        SelfClosing,
        Normal
    }

    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }
        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
        }

        public void AddCssClass(string cssClass)
        {
            CssClasses.Add(cssClass);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{TagName}");

                if (CssClasses.Count > 0)
                {
                    sb.Append(" class=\"");
                    sb.Append(string.Join(" ", CssClasses));
                    sb.Append("\"");
                }

                if (Closing == ClosingType.SelfClosing)
                {
                    sb.Append(" />");
                }
                else
                {
                    sb.Append(">");
                    sb.Append(InnerHTML);
                    sb.Append($"</{TagName}>");
                }

                return sb.ToString();
            }
        }

        public override string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }
    }

}
