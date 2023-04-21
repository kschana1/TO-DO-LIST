using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Load the to-do list from the text file on launch
            if (File.Exists("list.txt"))
            {
                string[] lines = File.ReadAllLines("list.txt");
                taskListBox.Items.AddRange(lines);
            }

            if (File.Exists("complist.txt"))
            {
                string[] lines = File.ReadAllLines("complist.txt");
                completedTasksListBox.Items.AddRange(lines);
            }


            autosave.Enabled = true;


        }

        void add()
        {
            string task = taskTextBox.Text;

            if (!string.IsNullOrWhiteSpace(task))
            {
                taskListBox.Items.Add(task);
                taskTextBox.Clear();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            add();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                taskListBox.Items.RemoveAt(taskListBox.SelectedIndex);
            }

            if (completedTasksListBox.SelectedIndex != -1)
            {
                completedTasksListBox.Items.RemoveAt(completedTasksListBox.SelectedIndex);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            taskListBox.Items.Clear();
        }

        private void taskTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                add();
            }
        }

        void save()
        {
            // Save the to-do list to the text file
            using (StreamWriter writer = new StreamWriter("list.txt"))
            {
                foreach (string item in taskListBox.Items)
                {
                    writer.WriteLine(item);
                }
            }

            using (StreamWriter writer = new StreamWriter("complist.txt"))
            {
                foreach (string item in completedTasksListBox.Items)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void autosave_Tick(object sender, EventArgs e)
        {

            save();
            

            
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            save();
        }

        private void toggle_Click(object sender, EventArgs e)
        {

            if (autosave.Enabled == true)
            {
                autosave.Enabled = false;
                label1.Text = "AutoSave Off";
            }
            else
            {
                autosave.Enabled = true;
                label1.Text = "AutoSave On";
            }
        }

        private void CompletedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            

            if (taskListBox.SelectedIndex != -1)
            {
                completedTasksListBox.Items.Add(taskListBox.Items[taskListBox.SelectedIndex].ToString());

                taskListBox.Items.RemoveAt(taskListBox.SelectedIndex);

                
            }


        }

        


        private void UpdateCompletedTasksListBox()
        {
           
        }

        private void clearButton2_Click(object sender, EventArgs e)
        {
            completedTasksListBox.Items.Clear();
        }

        private void clrall_Click(object sender, EventArgs e)
        {
            taskListBox.Items.Clear();
            completedTasksListBox.Items.Clear();
        }
    }
}
