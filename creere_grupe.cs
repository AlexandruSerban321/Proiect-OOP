using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class creere_grupe : Form
    {
        public creere_grupe()
        {
            InitializeComponent();
        }

        private void creere_grupe_Load(object sender, EventArgs e)
        {

        }

        /*afisez in 4 coloane studentii pe grupe, in principiu ar mai fi de pus in iste fisiere,
         fiecare grupa separat.
        codul este pentru a testa un numar mic de date*/
        private void button1_Click(object sender, EventArgs e)
        {
            student repartitie = new student();

            repartitie.rememorare();


            for(int i = 0;i<=repartitie.Numar_studenti-1;i++)
            {
                if(i<=1)
                {
                    richTextBox1.Text = richTextBox1.Text + repartitie.get_cod_student(i);
                    Console.Write(repartitie.get_cod_student(i));
                    richTextBox1.Text = richTextBox1.Text+"\n";
                }

                if(i>=2&&i<=3)
                {
                    richTextBox2.Text = richTextBox2.Text + repartitie.get_cod_student(i);
                    richTextBox2.Text = richTextBox2.Text + "\n";
                }

                if(i>=4&&i<=5)
                {
                    richTextBox3.Text = richTextBox3.Text + repartitie.get_cod_student(i);
                    richTextBox3.Text = richTextBox3.Text + "\n";
                }

                if(i>=6&&i<=7)
                {
                    richTextBox4.Text = richTextBox4.Text + repartitie.get_cod_student(i);
                    richTextBox4.Text = richTextBox4.Text + "\n";
                }

            }



        }
    }
}
