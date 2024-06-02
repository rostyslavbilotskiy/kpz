using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Level1Support : AbstractHandler
    {
        public override void Handle()
        {
            Console.WriteLine("Ви телефонуєте на підтримку. Чи маєте ви проблеми з підключенням до інтернету? (так/ні)");
            string response = Console.ReadLine().ToLower();
            if (response == "так")
            {
                Console.WriteLine("Рівень 1 підтримки: Будь ласка, перевірте ваше з'єднання і спробуйте перезавантажити маршрутизатор.");
            }
            else
            {
                base.Handle();
            }
        }
    }
}
