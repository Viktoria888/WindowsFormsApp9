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

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter textfile;
            FileInfo file = new FileInfo("C:\\Users\\USER\\Desktop\\1.txt"); 

            textfile = file.AppendText();
            textfile.WriteLine(textBox1);
            textfile.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader textfile = new StreamReader("C:\\Users\\USER\\Desktop\\1.txt");
            string a = "";
            while (!textfile.EndOfStream)
            {
                a = textfile.ReadLine();
            }
            label1.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openFileDialog1.FileName);

                string[] textMass;
                string text = File.ReadAllText(openFileDialog1.FileName);
                textMass = text.Split(' ');
                string a = Convert.ToString(textMass.Length);
                MessageBox.Show(a);

                stream.Close();
            }
        }
    }
}


//string text = File.ReadAllText(openFileDialog1.FileName);
//int a = 1;
               // foreach(char word in text)
               // {

                  //  if (word == ' ')
                  //  {
                  //      ;
                  //  }
                   // string b = Convert.ToString(a);
//MessageBox.Show(b); 

              //  }