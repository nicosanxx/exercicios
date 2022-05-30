using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cauculo_media_alunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (txt_nota01.Text != "" && txt_nota02.Text != "" && txt_nota03.Text != "")
            {
                //declarar variaveis

                decimal nota01, nota02, nota03;
                int resultado;

                //atribuir valores as var

                nota01 = Convert.ToDecimal(txt_nota01.Text);
                nota02 = Convert.ToDecimal(txt_nota02.Text);
                nota03 = Convert.ToDecimal(txt_nota03.Text);

                //cauculo

                resultado = (int)(nota01 + nota02 + nota03) / 3;

                //exibir o resultado

                txt_result.Text = resultado.ToString();


                if (resultado >= 7)
                {
                    lb_result.Text = "APROVADO";
                    lb_result.ForeColor = Color.Blue;

                }

                else if (resultado < 7 && resultado >= 5)
                {

                    lb_result.Text = "RECUPERAÇÃO";
                    lb_result.ForeColor = Color.Gold;
                }

                else
                {
                    lb_result.Text = "REPROVADO";
                    lb_result.ForeColor = Color.Red;
                }

            }
            else
            {


                MessageBox.Show("FAVOR PREENCHER TODOS OS CAMPOS", "ATENÇÃO!!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }





            
          
                     
        
        }
       
    }
   
}         