namespace Atividade_05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.numNumeroDeFilhos = new System.Windows.Forms.NumericUpDown();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtDescontoIrpf = new System.Windows.Forms.TextBox();
            this.lblDescontoIrpf = new System.Windows.Forms.Label();
            this.txtDescontoInss = new System.Windows.Forms.TextBox();
            this.lblDescontoInss = new System.Windows.Forms.Label();
            this.txtAliquotaIrpf = new System.Windows.Forms.TextBox();
            this.lblAliquotaIrpf = new System.Windows.Forms.Label();
            this.txtAliquotaInss = new System.Windows.Forms.TextBox();
            this.lblAliquotaInss = new System.Windows.Forms.Label();
            this.btnVerificarDescontos = new System.Windows.Forms.Button();
            this.rtxtSituacao = new System.Windows.Forms.RichTextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroDeFilhos)).BeginInit();
            this.gboxGenero.SuspendLayout();
            this.gbxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(704, 130);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(131, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(570, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Calculadora de Impostos v1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 175);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(149, 21);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(12, 224);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(108, 21);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFilhos.Location = new System.Drawing.Point(12, 280);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(143, 21);
            this.lblNumFilhos.TabIndex = 3;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(174, 167);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 29);
            this.txtNome.TabIndex = 4;
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(175, 221);
            this.mskbxSalarioBruto.Mask = "00000.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(100, 29);
            this.mskbxSalarioBruto.SkipLiterals = false;
            this.mskbxSalarioBruto.TabIndex = 5;
            this.mskbxSalarioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numNumeroDeFilhos
            // 
            this.numNumeroDeFilhos.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumeroDeFilhos.Location = new System.Drawing.Point(174, 278);
            this.numNumeroDeFilhos.Name = "numNumeroDeFilhos";
            this.numNumeroDeFilhos.Size = new System.Drawing.Size(51, 25);
            this.numNumeroDeFilhos.TabIndex = 6;
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.rbtnMasc);
            this.gboxGenero.Controls.Add(this.rbtnFem);
            this.gboxGenero.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxGenero.Location = new System.Drawing.Point(16, 340);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Size = new System.Drawing.Size(126, 113);
            this.gboxGenero.TabIndex = 8;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Gênero";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(6, 69);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(106, 25);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Checked = true;
            this.rbtnFem.Location = new System.Drawing.Point(6, 28);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(99, 25);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(255, 279);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(85, 25);
            this.ckbxCasado.TabIndex = 7;
            this.ckbxCasado.Text = "Casado";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.txtSalarioLiquido);
            this.gbxDados.Controls.Add(this.lblSalarioLiquido);
            this.gbxDados.Controls.Add(this.txtSalarioFamilia);
            this.gbxDados.Controls.Add(this.lblSalarioFamilia);
            this.gbxDados.Controls.Add(this.txtDescontoIrpf);
            this.gbxDados.Controls.Add(this.lblDescontoIrpf);
            this.gbxDados.Controls.Add(this.txtDescontoInss);
            this.gbxDados.Controls.Add(this.lblDescontoInss);
            this.gbxDados.Controls.Add(this.txtAliquotaIrpf);
            this.gbxDados.Controls.Add(this.lblAliquotaIrpf);
            this.gbxDados.Controls.Add(this.txtAliquotaInss);
            this.gbxDados.Controls.Add(this.lblAliquotaInss);
            this.gbxDados.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDados.Location = new System.Drawing.Point(398, 157);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(294, 353);
            this.gbxDados.TabIndex = 9;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(137, 270);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(140, 29);
            this.txtSalarioLiquido.TabIndex = 10;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(16, 278);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(122, 21);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(137, 233);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(140, 29);
            this.txtSalarioFamilia.TabIndex = 10;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(16, 241);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(120, 21);
            this.lblSalarioFamilia.TabIndex = 10;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // txtDescontoIrpf
            // 
            this.txtDescontoIrpf.Enabled = false;
            this.txtDescontoIrpf.Location = new System.Drawing.Point(137, 171);
            this.txtDescontoIrpf.Name = "txtDescontoIrpf";
            this.txtDescontoIrpf.Size = new System.Drawing.Size(140, 29);
            this.txtDescontoIrpf.TabIndex = 10;
            // 
            // lblDescontoIrpf
            // 
            this.lblDescontoIrpf.AutoSize = true;
            this.lblDescontoIrpf.Location = new System.Drawing.Point(16, 179);
            this.lblDescontoIrpf.Name = "lblDescontoIrpf";
            this.lblDescontoIrpf.Size = new System.Drawing.Size(121, 21);
            this.lblDescontoIrpf.TabIndex = 10;
            this.lblDescontoIrpf.Text = "Desconto IRPF";
            // 
            // txtDescontoInss
            // 
            this.txtDescontoInss.Enabled = false;
            this.txtDescontoInss.Location = new System.Drawing.Point(137, 134);
            this.txtDescontoInss.Name = "txtDescontoInss";
            this.txtDescontoInss.Size = new System.Drawing.Size(140, 29);
            this.txtDescontoInss.TabIndex = 10;
            // 
            // lblDescontoInss
            // 
            this.lblDescontoInss.AutoSize = true;
            this.lblDescontoInss.Location = new System.Drawing.Point(16, 142);
            this.lblDescontoInss.Name = "lblDescontoInss";
            this.lblDescontoInss.Size = new System.Drawing.Size(123, 21);
            this.lblDescontoInss.TabIndex = 10;
            this.lblDescontoInss.Text = "Desconto INSS";
            // 
            // txtAliquotaIrpf
            // 
            this.txtAliquotaIrpf.Enabled = false;
            this.txtAliquotaIrpf.Location = new System.Drawing.Point(137, 64);
            this.txtAliquotaIrpf.Name = "txtAliquotaIrpf";
            this.txtAliquotaIrpf.Size = new System.Drawing.Size(140, 29);
            this.txtAliquotaIrpf.TabIndex = 10;
            // 
            // lblAliquotaIrpf
            // 
            this.lblAliquotaIrpf.AutoSize = true;
            this.lblAliquotaIrpf.Location = new System.Drawing.Point(16, 72);
            this.lblAliquotaIrpf.Name = "lblAliquotaIrpf";
            this.lblAliquotaIrpf.Size = new System.Drawing.Size(113, 21);
            this.lblAliquotaIrpf.TabIndex = 10;
            this.lblAliquotaIrpf.Text = "Alíquota IRPF";
            // 
            // txtAliquotaInss
            // 
            this.txtAliquotaInss.Enabled = false;
            this.txtAliquotaInss.Location = new System.Drawing.Point(137, 27);
            this.txtAliquotaInss.Name = "txtAliquotaInss";
            this.txtAliquotaInss.Size = new System.Drawing.Size(140, 29);
            this.txtAliquotaInss.TabIndex = 10;
            // 
            // lblAliquotaInss
            // 
            this.lblAliquotaInss.AutoSize = true;
            this.lblAliquotaInss.Location = new System.Drawing.Point(16, 35);
            this.lblAliquotaInss.Name = "lblAliquotaInss";
            this.lblAliquotaInss.Size = new System.Drawing.Size(115, 21);
            this.lblAliquotaInss.TabIndex = 10;
            this.lblAliquotaInss.Text = "Alíquota INSS";
            // 
            // btnVerificarDescontos
            // 
            this.btnVerificarDescontos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.btnVerificarDescontos.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDescontos.ForeColor = System.Drawing.Color.White;
            this.btnVerificarDescontos.Location = new System.Drawing.Point(16, 458);
            this.btnVerificarDescontos.Name = "btnVerificarDescontos";
            this.btnVerificarDescontos.Size = new System.Drawing.Size(169, 52);
            this.btnVerificarDescontos.TabIndex = 11;
            this.btnVerificarDescontos.Text = "Verificar Descontos";
            this.btnVerificarDescontos.UseVisualStyleBackColor = false;
            this.btnVerificarDescontos.Click += new System.EventHandler(this.btnVerificarDescontos_Click);
            // 
            // rtxtSituacao
            // 
            this.rtxtSituacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.rtxtSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtxtSituacao.Enabled = false;
            this.rtxtSituacao.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSituacao.Location = new System.Drawing.Point(209, 354);
            this.rtxtSituacao.Name = "rtxtSituacao";
            this.rtxtSituacao.Size = new System.Drawing.Size(165, 95);
            this.rtxtSituacao.TabIndex = 12;
            this.rtxtSituacao.Text = "";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(205, 328);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(99, 20);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.Text = "Observação:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(140)))), ((int)(((byte)(143)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(205, 458);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(169, 52);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(704, 512);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.rtxtSituacao);
            this.Controls.Add(this.btnVerificarDescontos);
            this.Controls.Add(this.gbxDados);
            this.Controls.Add(this.ckbxCasado);
            this.Controls.Add(this.gboxGenero);
            this.Controls.Add(this.numNumeroDeFilhos);
            this.Controls.Add(this.mskbxSalarioBruto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Impostos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroDeFilhos)).EndInit();
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.NumericUpDown numNumeroDeFilhos;
        private System.Windows.Forms.GroupBox gboxGenero;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtDescontoIrpf;
        private System.Windows.Forms.Label lblDescontoIrpf;
        private System.Windows.Forms.TextBox txtDescontoInss;
        private System.Windows.Forms.Label lblDescontoInss;
        private System.Windows.Forms.TextBox txtAliquotaIrpf;
        private System.Windows.Forms.Label lblAliquotaIrpf;
        private System.Windows.Forms.TextBox txtAliquotaInss;
        private System.Windows.Forms.Label lblAliquotaInss;
        private System.Windows.Forms.Button btnVerificarDescontos;
        private System.Windows.Forms.RichTextBox rtxtSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnLimpar;
    }
}

