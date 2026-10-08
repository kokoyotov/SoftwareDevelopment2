namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Възраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            { if (age >= 6 && age <= 30)
                    Console.WriteLine($"Възраст: {age}");
                else Console.WriteLine("Няма как да е ученик");
            }
            else
            {
                Console.WriteLine("Невалидна възраст.");
            }
            Console.WriteLine("Клас: " );
            if (byte.TryParse(Console.ReadLine(), out byte grade))
            {
                if (grade <= 12)
                    Console.WriteLine($"Клас: {grade}");
                else
                {
                    Console.WriteLine("Няма такъв клас");
                }
            }
            else
            {
                Console.WriteLine("Невалиден клас.");
            }
            Console.WriteLine("Среден успех: " );
            if (double.TryParse(Console.ReadLine(), out double suc))
            {
                if (suc >= 2.0 && suc <= 6.0)
                    Console.WriteLine($"Среден успех: {suc}");
                else
                {
                    Console.WriteLine("Невалидна оценка");
                }
            }
            else
            {
                Console.WriteLine("Невалидна оценка.");
            }
            Console.WriteLine("Такса" );
            if (decimal.TryParse(Console.ReadLine(), out decimal money))
            {

                Console.WriteLine($"Пари: {money}");

            }
            else
            {
                Console.WriteLine("Паричната стойност е невалидна.");
            }
        }
    }
}
