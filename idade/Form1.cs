using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_idad.Text != "")
            {


                int idade = Convert.ToInt32(txt_idad.Text);

                if(idade >= 18)
                {

                    lb_result.Text = "PERMISSÃO CONCEDIDA";
                    lb_result.ForeColor = Color.Green;
                    lb_result.Font = new Font("Arial", 10F);

                }
                else
                {

                    lb_result.Text = "SEM PERMISSÃO";
                    lb_result.ForeColor = Color.Red;
                    lb_result.Font = new Font("Arial", 15);

                }


            }
            else
            {

                MessageBox.Show("Preencher todos os campos", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



        }

       
    }
}
