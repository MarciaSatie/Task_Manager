namespace Task_App
{
    partial class TaskApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgTaskList = new DataGridView();
            TaskView = new DataGridViewTextBoxColumn();
            Priority = new DataGridViewTextBoxColumn();
            Finishing_Date = new DataGridViewTextBoxColumn();
            lbTaskDescription = new Label();
            txtTaskDescription = new TextBox();
            lbPriority = new Label();
            lbFinishingDate = new Label();
            cbPriority = new ComboBox();
            dtFinishingDate = new DateTimePicker();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTaskList).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgTaskList
            // 
            dgTaskList.AllowUserToOrderColumns = true;
            dgTaskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTaskList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgTaskList.BackgroundColor = SystemColors.ActiveCaption;
            dgTaskList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTaskList.Columns.AddRange(new DataGridViewColumn[] { TaskView, Priority, Finishing_Date });
            dgTaskList.Dock = DockStyle.Bottom;
            dgTaskList.Location = new Point(0, 293);
            dgTaskList.Name = "dgTaskList";
            dgTaskList.RowHeadersWidth = 82;
            dgTaskList.Size = new Size(1688, 303);
            dgTaskList.TabIndex = 1;
            dgTaskList.UseWaitCursor = true;
            // 
            // Task
            // 
            TaskView.HeaderText = "Task";
            TaskView.MinimumWidth = 10;
            TaskView.Name = "Task";
            // 
            // Priority
            // 
            Priority.HeaderText = "Priority";
            Priority.MinimumWidth = 10;
            Priority.Name = "Priority";
            // 
            // Finishing_Date
            // 
            Finishing_Date.HeaderText = "Finishing_Date";
            Finishing_Date.MinimumWidth = 10;
            Finishing_Date.Name = "Finishing_Date";
            // 
            // lbTaskDescription
            // 
            lbTaskDescription.AutoSize = true;
            lbTaskDescription.Location = new Point(12, 9);
            lbTaskDescription.Name = "lbTaskDescription";
            lbTaskDescription.Size = new Size(191, 32);
            lbTaskDescription.TabIndex = 2;
            lbTaskDescription.Text = "Task Description:";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(209, 2);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(601, 39);
            txtTaskDescription.TabIndex = 3;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(12, 60);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(94, 32);
            lbPriority.TabIndex = 4;
            lbPriority.Text = "Priority:";
            // 
            // lbFinishingDate
            // 
            lbFinishingDate.AutoSize = true;
            lbFinishingDate.Location = new Point(12, 110);
            lbFinishingDate.Name = "lbFinishingDate";
            lbFinishingDate.Size = new Size(172, 32);
            lbFinishingDate.TabIndex = 5;
            lbFinishingDate.Text = "Finishing Date:";
            // 
            // cbPriority
            // 
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "urgent and important, ", "important but not urgent, ", "urgent but not important, ", "neither urgent nor important." });
            cbPriority.Location = new Point(209, 57);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(430, 40);
            cbPriority.TabIndex = 6;
            cbPriority.Text = "neither urgent nor important.";
            // 
            // dtFinishingDate
            // 
            dtFinishingDate.Location = new Point(212, 120);
            dtFinishingDate.Name = "dtFinishingDate";
            dtFinishingDate.Size = new Size(400, 39);
            dtFinishingDate.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 255, 128);
            btnAdd.ForeColor = Color.Olive;
            btnAdd.Location = new Point(12, 178);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(229, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // TaskApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 596);
            Controls.Add(btnAdd);
            Controls.Add(dtFinishingDate);
            Controls.Add(cbPriority);
            Controls.Add(lbFinishingDate);
            Controls.Add(lbPriority);
            Controls.Add(txtTaskDescription);
            Controls.Add(lbTaskDescription);
            Controls.Add(dgTaskList);
            Name = "TaskApp";
            Text = "Task Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgTaskList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgTaskList;
        private DataGridViewTextBoxColumn TaskView;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Finishing_Date;
        private Label lbTaskDescription;
        private TextBox txtTaskDescription;
        private Label lbPriority;
        private Label lbFinishingDate;
        private ComboBox cbPriority;
        private DateTimePicker dtFinishingDate;
        private Button btnAdd;
    }
}
