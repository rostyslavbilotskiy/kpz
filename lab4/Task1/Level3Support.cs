using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Level3Support : AbstractHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Чи маєте ви питання щодо рахунку або платежів? (так/ні)");
            string response = Console.ReadLine().ToLower();
            if (response == "так")
            {
                Console.WriteLine("Рівень 3 підтримки: Будь ласка, перевірте ваш рахунок в особистому кабінеті або зв'яжіться з бухгалтерією.");
            }
            else
            {
                base.Handle();
            }
        }
    }

}
