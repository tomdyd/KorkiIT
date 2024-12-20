using ConsoleToDoList.Interfaces;
using ConsoleToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleToDoList.TaskStatus;

namespace ConsoleToDoList.Services
{
    public class FileHandler : IFileHandler
    {
        private readonly string _path;
        private int _lineNumber;

        public FileHandler()
        {
            _path = Path.Combine(Directory.GetCurrentDirectory(), "ToDoList.txt");
            _lineNumber = 0;
        }
        public async void AddTask(string Task)
        {
            int index = await SetIndex();

            using var sw = new StreamWriter(_path, true);
            var toDos = new ToDos
            {
                Id = index + 1,
                Task = Task,
                Status = Waiting
            };

            await sw.WriteLineAsync(toDos.Id.ToString());
            await sw.WriteLineAsync(toDos.Task);
            await sw.WriteLineAsync(toDos.Status.ToString());
            await sw.WriteLineAsync();
        }
        public async Task<int> SetIndex()
        {
            int index = 0;
            using (var sr = new StreamReader(_path))
            {
                string? line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    if (_lineNumber % 4 == 0)
                    {
                        index = int.Parse(line);
                    }
                    _lineNumber++;
                }
            }

            return index;
        }
        public List<ToDos> ReadTasks()
        {
            var toDosList = new List<ToDos>();
            var data = new List<string>();

            using (var sr = new StreamReader(_path))
            {
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    data.Add(line);
                }

                for (int i = 0; i < data.Count; i += 4)
                {
                    var toDo = new ToDos
                    {
                        Id = int.Parse(data[i]),
                        Task = data[i + 1],
                        Status = Enum.Parse<TaskStatus>(data[i + 2])
                    };

                    toDosList.Add(toDo);
                }
            }
            return toDosList;
        }
        public void PrintTasks()
        {
            var toDos = ReadTasks();
            Console.Clear();
            foreach (var todo in toDos)
            {
                Console.WriteLine(todo.ToString());
                Console.WriteLine();
            }
        }
        public void PrintTasks(TaskStatus status)
        {
            var toDos = ReadTasks();
            Console.Clear();
            foreach (var todo in toDos)
            {
                if (todo.Status == status)
                {
                    Console.WriteLine(todo.ToString());
                    Console.WriteLine();
                }
            }
        }
        public void ModifyTasks(int id, Action<ToDos> modifyAction)
        {
            var toDos = ReadTasks();

            using var sw = new StreamWriter(_path);
            for (int i = 0; i < toDos.Count; i++)
            {
                if (toDos[i].Id == id)
                {
                    modifyAction(toDos[i]);
                }

                sw.WriteLine(toDos[i].Id.ToString());
                sw.WriteLine(toDos[i].Task);
                sw.WriteLine(toDos[i].Status.ToString());
                sw.WriteLine();
            }
        }
        public void ChangeStatus(int id, TaskStatus status)
        {
            ModifyTasks(id, task => task.Status = status);
        }
        public void ChangeTask(int id, string content)
        {
            ModifyTasks(id, task => task.Task = content);
        }
        public void DeleteTask(int id)
        {
            var toDos = ReadTasks();

            using var sw = new StreamWriter(_path);
            foreach (var task in toDos)
            {
                if (task.Id != id)
                {
                    sw.WriteLine(task.Id.ToString());
                    sw.WriteLine(task.Task);
                    sw.WriteLine(task.Status.ToString());
                    sw.WriteLine();
                }
            }
        }

    }
}
