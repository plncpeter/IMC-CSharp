namespace A4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNome3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblConfirmacao = new System.Windows.Forms.Label();
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblConfirmacao1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Humanst521 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitulo.Location = new System.Drawing.Point(38, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calcule seu IMC";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome1.Location = new System.Drawing.Point(28, 114);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(31, 13);
            this.lblNome1.TabIndex = 1;
            this.lblNome1.Text = "Peso";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome2.Location = new System.Drawing.Point(28, 227);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(34, 13);
            this.lblNome2.TabIndex = 2;
            this.lblNome2.Text = "Altura";
            this.lblNome2.Click += new System.EventHandler(this.lblNome2_Click);
            // 
            // lblNome3
            // 
            this.lblNome3.AutoSize = true;
            this.lblNome3.Font = new System.Drawing.Font("Humanst521 BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome3.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblNome3.Location = new System.Drawing.Point(27, 342);
            this.lblNome3.Name = "lblNome3";
            this.lblNome3.Size = new System.Drawing.Size(37, 19);
            this.lblNome3.TabIndex = 3;
            this.lblNome3.Text = "IMC";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblResultado.Location = new System.Drawing.Point(146, 341);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 20);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "NaN";
            // 
            // lblConfirmacao
            // 
            this.lblConfirmacao.AutoSize = true;
            this.lblConfirmacao.Font = new System.Drawing.Font("Humanst521 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacao.ForeColor = System.Drawing.Color.Chocolate;
            this.lblConfirmacao.Location = new System.Drawing.Point(26, 389);
            this.lblConfirmacao.Name = "lblConfirmacao";
            this.lblConfirmacao.Size = new System.Drawing.Size(81, 25);
            this.lblConfirmacao.TabIndex = 5;
            this.lblConfirmacao.Text = "Situação";
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(86, 111);
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(100, 20);
            this.txbN1.TabIndex = 6;
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(86, 224);
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(100, 20);
            this.txbN2.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(86, 291);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblConfirmacao1
            // 
            this.lblConfirmacao1.AutoSize = true;
            this.lblConfirmacao1.Font = new System.Drawing.Font("Humanst521 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacao1.Location = new System.Drawing.Point(71, 425);
            this.lblConfirmacao1.Name = "lblConfirmacao1";
            this.lblConfirmacao1.Size = new System.Drawing.Size(0, 25);
            this.lblConfirmacao1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(225, 459);
            this.Controls.Add(this.lblConfirmacao1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.txbN1);
            this.Controls.Add(this.lblConfirmacao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNome3);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IMC ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNome3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblConfirmacao;
        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblConfirmacao1;
    }
}

