using System;
using System.Collections.Generic;

class TaskManager
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие: 1-Добавить, 2-Удалить, 3-Редактировать, 4-Просмотреть, 5-Выйти");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    DeleteTask();
                    break;
                case 3:
                    EditTask();
                    break;
                case 4:
                    ViewTasks();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Введите задачу для добавления:");
        string task = Console.ReadLine();
        tasks.Add(task);
    }

    static void DeleteTask()
    {
        ViewTasks();
        Console.WriteLine("Введите номер задачи для удаления:");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    static void EditTask()
    {
        ViewTasks();
        Console.WriteLine("Введите номер задачи для редактирования:");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < tasks.Count)
        {
            Console.WriteLine("Введите новое описание задачи:");
            string newTask = Console.ReadLine();
            tasks[index] = newTask;
        }
        else
        {
            Console.WriteLine("Неверный номер задачи.");
        }
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Задач нет.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
}
