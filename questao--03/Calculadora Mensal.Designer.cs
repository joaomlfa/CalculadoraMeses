namespace questao__03
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEconomizar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textValorApartamento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Anual";
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(123, 77);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 22);
            this.textSalario.TabIndex = 1;
            this.textSalario.TextChanged += new System.EventHandler(this.textSalario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "% A Economizar Mensalmente";
            // 
            // textEconomizar
            // 
            this.textEconomizar.Location = new System.Drawing.Point(123, 166);
            this.textEconomizar.Name = "textEconomizar";
            this.textEconomizar.Size = new System.Drawing.Size(100, 22);
            this.textEconomizar.TabIndex = 3;
            this.textEconomizar.TextChanged += new System.EventHandler(this.textEconomizar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor do Apartamento";
            // 
            // textValorApartamento
            // 
            this.textValorApartamento.Location = new System.Drawing.Point(123, 260);
            this.textValorApartamento.Name = "textValorApartamento";
            this.textValorApartamento.Size = new System.Drawing.Size(100, 22);
            this.textValorApartamento.TabIndex = 5;
            this.textValorApartamento.TextChanged += new System.EventHandler(this.textValorApartamento_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Meses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textValorApartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEconomizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Meses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEconomizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textValorApartamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

