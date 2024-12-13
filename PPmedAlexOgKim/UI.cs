namespace PPmedAlexOgKim;

internal class UI
{
    static void ColorMenuItem(string item)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(item, Console.BackgroundColor, Console.ForegroundColor);
        Console.ResetColor();
    }

    static int MenuGenerator(List<string> options)
    {
        Console.CursorVisible = false;

        int selectedOption = 0;
        while (true)
        {
            Console.WriteLine(ASCII.title);
            for (int option = 0; option < options.Count; option++)
            {
                if (selectedOption == option) { ColorMenuItem(options[option]); }
                else { Console.WriteLine(option); }
            }

            var input = Console.ReadKey(false).Key;
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOption < options.Count - 1) { selectedOption++; }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOption > 0) { selectedOption--; }
                    break;
                case ConsoleKey.Enter:
                    return selectedOption;
                case ConsoleKey.Q:
                    return 404;
            }

            Console.Clear();
        }
    }

    static void GoBackButton()
    {
        while (true)
        {
            ColorMenuItem("PRESS [Q] TO GO BACK");
            var input = Console.ReadKey(false).Key;
            if (input != ConsoleKey.Q) { continue; }
            else { return; }
        }
    }

    static void MakeTask()
    {
        Console.Write("Title for your task:\n~> ");
    }

    static void ShowTasks()
    {
        while (true)
        {
            //
        }
    }

    static void Menu()
    {
        List<string> options = new List<string>
        {
            "[1] Show you tasks",
            "[2] Create new task",
            "[Q] Exit"
        };

        while (true)
        {
            switch (MenuGenerator(options))
            {
                case 0:
                    ShowTasks();
                    break;
                case 1:
                    MakeTask();
                    break;
                case 404:
                    Console.CursorVisible = true;
                    return;
            }
        }
    }
}
