using System.Security.Cryptography.X509Certificates;

namespace PPmedAlexOgKim;

public class Overview
{
    List<Task> myTasks = new List<Task>();

    public void MainMenu()
    {
        Console.WriteLine("Welcome");

        string Choise = Console.ReadLine();
        switch (Choise)
        {
            case "1":
                PrintList(); break;
            case "2":
                AddTask(); break;
            case "3":
                RemoveTask(); break;
            default:
                Environment.Exit(0);
                break;
        }
    }

    void PrintList()
    {
        foreach (var task in myTasks)
        {
            Console.WriteLine();
            Console.WriteLine(task.getTitle());
            Console.WriteLine(task.getDescription());
            Console.WriteLine();
            
        }
    }

    public void AddTask()
    {
        string tit = "";

        var NewTask = new Task();

    }
}