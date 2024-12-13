namespace PPmedAlexOgKim;

public static class UI
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
            Console.Clear();
            Console.WriteLine(ASCII.title);

            for (int option = 0; option < options.Count; option++)
            {
                if (selectedOption == option) { ColorMenuItem(options[option]); }
                else { Console.WriteLine(options[option]); }
            }

            var input = Console.ReadKey(false).Key;
            switch (input)
            {
                case ConsoleKey.UpArrow:
                    if (selectedOption > 0) { selectedOption--; }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedOption < options.Count - 1) { selectedOption++; }
                    break;
                case ConsoleKey.Enter:
                    return selectedOption;
                case ConsoleKey.Q:
                    return 404;
            }
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

    static void MakeTask(Overview MyList)
    {
        Console.Clear();
        Console.WriteLine(ASCII.title);
        Console.Write("Title for your task:\n~> ");
        var title = Console.ReadLine() ?? string.Empty;
        Console.Write("Description for your task:\n~> ");
        var description = Console.ReadLine() ?? string.Empty;
        MyList.AddTask(title, description);
    }

    static void ShowTasks(Overview MyList)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(ASCII.title);

            List<string> ScrollableList = new List<string>();

            foreach (var task in MyList.myTasks)
            {
                if (task.isActive) { ScrollableList.Add($"[X] {task.Title}: {task.Description}"); }
                else { ScrollableList.Add($"[ ] {task.Title}: {task.Description}"); }
            }

            int selectedOption = MenuGenerator(ScrollableList);

            if (selectedOption == 404)
            {
                return;
            }
            else
            {
                for (int i = 0; i < ScrollableList.Count; i++)
                {
                    if (i == selectedOption)
                    {
                        var curTask = MyList.myTasks[i].isActive;
                        MyList.myTasks[i].isActive = curTask == true ? false : true;
                    }
                }
            }
        }
    }

    public static void Menu(Overview MyList)
    {
        List<string> options = new List<string>
        {
            "[1] Show your tasks",
            "[2] Create new task",
        };

        while (true)
        {
            switch (MenuGenerator(options))
            {
                case 0:
                    ShowTasks(MyList);
                    break;
                case 1:
                    MakeTask(MyList);
                    break;
                case 404:
                    Console.CursorVisible = true;
                    return;
            }
        }
    }
}
