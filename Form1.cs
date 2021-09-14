using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace project_2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        dbaccess dbac = new dbaccess();
        OpenFileDialog open = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            showdata();
        }

        private void save_Click(object sender, EventArgs e)
        {
            filetransfer();
            try
            {
                dbac.saveData(int.Parse(id.Text.Trim()), name.Text, gender(), married(), idformat.Text, DateTime.Text);
            }
            catch
            {
                MessageBox.Show("Data insertion Error....!");
            }
            finally
            {
                showdata();
            }
        }

        private void viewall_Click(object sender, EventArgs e)
        {
            try
            {
                showdata();
            }
            catch
            {
                MessageBox.Show("Data Retrieval Error....!");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                searchdata();
            }
            catch
            {
                MessageBox.Show("Data Search Errpr.....!");
            }

        }

        private void clearall_Click(object sender, EventArgs e)
        {
            id.Text = "";
            name.Text = "";
            male.Checked = false;
            female.Checked = false;
            yes.Checked = false;
            idformat.Text = "";
            filenamebox.Text = "";
            pictureBox1.Image = null;
        }

        private void viewReport_Click(object sender, EventArgs e)
        {
            showData sd = new showData();
            sd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                fileshow();
            }
            catch
            {
                MessageBox.Show("File Error.......!");
            }

        }

        private string gender()
        {
            if (male.Checked)
            {
                return "Male";
            }
            else
            {
                return "Female";
            }
        }

        private string married()
        {
            if (yes.Checked)
            {
                return "Married";
            }
            else
            {
                return "Not Married";
            }
        }

        private void showdata()
        {
            using (dbEntities db = new dbEntities())
            {
                metroGrid1.DataSource = db.interntbls.ToList<interntbl>();
            }
        }

        private void searchdata()
        {
            using (dbEntities db = new dbEntities())
            {
                metroGrid1.DataSource = db.interntbls.Where(model => model.name == searchbox.Text).ToList();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
        }

        private void fileshow()
        {
            if (open.ShowDialog() == DialogResult.OK)
            {
                filenamebox.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }
        private void filetransfer()
        {
            string location = (string)filenamebox.Text;
            string dir = @"C:\Users\Isuru\source\repos\project 2\project 2\Images\".Replace(" % location%", location);
            string filename = "Information.jpg";
            string fullPath = Path.Combine(dir, filename);
        }
    }
}

