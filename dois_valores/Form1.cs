using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dois_valores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_valor01.Text == "" || txt_valor02.Text == "")
            {
                MessageBox.Show("PREENCHER OS CAMPOS CORRETAMENTE", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int valor01 = Convert.ToInt32(txt_valor01.Text);
                int valor02 = Convert.ToInt32(txt_valor02.Text);
                int diference;


                diference = valor01 - valor02;



                if (valor01 > valor02)
                {
                    diference = valor01 - valor02;
                    txt_result.Text = diference.ToString();


                }
                else
                {
                    diference = valor02 - valor01;
                    txt_result.Text = diference.ToString();


                }









            }



        }
    }
}
