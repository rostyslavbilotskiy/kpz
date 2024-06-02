using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Level4Support : AbstractHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Чи потребуєте ви технічної підтримки для апаратного забезпечення? (так/ні)");
            string response = Console.ReadLine().ToLower();
            if (response == "так")
            {
                Console.WriteLine("Рівень 4 підтримки: Будь ласка, зв'яжіться з нашим відділом технічної підтримки апаратного забезпечення.");
            }
            else
            {
                base.Handle();
            }
        }
    }

}
