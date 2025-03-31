namespace AlunoText
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblProva01 = new System.Windows.Forms.Label();
            this.lblProva02 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtProva01 = new System.Windows.Forms.TextBox();
            this.txtProva02 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(98, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 29);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.lblMatricula.Location = new System.Drawing.Point(54, 103);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(105, 29);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "MATRICULA:";
            // 
            // lblProva01
            // 
            this.lblProva01.AutoSize = true;
            this.lblProva01.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.lblProva01.Location = new System.Drawing.Point(70, 148);
            this.lblProva01.Name = "lblProva01";
            this.lblProva01.Size = new System.Drawing.Size(89, 29);
            this.lblProva01.TabIndex = 2;
            this.lblProva01.Text = "PROVA 01:";
            // 
            // lblProva02
            // 
            this.lblProva02.AutoSize = true;
            this.lblProva02.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.lblProva02.Location = new System.Drawing.Point(63, 190);
            this.lblProva02.Name = "lblProva02";
            this.lblProva02.Size = new System.Drawing.Size(93, 29);
            this.lblProva02.TabIndex = 3;
            this.lblProva02.Text = "PROVA 02:";
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btnCalc.Location = new System.Drawing.Point(241, 238);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(102, 37);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.txtNome.Location = new System.Drawing.Point(162, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 36);
            this.txtNome.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.txtMatricula.Location = new System.Drawing.Point(165, 103);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(151, 36);
            this.txtMatricula.TabIndex = 6;
            // 
            // txtProva01
            // 
            this.txtProva01.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.txtProva01.Location = new System.Drawing.Point(162, 148);
            this.txtProva01.Name = "txtProva01";
            this.txtProva01.Size = new System.Drawing.Size(154, 36);
            this.txtProva01.TabIndex = 7;
            // 
            // txtProva02
            // 
            this.txtProva02.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.txtProva02.Location = new System.Drawing.Point(162, 187);
            this.txtProva02.Name = "txtProva02";
            this.txtProva02.Size = new System.Drawing.Size(154, 36);
            this.txtProva02.TabIndex = 8;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.lblResultado.Location = new System.Drawing.Point(94, 271);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(64, 29);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "label5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "RESULTADO FINAL DO TRIMESTRE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtProva02);
            this.Controls.Add(this.txtProva01);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblProva02);
            this.Controls.Add(this.lblProva01);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblProva01;
        private System.Windows.Forms.Label lblProva02;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtProva01;
        private System.Windows.Forms.TextBox txtProva02;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}

