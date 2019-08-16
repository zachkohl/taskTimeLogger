using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace taskTimeLogger
{
    public partial class taskLoggerForm : Form
    {
        TaskList taskList = new TaskList();
        string path;
        public taskLoggerForm()
        {
            InitializeComponent();
        }

        private void StartTask_Click(object sender, EventArgs e)
        {
            ManageTask();
        }

        private void StartTask_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode == Keys.Enter)
            {
                ManageTask();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
         
        }

        private void ManageTask()
        {
            Console.WriteLine(taskEntry.Text);
            //build variables
            string TaskName = taskEntry.Text;
            DateTime TaskStartTime = DateTime.Now;
            string StringTaskStartTime = TaskStartTime.ToString(" dd MMMM yyyy hh:mm:ss tt");
            Console.WriteLine(StringTaskStartTime);
            //   build an opject
            MyTask currentTask = new MyTask(TaskName, StringTaskStartTime, TaskStartTime);

            //Add to the CSV file and then add to the in memory list
            try
            {
                string textToAppend = currentTask.Description + ',' + currentTask.StringStartTime + Environment.NewLine;
                File.AppendAllText(path, textToAppend);
                taskList.Add(currentTask);
            }
            catch
            {
                MessageBox.Show("It appears you have the CSV file open in another program or have not specified a correct file location yet", "File in use or not there error");
            }

            //update the listview
            listView1.Items.Clear();

            //sort the list
           taskList.Sort();
           taskList.Reverse();
            for (int i = 0; i < taskList.Count; i++)
            {
                MyTask taskItem = taskList.GetTaskByIndex(i);
                ListViewItem itemForView = new ListViewItem(taskItem.Description);
                itemForView.SubItems.Add(taskItem.StringStartTime);
                listView1.Items.Add(itemForView);
            }//end for loop


            //clear the textbox
            taskEntry.Clear();


   




        }

        private void InitializeFilePath_Click(object sender, EventArgs e)
        {
            string pathName = filePathValue.Text;
            path = pathName;
            this.initializedStatus.Text = "pointing to CSV file: " + pathName;

        }
    }


   

}
