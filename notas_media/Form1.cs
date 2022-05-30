using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DECLARANDO VARIAVEIS E ATRIBUINDO VALOR A ELAS

            decimal nota01 = Convert.ToDecimal(txt_nota01.Text);
            decimal nota02 = Convert.ToDecimal(txt_nota02.Text);
            decimal nota03 = Convert.ToDecimal(txt_nota03.Text);
            decimal nota04 = Convert.ToDecimal(txt_nota04.Text);
            decimal media;

            //CALCULOS MÉDIA

            media = (nota01 + nota02 + nota03 + nota04) / 4;

            txt_media.Text = media.ToString("n1");

            //OUTRAS VARIAVEIS
            decimal menor = nota01;
            decimal maior = nota02;

            //DECLARANDO AS CONDIÇÕES

            if (nota02 < menor) //SE FOR MENOR
            {
                menor = nota02;
            }
            if (nota03 < menor)
            {
                menor = nota03;
            }
           
            if (nota04 < menor)
            {
                menor = nota04;
            }
            
            
            if (nota02 > maior) //SE FOR MAIOR
            {
                maior = nota02;
            }
            
            if (nota03 > maior)
            {
                maior = nota03;
            }
            
            if (nota04 > maior)
            {
                maior = nota04;
            }
            
            
            txt_maior.Text = maior.ToString("n1");
            txt_menor.Text = menor.ToString("n1");

      

        }

    }
}
