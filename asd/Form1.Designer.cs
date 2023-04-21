namespace asd
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.autosave = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toggle = new System.Windows.Forms.Button();
            this.completedButton = new System.Windows.Forms.Button();
            this.completedTasksListBox = new System.Windows.Forms.ListBox();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.clrall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // autosave
            // 
            this.autosave.Tick += new System.EventHandler(this.autosave_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To Do List";
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.Location = new System.Drawing.Point(12, 34);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(262, 316);
            this.taskListBox.TabIndex = 0;
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(279, 35);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(154, 20);
            this.taskTextBox.TabIndex = 1;
            this.taskTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.taskTextBox_KeyDown);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.IndianRed;
            this.addButton.Location = new System.Drawing.Point(280, 61);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(153, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.IndianRed;
            this.removeButton.Location = new System.Drawing.Point(280, 117);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(153, 56);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "rem";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.IndianRed;
            this.clearButton.Location = new System.Drawing.Point(11, 356);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(263, 30);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "clr";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.IndianRed;
            this.savebtn.Location = new System.Drawing.Point(554, 293);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(89, 57);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save Button";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(707, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "AutoSave On";
            // 
            // toggle
            // 
            this.toggle.BackColor = System.Drawing.Color.IndianRed;
            this.toggle.Location = new System.Drawing.Point(693, 35);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(98, 23);
            this.toggle.TabIndex = 7;
            this.toggle.Text = "Autosave toggler";
            this.toggle.UseVisualStyleBackColor = false;
            this.toggle.Click += new System.EventHandler(this.toggle_Click);
            // 
            // completedButton
            // 
            this.completedButton.BackColor = System.Drawing.Color.IndianRed;
            this.completedButton.Location = new System.Drawing.Point(280, 179);
            this.completedButton.Name = "completedButton";
            this.completedButton.Size = new System.Drawing.Size(153, 57);
            this.completedButton.TabIndex = 9;
            this.completedButton.Text = "Completed";
            this.completedButton.UseVisualStyleBackColor = false;
            this.completedButton.Click += new System.EventHandler(this.completedButton_Click);
            // 
            // completedTasksListBox
            // 
            this.completedTasksListBox.FormattingEnabled = true;
            this.completedTasksListBox.Location = new System.Drawing.Point(554, 88);
            this.completedTasksListBox.Name = "completedTasksListBox";
            this.completedTasksListBox.Size = new System.Drawing.Size(198, 199);
            this.completedTasksListBox.TabIndex = 11;
            // 
            // clearButton2
            // 
            this.clearButton2.BackColor = System.Drawing.Color.IndianRed;
            this.clearButton2.Location = new System.Drawing.Point(649, 293);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(86, 57);
            this.clearButton2.TabIndex = 12;
            this.clearButton2.Text = "clr";
            this.clearButton2.UseVisualStyleBackColor = false;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // clrall
            // 
            this.clrall.BackColor = System.Drawing.Color.IndianRed;
            this.clrall.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.clrall.Location = new System.Drawing.Point(346, 334);
            this.clrall.Name = "clrall";
            this.clrall.Size = new System.Drawing.Size(135, 52);
            this.clrall.TabIndex = 13;
            this.clrall.Text = "Clear all";
            this.clrall.UseVisualStyleBackColor = false;
            this.clrall.Click += new System.EventHandler(this.clrall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(554, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Completed Tasks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(804, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clrall);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.completedTasksListBox);
            this.Controls.Add(this.completedButton);
            this.Controls.Add(this.toggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.taskListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer autosave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toggle;
        private System.Windows.Forms.Button completedButton;
        private System.Windows.Forms.ListBox completedTasksListBox;
        private System.Windows.Forms.Button clearButton2;
        private System.Windows.Forms.Button clrall;
        private System.Windows.Forms.Label label3;
    }
}

