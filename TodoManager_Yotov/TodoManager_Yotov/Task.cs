using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager_Yotov
{
    internal class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string description, string dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false; 
        }
    }
}
