using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskTimeLogger
{
    public class TaskList
    {
        private List<MyTask> tasks;

        public TaskList()
        {
            tasks = new List<MyTask>();
        }

        public int Count => tasks.Count;

        public void Add(MyTask task)
        {
            tasks.Add(task);
        }

        public MyTask GetTaskByIndex(int i) => tasks[i];

        public void Remove(MyTask task)
        {
            tasks.Remove(task);
        }

        public void Sort()
        {
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.8
            tasks.Sort(delegate (MyTask x, MyTask y)
            {
                return DateTime.Compare(x.TaskStartTime,y.TaskStartTime);
            });
           
        }

        public void Reverse()
        {
            tasks.Reverse();
        }


        //later we will add more code that will handle persistance. 



    }// end class TaskList
}//end namespace TaskTime Logger