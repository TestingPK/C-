using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
   

        }
private void DirSearch(string sDir)
    {
        try
        {
             string[] array1 = Directory.GetDirectories(@"c:\");
            {
                listBox1.Items.Add(d.Name);
            }
        }
        catch (System.Exception excpt)
        {
            MessageBox.Show(excpt.Message);
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
        
             string[] fileArray = Directory.GetDirectories(@"c:\");
           for (int i = 0; i < fileArray.Length; i++)
           {

               Console.WriteLine(fileArray[i]);
           }
            Console.ReadLine();
        }
    }

        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}





