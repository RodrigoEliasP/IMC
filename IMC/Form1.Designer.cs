namespace IMC
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
            this.lbl_BemVindo = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_BemVindo
            // 
            this.lbl_BemVindo.AutoSize = true;
            this.lbl_BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_BemVindo.Location = new System.Drawing.Point(3, 9);
            this.lbl_BemVindo.Name = "lbl_BemVindo";
            this.lbl_BemVindo.Size = new System.Drawing.Size(335, 31);
            this.lbl_BemVindo.TabIndex = 0;
            this.lbl_BemVindo.Text = "Bem vindo ao calcula IMC!";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(67, 59);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(229, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Nome.Location = new System.Drawing.Point(12, 59);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_Nome.TabIndex = 2;
            this.lbl_Nome.Text = "Nome:";
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Idade.Location = new System.Drawing.Point(12, 103);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(47, 17);
            this.lbl_Idade.TabIndex = 4;
            this.lbl_Idade.Text = "Idade:";
            // 
            // txt_Idade
            // 
            this.txt_Idade.Location = new System.Drawing.Point(67, 103);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(229, 20);
            this.txt_Idade.TabIndex = 3;
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Peso.Location = new System.Drawing.Point(12, 141);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(44, 17);
            this.lbl_Peso.TabIndex = 6;
            this.lbl_Peso.Text = "Peso:";
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(67, 141);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(229, 20);
            this.txt_Peso.TabIndex = 5;
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Altura.Location = new System.Drawing.Point(12, 184);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(49, 17);
            this.lbl_Altura.TabIndex = 8;
            this.lbl_Altura.Text = "Altura:";
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(67, 184);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(229, 20);
            this.txt_Altura.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Calcular.Location = new System.Drawing.Point(111, 221);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(109, 34);
            this.btn_Calcular.TabIndex = 9;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Resultado.Location = new System.Drawing.Point(29, 286);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(134, 31);
            this.lbl_Resultado.TabIndex = 10;
            this.lbl_Resultado.Text = "Seu IMC: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 367);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.lbl_Peso);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.lbl_Idade);
            this.Controls.Add(this.txt_Idade);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_BemVindo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_BemVindo;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Resultado;
    }
}

