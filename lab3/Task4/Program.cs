using Task4;

class Program
{
        static void Main(string[] args)
        {
            SmartTextReader reader = new SmartTextReader();

            // Використання SmartTextChecker для логування
            SmartTextChecker checker = new SmartTextChecker(reader);
            char[][] contentWithLogging = checker.ReadFile("example.txt");

            // Використання SmartTextReaderLocker для обмеження доступу
            SmartTextReaderLocker locker = new SmartTextReaderLocker(reader, @"restricted.*\.txt");

            // Доступ дозволений
            char[][] contentAllowed = locker.ReadFile("example.txt");

            // Доступ заборонений
            char[][] contentDenied = locker.ReadFile("restricted_file.txt");
        }
}
