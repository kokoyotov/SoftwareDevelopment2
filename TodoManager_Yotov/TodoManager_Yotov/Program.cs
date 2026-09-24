namespace TodoManager_Yotov
{
    internal class Program
    {
        static List<Task> tasks = new List<Task>();
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=== TodoManager - Меню ===");
                Console.ResetColor();
                Console.WriteLine("1. Добави нова задача");
                Console.WriteLine("2. Виж всички задачи");
                Console.WriteLine("3. Маркирай задача като изпълнена");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("5. Изход");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Избери опция (1-5): ");
                Console.ResetColor();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        CompleteTask();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        running = false;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Довиждане!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Невалиден избор! Натисни бутон, за да продължиш...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== Добавяне на нова задача ===");
            Console.ResetColor();

            Console.Write("Заглавие: ");
            string title = Console.ReadLine();

            Console.Write("Описание: ");
            string description = Console.ReadLine();

            Console.Write("Краен срок (напр. 2026-06-10): ");
            string dueDate = Console.ReadLine();

            tasks.Add(new Task(title, description, dueDate));

            Console.WriteLine("\nЗадачата е добавена успешно! Натисни бутон за връзка с менюто...");
            Console.ReadKey();
        }

        static void ViewTasks()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== Списък с всички задачи ===");
            Console.ResetColor();

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    var task = tasks[i];
                    string status = task.IsCompleted ? "[Изпълнена]" : "[Неизпълнена]";
                    Console.WriteLine($"{i + 1}. {task.Title} {status}");
                    Console.WriteLine($"   Бел: {task.Description}"); 
                    Console.WriteLine($"   Срок: {task.DueDate}");
                    Console.WriteLine(new string('-', 30));
                }
            }

            Console.WriteLine("\nНатисни бутон за връзка с менюто...");
            Console.ReadKey();
        }

        static void CompleteTask()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== Маркиране на задача като изпълнена ===");
            Console.ResetColor();

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма задачи за маркиране.");
            }
            else
            {
                ViewTasksListOnly();
                Console.Write("Въведи номер на задачата за изпълнение: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasks.Count)
                {
                    tasks[index - 1].IsCompleted = true;
                    Console.WriteLine("Задачата е маркирана като изпълнена!");
                }
                else
                {
                    Console.WriteLine("Невалиден номер!");
                }
            }

            Console.WriteLine("\nНатисни бутон за връзка с менюто...");
            Console.ReadKey();
        }

        static void DeleteTask()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=== Изтриване на задача ===");
            Console.ResetColor();

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма задачи за изтриване.");
            }
            else
            {
                ViewTasksListOnly();
                Console.Write("Въведи номер на задачата за изтриване: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine("Задачата беше изтрита!");
                }
                else
                {
                    Console.WriteLine("Невалиден номер!");
                }
            }

            Console.WriteLine("\nНатисни бутон за връзка с менюто...");
            Console.ReadKey();
        }

      
        static void ViewTasksListOnly()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsCompleted ? "✓" : "✗";
                Console.WriteLine($"{i + 1}. [{status}] {tasks[i].Title}");
            }
        }
    }
}
