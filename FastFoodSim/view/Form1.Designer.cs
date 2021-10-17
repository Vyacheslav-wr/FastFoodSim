namespace FastFoodSim
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.customerNumLabel = new System.Windows.Forms.Label();
            this.customerNumTextBox = new System.Windows.Forms.TextBox();
            this.readyPanel = new System.Windows.Forms.Panel();
            this.readyQueueLabel = new System.Windows.Forms.Label();
            this.inLinePanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Order_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inLineQueueLabel = new System.Windows.Forms.Label();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.inProgressTextBox = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readyPanel.SuspendLayout();
            this.inLinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(16, 498);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(151, 498);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 28);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(16, 457);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(99, 22);
            this.customerTextBox.TabIndex = 2;
            this.customerTextBox.TextChanged += new System.EventHandler(this.customerTextBox_TextChanged);
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(151, 455);
            this.orderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(99, 22);
            this.orderTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(17, 433);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(89, 17);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "customer int.";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(151, 432);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(105, 17);
            this.orderLabel.TabIndex = 5;
            this.orderLabel.Text = "order fulfil. time";
            // 
            // customerNumLabel
            // 
            this.customerNumLabel.AutoSize = true;
            this.customerNumLabel.Location = new System.Drawing.Point(17, 16);
            this.customerNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNumLabel.Name = "customerNumLabel";
            this.customerNumLabel.Size = new System.Drawing.Size(181, 17);
            this.customerNumLabel.TabIndex = 6;
            this.customerNumLabel.Text = "Number of customer in line:";
            // 
            // customerNumTextBox
            // 
            this.customerNumTextBox.Location = new System.Drawing.Point(21, 37);
            this.customerNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerNumTextBox.Name = "customerNumTextBox";
            this.customerNumTextBox.ReadOnly = true;
            this.customerNumTextBox.Size = new System.Drawing.Size(104, 22);
            this.customerNumTextBox.TabIndex = 7;
            // 
            // readyPanel
            // 
            this.readyPanel.Controls.Add(this.listView2);
            this.readyPanel.Controls.Add(this.readyQueueLabel);
            this.readyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.readyPanel.Location = new System.Drawing.Point(720, 0);
            this.readyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.readyPanel.Name = "readyPanel";
            this.readyPanel.Size = new System.Drawing.Size(333, 542);
            this.readyPanel.TabIndex = 8;
            // 
            // readyQueueLabel
            // 
            this.readyQueueLabel.AutoSize = true;
            this.readyQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readyQueueLabel.Location = new System.Drawing.Point(100, 16);
            this.readyQueueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readyQueueLabel.Name = "readyQueueLabel";
            this.readyQueueLabel.Size = new System.Drawing.Size(128, 25);
            this.readyQueueLabel.TabIndex = 0;
            this.readyQueueLabel.Text = "Ready queue";
            // 
            // inLinePanel
            // 
            this.inLinePanel.Controls.Add(this.listView1);
            this.inLinePanel.Controls.Add(this.inLineQueueLabel);
            this.inLinePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inLinePanel.Location = new System.Drawing.Point(387, 0);
            this.inLinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.inLinePanel.Name = "inLinePanel";
            this.inLinePanel.Size = new System.Drawing.Size(333, 542);
            this.inLinePanel.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order_ID,
            this.User_Name});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(291, 482);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Order_ID
            // 
            this.Order_ID.Text = "Order_ID";
            this.Order_ID.Width = 93;
            // 
            // User_Name
            // 
            this.User_Name.Text = "User_Name";
            this.User_Name.Width = 95;
            // 
            // inLineQueueLabel
            // 
            this.inLineQueueLabel.AutoSize = true;
            this.inLineQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inLineQueueLabel.Location = new System.Drawing.Point(107, 16);
            this.inLineQueueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inLineQueueLabel.Name = "inLineQueueLabel";
            this.inLineQueueLabel.Size = new System.Drawing.Size(123, 25);
            this.inLineQueueLabel.TabIndex = 0;
            this.inLineQueueLabel.Text = "In line queue";
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inProgressLabel.Location = new System.Drawing.Point(21, 203);
            this.inProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(151, 20);
            this.inProgressLabel.TabIndex = 10;
            this.inProgressLabel.Text = "Order  in progress:";
            // 
            // inProgressTextBox
            // 
            this.inProgressTextBox.Location = new System.Drawing.Point(25, 229);
            this.inProgressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inProgressTextBox.Name = "inProgressTextBox";
            this.inProgressTextBox.ReadOnly = true;
            this.inProgressTextBox.Size = new System.Drawing.Size(100, 22);
            this.inProgressTextBox.TabIndex = 11;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(38, 44);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(264, 482);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order_ID";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User_Name";
            this.columnHeader2.Width = 113;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 542);
            this.Controls.Add(this.inProgressTextBox);
            this.Controls.Add(this.inProgressLabel);
            this.Controls.Add(this.inLinePanel);
            this.Controls.Add(this.readyPanel);
            this.Controls.Add(this.customerNumTextBox);
            this.Controls.Add(this.customerNumLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.readyPanel.ResumeLayout(false);
            this.readyPanel.PerformLayout();
            this.inLinePanel.ResumeLayout(false);
            this.inLinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label customerNumLabel;
        private System.Windows.Forms.TextBox customerNumTextBox;
        private System.Windows.Forms.Panel readyPanel;
        private System.Windows.Forms.Label readyQueueLabel;
        private System.Windows.Forms.Panel inLinePanel;
        private System.Windows.Forms.Label inLineQueueLabel;
        private System.Windows.Forms.Label inProgressLabel;
        private System.Windows.Forms.TextBox inProgressTextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Order_ID;
        private System.Windows.Forms.ColumnHeader User_Name;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

