﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace preco_produto
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

            decimal valor = Convert.ToDecimal(txt_valor.Text);
            decimal porcentagem = Convert.ToDecimal(txt_percent.Text);
            decimal soma;
            decimal resultado;

            //CALCULOS

            soma = (valor * porcentagem) / 100;
            resultado = (soma + valor);

            txt_result.Text = resultado.ToString();
     
        }
    }
}
