using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolar_real
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_cotacao.Text == "" || txt_us.Text == "")
            {
                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {

                decimal dolar = Convert.ToDecimal(txt_us.Text);
                decimal cotacao = Convert.ToDecimal(txt_cotacao.Text);
                decimal real;
                decimal conversao;

                conversao = cotacao * dolar;

                txt_rs.Text = conversao.ToString("n2");

            }



        }
    }
}
