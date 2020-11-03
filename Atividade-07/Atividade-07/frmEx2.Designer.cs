namespace Atividade_07
{
    partial class frmEx2
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.btnGerarValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 84);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(337, 31);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Informe um número inteiro:";
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEntrada.Location = new System.Drawing.Point(355, 84);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(136, 28);
            this.txtValorEntrada.TabIndex = 1;
            // 
            // btnGerarValor
            // 
            this.btnGerarValor.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGerarValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarValor.ForeColor = System.Drawing.Color.White;
            this.btnGerarValor.Location = new System.Drawing.Point(277, 227);
            this.btnGerarValor.Name = "btnGerarValor";
            this.btnGerarValor.Size = new System.Drawing.Size(132, 58);
            this.btnGerarValor.TabIndex = 2;
            this.btnGerarValor.Text = "Gerar Valor";
            this.btnGerarValor.UseVisualStyleBackColor = false;
            this.btnGerarValor.Click += new System.EventHandler(this.btnGerarValor_Click);
            // 
            // frmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnGerarValor);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmEx2";
            this.Text = "frmEx2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtValorEntrada;
        private System.Windows.Forms.Button btnGerarValor;
    }
}