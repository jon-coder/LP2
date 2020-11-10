namespace Atividade_08
{
    partial class ex7
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
            this.btnExe = new System.Windows.Forms.Button();
            this.rchTxtSaida = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExe
            // 
            this.btnExe.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExe.Location = new System.Drawing.Point(228, 120);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(110, 40);
            this.btnExe.TabIndex = 0;
            this.btnExe.Text = "Executar";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // rchTxtSaida
            // 
            this.rchTxtSaida.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtSaida.Location = new System.Drawing.Point(360, 120);
            this.rchTxtSaida.Name = "rchTxtSaida";
            this.rchTxtSaida.Size = new System.Drawing.Size(311, 292);
            this.rchTxtSaida.TabIndex = 1;
            this.rchTxtSaida.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(228, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rchTxtSaida);
            this.Controls.Add(this.btnExe);
            this.Name = "ex7";
            this.Text = "ex7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.RichTextBox rchTxtSaida;
        private System.Windows.Forms.Button btnClear;
    }
}