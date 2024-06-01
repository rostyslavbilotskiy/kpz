using Task2;

    class Program
    {
        static void Main(string[] args)
        {
            // воїн з одягом, зброєю та артефактом
            Hero warrior = new Warrior();
            warrior = new Armor(warrior);
            warrior = new Weapon(warrior);
            warrior = new Artifact(warrior);
            warrior.Display();

            Console.WriteLine();

            //мага з одягом та зброєю
            Hero mage = new Mage();
            mage = new Armor(mage);
            mage = new Weapon(mage);
            mage.Display();

            Console.WriteLine();

            // паладина з артефактом
            Hero paladin = new Paladin();
            paladin = new Artifact(paladin);
            paladin.Display();
        }
    }
