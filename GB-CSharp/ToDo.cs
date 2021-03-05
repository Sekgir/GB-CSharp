using System;
using System.Collections.Generic;
using System.Text;

namespace GB_CSharp
{
    [Serializable]
    class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo() { }
        public ToDo(string title)
        {
            Title = title;
        }
        public ToDo(string title, bool isDone)
        {
            Title = title;
            IsDone = isDone;
        }

    }
}
