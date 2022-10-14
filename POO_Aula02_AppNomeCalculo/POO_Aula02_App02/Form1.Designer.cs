namespace POO_Aula02_App02
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonSubtracao = new System.Windows.Forms.Button();
            this.buttonMultiplicacao = new System.Windows.Forms.Button();
            this.buttonDivisao = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.labelNum1 = new System.Windows.Forms.Label();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.buttonSaida = new System.Windows.Forms.Button();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.num1.Location = new System.Drawing.Point(22, 132);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(196, 32);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.num2.Location = new System.Drawing.Point(469, 132);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(196, 32);
            this.num2.TabIndex = 1;
            // 
            // buttonSoma
            // 
            this.buttonSoma.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoma.Location = new System.Drawing.Point(275, 107);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(51, 46);
            this.buttonSoma.TabIndex = 2;
            this.buttonSoma.Text = "+";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonSubtracao
            // 
            this.buttonSubtracao.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSubtracao.Location = new System.Drawing.Point(332, 107);
            this.buttonSubtracao.Name = "buttonSubtracao";
            this.buttonSubtracao.Size = new System.Drawing.Size(51, 46);
            this.buttonSubtracao.TabIndex = 3;
            this.buttonSubtracao.Text = "-";
            this.buttonSubtracao.UseVisualStyleBackColor = true;
            this.buttonSubtracao.Click += new System.EventHandler(this.buttonSubtracao_Click);
            // 
            // buttonMultiplicacao
            // 
            this.buttonMultiplicacao.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplicacao.Location = new System.Drawing.Point(275, 159);
            this.buttonMultiplicacao.Name = "buttonMultiplicacao";
            this.buttonMultiplicacao.Size = new System.Drawing.Size(51, 46);
            this.buttonMultiplicacao.TabIndex = 4;
            this.buttonMultiplicacao.Text = "X";
            this.buttonMultiplicacao.UseVisualStyleBackColor = true;
            this.buttonMultiplicacao.Click += new System.EventHandler(this.buttonMultiplicacao_Click);
            // 
            // buttonDivisao
            // 
            this.buttonDivisao.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonDivisao.Location = new System.Drawing.Point(332, 159);
            this.buttonDivisao.Name = "buttonDivisao";
            this.buttonDivisao.Size = new System.Drawing.Size(51, 46);
            this.buttonDivisao.TabIndex = 5;
            this.buttonDivisao.Text = "/";
            this.buttonDivisao.UseVisualStyleBackColor = true;
            this.buttonDivisao.Click += new System.EventHandler(this.buttonDivisao_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.Resultado.Location = new System.Drawing.Point(327, 261);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(23, 25);
            this.Resultado.TabIndex = 6;
            this.Resultado.Text = "0";
            // 
            // labelNum1
            // 
            this.labelNum1.AutoSize = true;
            this.labelNum1.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNum1.Location = new System.Drawing.Point(64, 97);
            this.labelNum1.Name = "labelNum1";
            this.labelNum1.Size = new System.Drawing.Size(113, 24);
            this.labelNum1.TabIndex = 7;
            this.labelNum1.Text = "1º Número";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNum2.Location = new System.Drawing.Point(505, 97);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(113, 24);
            this.labelNum2.TabIndex = 8;
            this.labelNum2.Text = "2º Número";
            // 
            // buttonSaida
            // 
            this.buttonSaida.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSaida.Location = new System.Drawing.Point(608, 382);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(96, 45);
            this.buttonSaida.TabIndex = 9;
            this.buttonSaida.Text = "Sair";
            this.buttonSaida.UseVisualStyleBackColor = true;
            this.buttonSaida.Click += new System.EventHandler(this.buttonSaida_Click);
            // 
            // Usuario
            // 
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Usuario.Location = new System.Drawing.Point(222, 33);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(196, 32);
            this.Usuario.TabIndex = 10;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNome.Location = new System.Drawing.Point(141, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(75, 24);
            this.labelNome.TabIndex = 11;
            this.labelNome.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.buttonSaida);
            this.Controls.Add(this.labelNum2);
            this.Controls.Add(this.labelNum1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.buttonDivisao);
            this.Controls.Add(this.buttonMultiplicacao);
            this.Controls.Add(this.buttonSubtracao);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonSubtracao;
        private System.Windows.Forms.Button buttonMultiplicacao;
        private System.Windows.Forms.Button buttonDivisao;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label labelNum1;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Button buttonSaida;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label labelNome;
    }
}

