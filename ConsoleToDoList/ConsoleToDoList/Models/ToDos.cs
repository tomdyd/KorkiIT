using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Models
{
    public class ToDos
    {
        public int Id { get; set; }
        public string? Task { get; set; }
        public TaskStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nZadanie: {Task}\nStatus: {Status}";
        }
    }
}
