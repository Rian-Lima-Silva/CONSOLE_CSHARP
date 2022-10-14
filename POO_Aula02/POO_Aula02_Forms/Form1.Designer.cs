namespace POO_Aula02_Forms
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.labelNumero1 = new System.Windows.Forms.Label();
            this.labelNumero2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.buttonSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Num1.Location = new System.Drawing.Point(12, 50);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(215, 35);
            this.Num1.TabIndex = 0;
            this.Num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Num2.Location = new System.Drawing.Point(405, 50);
            this.Num2.Name = "Num2";
            this.Num2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Num2.Size = new System.Drawing.Size(215, 35);
            this.Num2.TabIndex = 1;
            this.Num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // labelNumero1
            // 
            this.labelNumero1.AutoSize = true;
            this.labelNumero1.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.labelNumero1.Location = new System.Drawing.Point(57, 19);
            this.labelNumero1.Name = "labelNumero1";
            this.labelNumero1.Size = new System.Drawing.Size(128, 28);
            this.labelNumero1.TabIndex = 2;
            this.labelNumero1.Text = "1º Número";
            this.labelNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumero2
            // 
            this.labelNumero2.AutoSize = true;
            this.labelNumero2.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.labelNumero2.Location = new System.Drawing.Point(450, 19);
            this.labelNumero2.Name = "labelNumero2";
            this.labelNumero2.Size = new System.Drawing.Size(127, 28);
            this.labelNumero2.TabIndex = 3;
            this.labelNumero2.Text = "2º Número";
            this.labelNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Bold);
            this.Resultado.Location = new System.Drawing.Point(296, 246);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(31, 34);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "0";
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma.Location = new System.Drawing.Point(246, 19);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(55, 58);
            this.buttonSoma.TabIndex = 5;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSubtracao.Location = new System.Drawing.Point(319, 19);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(55, 58);
            this.buttonSubtracao.TabIndex = 6;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            this.buttonSubtracao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplicacao.Location = new System.Drawing.Point(246, 92);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(55, 58);
            this.buttonMultiplicacao.TabIndex = 7;
            this.buttonMultiplicacao.Text = "X";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDivisao.Location = new System.Drawing.Point(319, 92);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(55, 58);
            this.buttonDivisao.TabIndex = 8;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // buttonSaida
            // 
            this.buttonSaida.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSaida.Location = new System.Drawing.Point(545, 311);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(114, 35);
            this.buttonSaida.TabIndex = 9;
            this.buttonSaida.Text = "Sair";
            this.buttonSaida.UseVisualStyleBackColor = true;
            this.buttonSaida.Click += new System.EventHandler(this.buttonSaida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 358);
            this.Controls.Add(this.buttonSaida);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.labelNumero2);
            this.Controls.Add(this.labelNumero1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Label labelNumero1;
        private System.Windows.Forms.Label labelNumero2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Button buttonSaida;
    }
}

