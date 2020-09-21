namespace Atividade_01
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelRaio = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(39, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 30);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(159, 273);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(279, 273);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 30);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // labelRaio
            // 
            this.labelRaio.AutoSize = true;
            this.labelRaio.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaio.Location = new System.Drawing.Point(55, 52);
            this.labelRaio.Name = "labelRaio";
            this.labelRaio.Size = new System.Drawing.Size(53, 27);
            this.labelRaio.TabIndex = 3;
            this.labelRaio.Text = "Raio";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(55, 115);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(68, 27);
            this.labelAltura.TabIndex = 4;
            this.labelAltura.Text = "Altura";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(55, 184);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(83, 27);
            this.labelVolume.TabIndex = 5;
            this.labelVolume.Text = "Volume";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(149, 59);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 6;
            this.txtRaio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRaio_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(149, 123);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 7;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(149, 192);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 341);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelRaio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label labelRaio;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtVolume;
    }
}

