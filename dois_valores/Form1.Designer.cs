
namespace dois_valores
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_valor01 = new System.Windows.Forms.TextBox();
            this.txt_valor02 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 - Ler dois valores numéricos inteiros e apresentar o resultado da diferença do " +
    "maior pelo menor valor. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 01:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor 02:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_valor01
            // 
            this.txt_valor01.Location = new System.Drawing.Point(67, 117);
            this.txt_valor01.Name = "txt_valor01";
            this.txt_valor01.Size = new System.Drawing.Size(100, 20);
            this.txt_valor01.TabIndex = 4;
            // 
            // txt_valor02
            // 
            this.txt_valor02.Location = new System.Drawing.Point(67, 185);
            this.txt_valor02.Name = "txt_valor02";
            this.txt_valor02.Size = new System.Drawing.Size(100, 20);
            this.txt_valor02.TabIndex = 5;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(237, 284);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diferença:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_valor02);
            this.Controls.Add(this.txt_valor01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_valor01;
        private System.Windows.Forms.TextBox txt_valor02;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label4;
    }
}

