namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbVisor = new System.Windows.Forms.TextBox();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnXQuadrado = new System.Windows.Forms.Button();
            this.btnUmSobreX = new System.Windows.Forms.Button();
            this.btnMutiplicacao = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbVisor
            // 
            this.txbVisor.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbVisor.Location = new System.Drawing.Point(31, 24);
            this.txbVisor.Name = "txbVisor";
            this.txbVisor.Size = new System.Drawing.Size(298, 61);
            this.txbVisor.TabIndex = 0;
            this.txbVisor.Text = " \r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.txbVisor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Location = new System.Drawing.Point(31, 96);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(70, 55);
            this.btnPorcentagem.TabIndex = 1;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(107, 96);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(70, 55);
            this.btnCE.TabIndex = 2;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(259, 96);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(70, 55);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.Text = "←";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(183, 96);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(70, 55);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivisao.Location = new System.Drawing.Point(259, 157);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(70, 55);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(183, 157);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(70, 55);
            this.btnRaiz.TabIndex = 7;
            this.btnRaiz.Text = "²√x";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnXQuadrado
            // 
            this.btnXQuadrado.Location = new System.Drawing.Point(107, 157);
            this.btnXQuadrado.Name = "btnXQuadrado";
            this.btnXQuadrado.Size = new System.Drawing.Size(70, 55);
            this.btnXQuadrado.TabIndex = 6;
            this.btnXQuadrado.Text = "x²";
            this.btnXQuadrado.UseVisualStyleBackColor = true;
            this.btnXQuadrado.Click += new System.EventHandler(this.btnXQuadrado_Click);
            // 
            // btnUmSobreX
            // 
            this.btnUmSobreX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUmSobreX.Location = new System.Drawing.Point(31, 157);
            this.btnUmSobreX.Name = "btnUmSobreX";
            this.btnUmSobreX.Size = new System.Drawing.Size(70, 55);
            this.btnUmSobreX.TabIndex = 5;
            this.btnUmSobreX.Text = "1/x";
            this.btnUmSobreX.UseVisualStyleBackColor = true;
            this.btnUmSobreX.Click += new System.EventHandler(this.btnUmSobreX_Click);
            // 
            // btnMutiplicacao
            // 
            this.btnMutiplicacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMutiplicacao.Location = new System.Drawing.Point(259, 218);
            this.btnMutiplicacao.Name = "btnMutiplicacao";
            this.btnMutiplicacao.Size = new System.Drawing.Size(70, 55);
            this.btnMutiplicacao.TabIndex = 12;
            this.btnMutiplicacao.Text = "x";
            this.btnMutiplicacao.UseVisualStyleBackColor = true;
            this.btnMutiplicacao.Click += new System.EventHandler(this.btnMutiplicacao_Click);
            // 
            // btnNove
            // 
            this.btnNove.BackColor = System.Drawing.SystemColors.Window;
            this.btnNove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNove.Location = new System.Drawing.Point(183, 218);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(70, 55);
            this.btnNove.TabIndex = 11;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = false;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnOito
            // 
            this.btnOito.BackColor = System.Drawing.SystemColors.Window;
            this.btnOito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOito.Location = new System.Drawing.Point(107, 218);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(70, 55);
            this.btnOito.TabIndex = 10;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = false;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnSete
            // 
            this.btnSete.BackColor = System.Drawing.SystemColors.Window;
            this.btnSete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSete.Location = new System.Drawing.Point(31, 218);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(70, 55);
            this.btnSete.TabIndex = 9;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = false;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtracao.Location = new System.Drawing.Point(259, 279);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(70, 55);
            this.btnSubtracao.TabIndex = 16;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.SystemColors.Window;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.Location = new System.Drawing.Point(183, 279);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(70, 55);
            this.btnSeis.TabIndex = 15;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.SystemColors.Window;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.Location = new System.Drawing.Point(107, 279);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(70, 55);
            this.btnCinco.TabIndex = 14;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.BackColor = System.Drawing.SystemColors.Window;
            this.btnQuatro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuatro.Location = new System.Drawing.Point(31, 279);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(70, 55);
            this.btnQuatro.TabIndex = 13;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = false;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(259, 401);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(70, 55);
            this.btnIgual.TabIndex = 24;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVirgula.Location = new System.Drawing.Point(183, 401);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(70, 55);
            this.btnVirgula.TabIndex = 23;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.Window;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(107, 401);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(70, 55);
            this.btnZero.TabIndex = 22;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaisMenos.Location = new System.Drawing.Point(31, 401);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(70, 55);
            this.btnMaisMenos.TabIndex = 21;
            this.btnMaisMenos.Text = "+/-";
            this.btnMaisMenos.UseVisualStyleBackColor = true;
            this.btnMaisMenos.Click += new System.EventHandler(this.btnMaisMenos_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.Location = new System.Drawing.Point(259, 340);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(70, 55);
            this.btnSoma.TabIndex = 20;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.SystemColors.Window;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTres.Location = new System.Drawing.Point(183, 340);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(70, 55);
            this.btnTres.TabIndex = 19;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDois
            // 
            this.btnDois.BackColor = System.Drawing.SystemColors.Window;
            this.btnDois.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDois.Location = new System.Drawing.Point(107, 340);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(70, 55);
            this.btnDois.TabIndex = 18;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = false;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.SystemColors.Window;
            this.btnUm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUm.Location = new System.Drawing.Point(31, 340);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(70, 55);
            this.btnUm.TabIndex = 17;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 486);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnMutiplicacao);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnXQuadrado);
            this.Controls.Add(this.btnUmSobreX);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.txbVisor);
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbVisor;
        private Button btnPorcentagem;
        private Button btnCE;
        private Button btnApagar;
        private Button btnC;
        private Button btnDivisao;
        private Button btnRaiz;
        private Button btnXQuadrado;
        private Button btnUmSobreX;
        private Button btnMutiplicacao;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnSubtracao;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btnZero;
        private Button btnMaisMenos;
        private Button btnSoma;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
    }
}