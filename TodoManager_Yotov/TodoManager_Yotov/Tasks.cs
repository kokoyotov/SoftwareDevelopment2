using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TodoManager_Yotov
{
    internal class Tasks
    {
        public int Id { get; set; }
        public string Title { get
            {
                return Title;
            } set 
            {
                if(string.IsNullOrEmpty(Title))
                    throw new ArgumentNullException("Title is mandatory");
            } 
        }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public Tasks(int id,string title, string description, DateTime dueDate)
        {
            if(id<=0)
                 throw new ArgumentOutOfRangeException("Id should be positive");

            if(string.IsNullOrEmpty(title)) 
                throw new ArgumentNullException("Title is mandatory");

            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false; 
        }
    }
}
