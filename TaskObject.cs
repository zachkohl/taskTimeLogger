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
 public class MyTask
    {
        private string description;
        private string stringStartTime;
        private DateTime taskStartTime;

        public MyTask(string Description, string stringStartTime, DateTime TaskStartTime)
        {//constructor
            this.description = Description;
            this.StringStartTime = stringStartTime;
            this.TaskStartTime = TaskStartTime;
        }

        //The publically accessible properities

    public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public string StringStartTime
        {
            get => stringStartTime;
            set
            {
                stringStartTime = value;
            }
        }

        public DateTime TaskStartTime
        {
            get
            {
                return taskStartTime;
            }
            set
            {
                taskStartTime = value;
            }
        }



    }// end class MyTask
}//end namespace TaskTime Logger