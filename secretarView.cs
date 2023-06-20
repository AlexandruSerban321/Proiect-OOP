using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class secretarView : Form
    {
        public secretarView()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            adaugare_student ads = new adaugare_student();
            ads.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creere_grupe crg = new creere_grupe();
            crg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 LoginForm = new Form2();
            LoginForm.Show();
        }
    }
}
