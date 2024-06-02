using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }
        private readonly List<LightNode> children;
        private readonly List<string> cssClasses;
        private readonly List<EventListener> eventListeners;

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            children = new List<LightNode>();
            cssClasses = new List<string>();
            eventListeners = new List<EventListener>();
        }

        public void AddChild(LightNode child)
        {
            children.Add(child);
        }

        public void AddCssClass(string cssClass)
        {
            cssClasses.Add(cssClass);
        }

        public void AddEventListener(string eventType, Action<LightElementNode> callback)
        {
            eventListeners.Add(new EventListener(eventType, callback));
        }

        public void RemoveEventListener(string eventType, Action<LightElementNode> callback)
        {
            eventListeners.RemoveAll(listener => listener.EventType == eventType && listener.Callback == callback);
        }

        public void TriggerEvent(string eventType)
        {
            foreach (var listener in eventListeners)
            {
                if (listener.EventType == eventType)
                {
                    listener.Trigger(this);
                }
            }
        }

        public override string OuterHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{TagName}");

                if (cssClasses.Count > 0)
                {
                    sb.Append($" class=\"{string.Join(" ", cssClasses)}\"");
                }

                sb.Append(">");

                foreach (var child in children)
                {
                    sb.Append(child.OuterHTML);
                }

                if (Closing == ClosingType.Normal)
                {
                    sb.Append($"</{TagName}>");
                }

                return sb.ToString();
            }
        }

        public string InnerHTML
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var child in children)
                {
                    sb.Append(child.OuterHTML);
                }
                return sb.ToString();
            }
        }
    }
}
