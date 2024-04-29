﻿using IssueTicketingSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueTicketingSystem
{
    public partial class DeveloperManagementForm : Form
    {
        public List<Developer> developers;

        private void showDevelopers()
        {
            lvDevelopers.Items.Clear();
            
            foreach(Developer developer in developers )
            {
                ListViewItem item = new ListViewItem(developer.DeveloperName);
                item.SubItems.Add(developer.HireDate.ToString());
                item.SubItems.Add(developer.Email);
                item.SubItems.Add(developer.Position.ToString());
                item.Tag = developer;
                lvDevelopers.Items.Add(item);
            }
        }
        public DeveloperManagementForm()
        {
            InitializeComponent();
        }

        private void DeveloperManagementForm_Load(object sender, EventArgs e)
        {
            showDevelopers();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ADDING METHODS
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEditDeveloperForm form = new AddEditDeveloperForm();
            Developer developer = new Developer();
            form.developer = developer;
            if (form.ShowDialog() == DialogResult.OK)
            {
                developers.Add(developer);
                showDevelopers();
            }
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            addToolStripMenuItem1_Click(sender, e);
        }
        //EDITING METHODS
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(lvDevelopers.SelectedItems.Count > 0)
            {
                AddEditDeveloperForm form = new AddEditDeveloperForm();
                form.developer = lvDevelopers.SelectedItems[0].Tag as Developer;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    showDevelopers();
                }
            }
            else
            {
                MessageBox.Show("No developer selected", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvDevelopers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editToolStripMenuItem1_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editToolStripMenuItem1_Click(sender, e);
        }
        //DELETING METHODS
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvDevelopers.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete developer?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    developers.Remove(lvDevelopers.SelectedItems[0].Tag as Developer);
                    showDevelopers();
                }
            }
            else
            {
                MessageBox.Show("No developer selected", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem1_Click(sender, e);
        }

        //FILE SERIALIZATION/DESERIALIZATION
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(developers.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using(FileStream fs = File.Create(saveFileDialog.FileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, developers);
                    }
                }
                MessageBox.Show("Developer list saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No developers added", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(developers.Count > 0)
            {
                var result = MessageBox.Show("Added developers will be lost. Continue?", "Attention!"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    developers.Clear();
                }
            }
            if(developers.Count == 0) 
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = File.OpenRead(openFileDialog.FileName))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        developers = bf.Deserialize(fs) as List<Developer>;
                        showDevelopers();
                    }
                }
            }
        }
    }
}
