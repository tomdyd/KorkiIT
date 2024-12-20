using ConsoleToDoList.Models;
using ConsoleToDoList.Services;

namespace ConsoleToDoList.Interfaces
{
    public interface IFileHandler
    {
        void AddTask(string Task);
        Task<int> SetIndex();
        List<ToDos> ReadTasks();
        void PrintTasks();
        void PrintTasks(TaskStatus status);
        void ModifyTasks(int id, Action<ToDos> modifyAction);
        void ChangeStatus(int id, TaskStatus status);
        void ChangeTask(int id, string content);
        void DeleteTask(int id);
        
    }
}