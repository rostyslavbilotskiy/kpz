using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Level2Support : AbstractHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Чи ви отримали помилку при спробі увійти в систему? (так/ні)");
            string response = Console.ReadLine().ToLower();
            if (response == "так")
            {
                Console.WriteLine("Рівень 2 підтримки: Будь ласка, перевірте ваші облікові дані і спробуйте ще раз.");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
