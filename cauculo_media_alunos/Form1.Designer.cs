
namespace cauculo_media_alunos
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
            this.button = new System.Windows.Forms.Button();
            this.lb_result = new System.Windows.Forms.Label();
            this.txt_nota01 = new System.Windows.Forms.TextBox();
            this.txt_nota02 = new System.Windows.Forms.TextBox();
            this.txt_nota03 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cauculo media alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nota 01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nota 02";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "nota 03";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "média";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(335, 270);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(82, 46);
            this.button.TabIndex = 5;
            this.button.Text = "status aluno";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(147, 348);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(66, 13);
            this.lb_result.TabIndex = 6;
            this.lb_result.Text = "Status aluno";
            // 
            // txt_nota01
            // 
            this.txt_nota01.Location = new System.Drawing.Point(84, 217);
            this.txt_nota01.Name = "txt_nota01";
            this.txt_nota01.Size = new System.Drawing.Size(100, 20);
            this.txt_nota01.TabIndex = 7;
            // 
            // txt_nota02
            // 
            this.txt_nota02.Location = new System.Drawing.Point(235, 217);
            this.txt_nota02.Name = "txt_nota02";
            this.txt_nota02.Size = new System.Drawing.Size(100, 20);
            this.txt_nota02.TabIndex = 8;
            // 
            // txt_nota03
            // 
            this.txt_nota03.Location = new System.Drawing.Point(377, 217);
            this.txt_nota03.Name = "txt_nota03";
            this.txt_nota03.Size = new System.Drawing.Size(100, 20);
            this.txt_nota03.TabIndex = 9;
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(150, 284);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 402);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_nota03);
            this.Controls.Add(this.txt_nota02);
            this.Controls.Add(this.txt_nota01);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox txt_nota01;
        private System.Windows.Forms.TextBox txt_nota02;
        private System.Windows.Forms.TextBox txt_nota03;
        private System.Windows.Forms.TextBox txt_result;
    }
}

