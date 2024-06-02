using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle()
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle();
            }
            else
            {
                Console.WriteLine("Немає доступних рівнів підтримки для вашого запиту.");
            }
        }
    }

}
