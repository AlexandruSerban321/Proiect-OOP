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

namespace proiect
{
    public partial class adaugare_student : Form
    {
        public adaugare_student()
        {
            InitializeComponent();
        }

        private void adaugare_student_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*se adauga studentii intr-o baza de date comuna, adica intr-un fisier comun*/
        private void button1_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter("student.txt");
            StreamWriter sw = File.AppendText("student.txt");
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            sw.WriteLine(textBox4.Text);
            sw.WriteLine(textBox5.Text);
            sw.WriteLine(textBox6.Text);
            sw.WriteLine(textBox7.Text);
            sw.WriteLine(textBox8.Text);
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            

        }
    }
}
