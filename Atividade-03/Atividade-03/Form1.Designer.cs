namespace Atividade_03
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.gbxGenero = new System.Windows.Forms.GroupBox();
            this.ckbxMasc = new System.Windows.Forms.CheckBox();
            this.ckbxFem = new System.Windows.Forms.CheckBox();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.mskbxPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.Color.White;
            this.lblAltura.Location = new System.Drawing.Point(17, 29);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(176, 25);
            this.lblAltura.TabIndex = 10;
            this.lblAltura.Text = "Altura do paciente";
            // 
            // gbxGenero
            // 
            this.gbxGenero.Controls.Add(this.ckbxMasc);
            this.gbxGenero.Controls.Add(this.ckbxFem);
            this.gbxGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGenero.ForeColor = System.Drawing.Color.White;
            this.gbxGenero.Location = new System.Drawing.Point(22, 124);
            this.gbxGenero.Name = "gbxGenero";
            this.gbxGenero.Size = new System.Drawing.Size(142, 100);
            this.gbxGenero.TabIndex = 10;
            this.gbxGenero.TabStop = false;
            this.gbxGenero.Text = "Sexo";
            // 
            // ckbxMasc
            // 
            this.ckbxMasc.AutoSize = true;
            this.ckbxMasc.Location = new System.Drawing.Point(6, 69);
            this.ckbxMasc.Name = "ckbxMasc";
            this.ckbxMasc.Size = new System.Drawing.Size(108, 25);
            this.ckbxMasc.TabIndex = 4;
            this.ckbxMasc.Text = "Masculino";
            this.ckbxMasc.UseVisualStyleBackColor = true;
            this.ckbxMasc.CheckedChanged += new System.EventHandler(this.ckbxMasc_CheckedChanged);
            // 
            // ckbxFem
            // 
            this.ckbxFem.AutoSize = true;
            this.ckbxFem.Checked = true;
            this.ckbxFem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxFem.Location = new System.Drawing.Point(6, 28);
            this.ckbxFem.Name = "ckbxFem";
            this.ckbxFem.Size = new System.Drawing.Size(101, 25);
            this.ckbxFem.TabIndex = 3;
            this.ckbxFem.Text = "Feminino";
            this.ckbxFem.UseVisualStyleBackColor = true;
            this.ckbxFem.CheckedChanged += new System.EventHandler(this.ckbxFem_CheckedChanged);
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoAtual.ForeColor = System.Drawing.Color.White;
            this.lblPesoAtual.Location = new System.Drawing.Point(17, 73);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(162, 25);
            this.lblPesoAtual.TabIndex = 10;
            this.lblPesoAtual.Text = "Peso do paciente";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCalcular.Location = new System.Drawing.Point(194, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnSair.Location = new System.Drawing.Point(245, 297);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 32);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAltura.Location = new System.Drawing.Point(199, 25);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskbxAltura.Size = new System.Drawing.Size(62, 29);
            this.mskbxAltura.TabIndex = 1;
            this.mskbxAltura.ValidatingType = typeof(int);
            // 
            // mskbxPesoAtual
            // 
            this.mskbxPesoAtual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxPesoAtual.Location = new System.Drawing.Point(199, 69);
            this.mskbxPesoAtual.Mask = "000.00";
            this.mskbxPesoAtual.Name = "mskbxPesoAtual";
            this.mskbxPesoAtual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mskbxPesoAtual.Size = new System.Drawing.Size(62, 29);
            this.mskbxPesoAtual.TabIndex = 2;
            this.mskbxPesoAtual.ValidatingType = typeof(int);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.ForeColor = System.Drawing.Color.White;
            this.lblPesoIdeal.Location = new System.Drawing.Point(190, 131);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(101, 25);
            this.lblPesoIdeal.TabIndex = 0;
            this.lblPesoIdeal.Text = "Peso Ideal";
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.Enabled = false;
            this.txtPesoIdeal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoIdeal.Location = new System.Drawing.Point(195, 169);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.Size = new System.Drawing.Size(96, 29);
            this.txtPesoIdeal.TabIndex = 8;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLimpar.Location = new System.Drawing.Point(105, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 32);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(404, 341);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.mskbxPesoAtual);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.gbxGenero);
            this.Controls.Add(this.lblAltura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Peso Ideal";
            this.gbxGenero.ResumeLayout(false);
            this.gbxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.GroupBox gbxGenero;
        private System.Windows.Forms.CheckBox ckbxMasc;
        private System.Windows.Forms.CheckBox ckbxFem;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
        private System.Windows.Forms.MaskedTextBox mskbxPesoAtual;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.TextBox txtPesoIdeal;
        private System.Windows.Forms.Button btnLimpar;
    }
}

