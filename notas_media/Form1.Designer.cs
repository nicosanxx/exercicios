
namespace notas_media
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nota01 = new System.Windows.Forms.TextBox();
            this.txt_nota02 = new System.Windows.Forms.TextBox();
            this.txt_nota03 = new System.Windows.Forms.TextBox();
            this.txt_nota04 = new System.Windows.Forms.TextBox();
            this.txt_maior = new System.Windows.Forms.TextBox();
            this.txt_menor = new System.Windows.Forms.TextBox();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "4. Elaborar um sistema onde o usuário digita 04 notas e exibir: \r\nMaior Nota\r\nMen" +
    "or Nota \r\nMédia.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 03";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 04";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maior Nota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Menor Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(162, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Média";
            // 
            // txt_nota01
            // 
            this.txt_nota01.Location = new System.Drawing.Point(91, 89);
            this.txt_nota01.Name = "txt_nota01";
            this.txt_nota01.Size = new System.Drawing.Size(100, 20);
            this.txt_nota01.TabIndex = 8;
            // 
            // txt_nota02
            // 
            this.txt_nota02.Location = new System.Drawing.Point(91, 117);
            this.txt_nota02.Name = "txt_nota02";
            this.txt_nota02.Size = new System.Drawing.Size(100, 20);
            this.txt_nota02.TabIndex = 9;
            // 
            // txt_nota03
            // 
            this.txt_nota03.Location = new System.Drawing.Point(91, 143);
            this.txt_nota03.Name = "txt_nota03";
            this.txt_nota03.Size = new System.Drawing.Size(100, 20);
            this.txt_nota03.TabIndex = 10;
            // 
            // txt_nota04
            // 
            this.txt_nota04.Location = new System.Drawing.Point(91, 168);
            this.txt_nota04.Name = "txt_nota04";
            this.txt_nota04.Size = new System.Drawing.Size(100, 20);
            this.txt_nota04.TabIndex = 11;
            // 
            // txt_maior
            // 
            this.txt_maior.Enabled = false;
            this.txt_maior.Location = new System.Drawing.Point(10, 269);
            this.txt_maior.Name = "txt_maior";
            this.txt_maior.Size = new System.Drawing.Size(100, 20);
            this.txt_maior.TabIndex = 12;
            // 
            // txt_menor
            // 
            this.txt_menor.Enabled = false;
            this.txt_menor.Location = new System.Drawing.Point(265, 269);
            this.txt_menor.Name = "txt_menor";
            this.txt_menor.Size = new System.Drawing.Size(100, 20);
            this.txt_menor.TabIndex = 13;
            // 
            // txt_media
            // 
            this.txt_media.Enabled = false;
            this.txt_media.Location = new System.Drawing.Point(139, 269);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(100, 20);
            this.txt_media.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(249, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.txt_menor);
            this.Controls.Add(this.txt_maior);
            this.Controls.Add(this.txt_nota04);
            this.Controls.Add(this.txt_nota03);
            this.Controls.Add(this.txt_nota02);
            this.Controls.Add(this.txt_nota01);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "it";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nota01;
        private System.Windows.Forms.TextBox txt_nota02;
        private System.Windows.Forms.TextBox txt_nota03;
        private System.Windows.Forms.TextBox txt_nota04;
        private System.Windows.Forms.TextBox txt_maior;
        private System.Windows.Forms.TextBox txt_menor;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Button button1;
    }
}

