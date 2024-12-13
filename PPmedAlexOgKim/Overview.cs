using System.Security.Cryptography.X509Certificates;

namespace PPmedAlexOgKim;

public class Overview
{
    List<Task> myTasks = new List<Task>();

    public void MainMenu()
    {
        while (true)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Print all Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Remove Task");
            string Choise = Console.ReadLine();
            switch (Choise)
            {
                case "1":
                    PrintList(); break;
                case "2":
                    inputTask(); break;
                case "3":
                    EditTasks(); break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    void PrintList()
    {
        for(int i = 0; i< myTasks.Count; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"{i}. {myTasks[i].getTitle()}");
            Console.WriteLine(myTasks[i].getDescription());
            Console.WriteLine();
            
        }
    }

    public void inputTask()
    {
        Console.Clear();
        Console.WriteLine("Add Title:");
        string title = Console.ReadLine();
        Console.WriteLine("Add Description");
        string Descrip = Console.ReadLine();
        AddTask(title, Descrip);
    }

    public void AddTask(string title, string desc)
    {
        string tit = title ?? "";
        string des = desc ?? "";
        var NewTask = new Task(tit,des);
        myTasks.Add(NewTask);
    }

    public void EditTasks()
    {
        Console.Clear();
        PrintList();
        Console.WriteLine("Remove at index:");
        int index = int.Parse(Console.ReadLine());
        RemoveTask(index);
    }

    public void RemoveTask(int index)
    {
        myTasks.RemoveAt(index);
    }
}