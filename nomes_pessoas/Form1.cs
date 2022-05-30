using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nomes_pessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cb_sex.Items.Add("Masculino");
            cb_sex.Items.Add("Feminino");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sexo = cb_sex.Text.ToString();
            string nome = textBox1.Text;




            switch (sexo)
            {

                case "Feminino":
                    lb_result.Text = "Ilma. Sra. " + nome;
                        break;

                case "Masculino":
                    lb_result.Text = "Ilmo. Sr. " + nome;
                    break;



            }
            


        }
    }
}
