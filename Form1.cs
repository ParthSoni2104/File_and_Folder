using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_File_Copy_Source_To_Destination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        public void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            textBox1.Text = folderBrowserDialog1.SelectedPath;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            textBox2.Text = folderBrowserDialog1.SelectedPath;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sourcePath = textBox1.Text;
            string destinationPath = textBox2.Text;

            string[] allSourceDirectories = Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories);

            foreach(string dirpath in allSourceDirectories)
            {
                Directory.CreateDirectory(dirpath.Replace(sourcePath, destinationPath));
            }

            string[] allSourceDirectoriesFile = Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories);

            foreach(string filepath in allSourceDirectoriesFile)
            {
                File.Copy(filepath, filepath.Replace(sourcePath, destinationPath), true);
            }

            MessageBox.Show("Copy Successfully");

            System.Environment.Exit(0);
           
            
            
        }
    }
}
