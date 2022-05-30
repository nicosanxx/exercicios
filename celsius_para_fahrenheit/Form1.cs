using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celsius_para_fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_c.Text == "")
            {
                MessageBox.Show("PREENCHER O CAMPO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {

                //VARS
                decimal celsius = Convert.ToDecimal(txt_c.Text);
                decimal fahrenheit;

                //CONVERTENDO

                fahrenheit = (9 * celsius + 160) / 5;

                txt_f.Text = fahrenheit.ToString();







            }









        }
    }
}
