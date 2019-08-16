namespace taskTimeLogger
{
    partial class taskLoggerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startTask = new System.Windows.Forms.Button();
            this.taskEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.filePathValue = new System.Windows.Forms.TextBox();
            this.initializeFilePath = new System.Windows.Forms.Button();
            this.initializedStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTask
            // 
            this.startTask.Location = new System.Drawing.Point(339, 23);
            this.startTask.Name = "startTask";
            this.startTask.Size = new System.Drawing.Size(75, 23);
            this.startTask.TabIndex = 1;
            this.startTask.Text = "log task";
            this.startTask.UseVisualStyleBackColor = true;
            this.startTask.Click += new System.EventHandler(this.StartTask_Click);
            // 
            // taskEntry
            // 
            this.taskEntry.AcceptsTab = true;
            this.taskEntry.Location = new System.Drawing.Point(24, 23);
            this.taskEntry.Name = "taskEntry";
            this.taskEntry.Size = new System.Drawing.Size(287, 20);
            this.taskEntry.TabIndex = 0;
            this.taskEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartTask_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.startTime});
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(24, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // startTime
            // 
            this.startTime.Text = "Start Time";
            this.startTime.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(111, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Previous Tasks";
            // 
            // filePathValue
            // 
            this.filePathValue.Location = new System.Drawing.Point(70, 221);
            this.filePathValue.Name = "filePathValue";
            this.filePathValue.Size = new System.Drawing.Size(375, 20);
            this.filePathValue.TabIndex = 2;
            this.filePathValue.Text = "C:\\Users\\Zach\\Desktop\\tasks.csv";
            // 
            // initializeFilePath
            // 
            this.initializeFilePath.Location = new System.Drawing.Point(468, 221);
            this.initializeFilePath.Name = "initializeFilePath";
            this.initializeFilePath.Size = new System.Drawing.Size(121, 23);
            this.initializeFilePath.TabIndex = 3;
            this.initializeFilePath.Text = "Initialize File Path";
            this.initializeFilePath.UseVisualStyleBackColor = true;
            this.initializeFilePath.Click += new System.EventHandler(this.InitializeFilePath_Click);
            // 
            // initializedStatus
            // 
            this.initializedStatus.AutoSize = true;
            this.initializedStatus.Location = new System.Drawing.Point(67, 255);
            this.initializedStatus.Name = "initializedStatus";
            this.initializedStatus.Size = new System.Drawing.Size(86, 13);
            this.initializedStatus.TabIndex = 8;
            this.initializedStatus.Text = "Not yet initialized";
            // 
            // taskLoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 301);
            this.Controls.Add(this.initializedStatus);
            this.Controls.Add(this.initializeFilePath);
            this.Controls.Add(this.filePathValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskEntry);
            this.Controls.Add(this.startTask);
            this.Name = "taskLoggerForm";
            this.RightToLeftLayout = true;
            this.Text = "TaskLogger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTask;
        private System.Windows.Forms.TextBox taskEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader startTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox filePathValue;
        private System.Windows.Forms.Button initializeFilePath;
        private System.Windows.Forms.Label initializedStatus;
    }
}

