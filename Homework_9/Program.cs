using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Homework_9
{
    enum MenuItem
    {
        TaskAdd = '!',
        TaskChange = '$',
        TaskDelete = '?',
    }

    enum MenuItemAction
    {
        TaskContinue = '%',
        TaskStop = '&'
    }
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Your To-Do List for Today: ");

            List<string> toDoList = new List<string>() { "Grocery Shopping", "Daily Exercise", "Contact the Bank", "Cook Dinner", "Weekend Trip Planning" };

            toDoList.ForEach(task => Console.WriteLine(task));

            while (true)
            {
                try
                {
                    Console.WriteLine($"\nIf You want to Add Task: Press: {(char)MenuItem.TaskAdd} \nIf You want to Change Task: Press: {(char)MenuItem.TaskChange} \nIf You want to Delete Task: Press: {(char)MenuItem.TaskDelete}");
                    var menuSelect = (char)Console.Read();
                    Console.ReadLine();
                    var currentSelect = (MenuItem)menuSelect;

                    if (menuSelect != ((char)MenuItem.TaskAdd) && menuSelect != ((char)MenuItem.TaskChange) && menuSelect != ((char)MenuItem.TaskDelete))
                    {
                        throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                    }

                    switch (currentSelect)
                    {
                        case MenuItem.TaskAdd:
                            Console.WriteLine("Please share what else you would like to accomplish today: ");
                            toDoList.Add(Console.ReadLine() ?? string.Empty);
                            Console.Write("\n");
                            toDoList.ForEach(task => Console.WriteLine(task));
                            const int maxTasksForToday = 10;

                            while (toDoList.Count < maxTasksForToday)
                            {
                                try
                                {
                                    Console.WriteLine($"\nIf You want to Add more Tasks: Press: {(char)MenuItemAction.TaskContinue} \nIf You want to Stop Adding Tasks: Press {(char)MenuItemAction.TaskStop}");
                                    var menuSelectAction = (char)Console.Read();
                                    Console.ReadLine();
                                    var currentSelectAction = (MenuItemAction)menuSelectAction;

                                    if (menuSelectAction != ((char)MenuItemAction.TaskContinue) && menuSelectAction != ((char)MenuItemAction.TaskStop))
                                    {
                                        throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                                    }

                                    if (menuSelectAction == ((char)MenuItemAction.TaskContinue))
                                    {
                                        Console.WriteLine("Please share what else you would like to accomplish today: ");
                                        toDoList.Add(Console.ReadLine() ?? string.Empty);
                                        Console.Write("\n");
                                        toDoList.ForEach(item => Console.WriteLine(item));
                                    }

                                    if (menuSelectAction == ((char)MenuItemAction.TaskStop))
                                    {
                                        Console.WriteLine("Your Final To-Do List for Today: ");
                                        Console.Write("\n");
                                        toDoList.ForEach(task => Console.WriteLine(task));
                                        break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }

                                if (toDoList.Count == maxTasksForToday)
                                {
                                    Console.WriteLine("\nEnough! 10 Tasks - Maximum for Today!");
                                }
                            }
                            break;
                        case MenuItem.TaskChange:
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter the name of the task you want to modify: ");
                                    var indexOfTheTaskChange = toDoList.IndexOf(Console.ReadLine() ?? string.Empty);
                                    const int indexOutOfRange = -1;

                                    if (indexOfTheTaskChange == indexOutOfRange)
                                    {
                                        throw new Exception("Ошибка! Введено не правильное название дела! Попробуйте еще раз:");
                                    }

                                    Console.WriteLine("Enter the new name of the task you modified: ");
                                    var newNameOfTheTask = Console.ReadLine() ?? string.Empty;
                                    toDoList[indexOfTheTaskChange] = newNameOfTheTask;
                                    Console.Write("\n");
                                    toDoList.ForEach(task => Console.WriteLine(task));

                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"\nIf You want to Change more Tasks: Press: {(char)MenuItemAction.TaskContinue} \nIf You want to Stop Changing Tasks: Press {(char)MenuItemAction.TaskStop}");
                                            var menuSelectAction = (char)Console.Read();
                                            Console.ReadLine();
                                            var currentSelectAction = (MenuItemAction)menuSelectAction;

                                            if (menuSelectAction != ((char)MenuItemAction.TaskContinue) && menuSelectAction != ((char)MenuItemAction.TaskStop))
                                            {
                                                throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                                            }

                                            if (menuSelectAction == ((char)MenuItemAction.TaskContinue))
                                            {
                                                Console.WriteLine("Please share what other task you would like to change today: ");
                                                var newIndexOfTheTaskChange = toDoList.IndexOf(Console.ReadLine() ?? string.Empty);

                                                if (newIndexOfTheTaskChange == indexOutOfRange)
                                                {
                                                    throw new Exception("Ошибка! Введено не правильное название дела! Попробуйте еще раз:");
                                                }

                                                Console.WriteLine("Enter the new name of the task you modified: ");
                                                var newNameOfTheTaskMore = Console.ReadLine() ?? string.Empty;
                                                toDoList[newIndexOfTheTaskChange] = newNameOfTheTaskMore;
                                                Console.Write("\n");
                                                toDoList.ForEach(task => Console.WriteLine(task));
                                            }

                                            if (menuSelectAction == ((char)MenuItemAction.TaskStop))
                                            {
                                                Console.WriteLine("Your Final To-Do List for Today: ");
                                                Console.Write("\n");
                                                toDoList.ForEach(task => Console.WriteLine(task));
                                                break;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }
                                    if (indexOfTheTaskChange == indexOutOfRange)
                                    {
                                        continue;
                                    }

                                    if (indexOfTheTaskChange != indexOutOfRange)
                                    {
                                        break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                        case MenuItem.TaskDelete:
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter the name of the task you want to delete: ");
                                    var indexOfTheTaskDelete = toDoList.IndexOf(Console.ReadLine() ?? string.Empty);
                                    const int indexOutOfRange = -1;
                                    const int minToDoListCount = 0;

                                    if (indexOfTheTaskDelete == indexOutOfRange)
                                    {
                                        throw new Exception("Ошибка! Введено не правильное название дела! Попробуйте еще раз:");
                                    }

                                    toDoList.RemoveAt(indexOfTheTaskDelete);
                                    Console.Write("\n");
                                    toDoList.ForEach(task => Console.WriteLine(task));

                                    while (true)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"\nIf You want to Delete more Tasks: Press: {(char)MenuItemAction.TaskContinue} \nIf You want to Stop Deleting Tasks: Press {(char)MenuItemAction.TaskStop}");
                                            var menuSelectAction = (char)Console.Read();
                                            Console.ReadLine();
                                            var currentSelectAction = (MenuItemAction)menuSelectAction;

                                            if (menuSelectAction != ((char)MenuItemAction.TaskContinue) && menuSelectAction != ((char)MenuItemAction.TaskStop))
                                            {
                                                throw new Exception("Ошибка! Введен не правильный символ или Вы вообще не ввели символ! Попробуйте еще раз: ");
                                            }

                                            if (menuSelectAction == ((char)MenuItemAction.TaskContinue))
                                            {
                                                Console.WriteLine("Please share what other task you would like to delete today: ");
                                                var newIndexOfTheTaskDelete = toDoList.IndexOf(Console.ReadLine() ?? string.Empty);

                                                if (newIndexOfTheTaskDelete == indexOutOfRange)
                                                {
                                                    throw new Exception("Ошибка! Введено не правильное название дела! Попробуйте еще раз:");
                                                }

                                                toDoList.RemoveAt(newIndexOfTheTaskDelete);
                                                Console.Write("\n");
                                                toDoList.ForEach(task => Console.WriteLine(task));
                                            }

                                            if (menuSelectAction == ((char)MenuItemAction.TaskStop))
                                            {
                                                Console.WriteLine("Your Final To-Do List for Today: ");
                                                Console.Write("\n");
                                                toDoList.ForEach(task => Console.WriteLine(task));
                                                break;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }

                                        if (toDoList.Count == minToDoListCount)
                                        {
                                            Console.WriteLine("Дааааа.... никаких дел на сегодня!");
                                            break;
                                        }
                                    }
                                    if (indexOfTheTaskDelete == indexOutOfRange)
                                    {
                                        continue;
                                    }

                                    if (indexOfTheTaskDelete != indexOutOfRange)
                                    {
                                        break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            break;
                    }
                    if (menuSelect == ((char)MenuItem.TaskAdd) || menuSelect == ((char)MenuItem.TaskChange) || menuSelect == ((char)MenuItem.TaskDelete))
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}