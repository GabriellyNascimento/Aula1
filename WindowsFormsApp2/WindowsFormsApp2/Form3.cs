using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_opcao.Text = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Formulário 1") //ação para o botão do form3
            {
                Form1 form1 = new Form1();
                form1.Show();
                Visible = false;
            }

            if (comboBox1.Text == "Formulário 2")
            {
                Form2 form2 = new Form2();
                form2.Show();
                Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }
    }
}
