namespace Atividade_06_07
{
    partial class frmExercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio4));
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.btnContarLetras = new System.Windows.Forms.Button();
            this.btnPosicaoBranco = new System.Windows.Forms.Button();
            this.btnContarNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTexto.Location = new System.Drawing.Point(105, 64);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(479, 208);
            this.rchTexto.TabIndex = 0;
            this.rchTexto.Text = "";
            // 
            // btnContarLetras
            // 
            this.btnContarLetras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.btnContarLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarLetras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnContarLetras.Location = new System.Drawing.Point(460, 321);
            this.btnContarLetras.Name = "btnContarLetras";
            this.btnContarLetras.Size = new System.Drawing.Size(135, 65);
            this.btnContarLetras.TabIndex = 16;
            this.btnContarLetras.Text = "Quantidade de Letras";
            this.btnContarLetras.UseVisualStyleBackColor = false;
            this.btnContarLetras.Click += new System.EventHandler(this.btnContarLetras_Click);
            // 
            // btnPosicaoBranco
            // 
            this.btnPosicaoBranco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.btnPosicaoBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosicaoBranco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnPosicaoBranco.Location = new System.Drawing.Point(281, 321);
            this.btnPosicaoBranco.Name = "btnPosicaoBranco";
            this.btnPosicaoBranco.Size = new System.Drawing.Size(135, 65);
            this.btnPosicaoBranco.TabIndex = 15;
            this.btnPosicaoBranco.Text = "Posição Primeiro Espaço Branco";
            this.btnPosicaoBranco.UseVisualStyleBackColor = false;
            this.btnPosicaoBranco.Click += new System.EventHandler(this.btnPosicaoBranco_Click);
            // 
            // btnContarNumeros
            // 
            this.btnContarNumeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(83)))), ((int)(((byte)(92)))));
            this.btnContarNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContarNumeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(247)))));
            this.btnContarNumeros.Location = new System.Drawing.Point(90, 321);
            this.btnContarNumeros.Name = "btnContarNumeros";
            this.btnContarNumeros.Size = new System.Drawing.Size(135, 65);
            this.btnContarNumeros.TabIndex = 14;
            this.btnContarNumeros.Text = "Quantidade de Números";
            this.btnContarNumeros.UseVisualStyleBackColor = false;
            this.btnContarNumeros.Click += new System.EventHandler(this.btnContarNumeros_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(205)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnContarLetras);
            this.Controls.Add(this.btnPosicaoBranco);
            this.Controls.Add(this.btnContarNumeros);
            this.Controls.Add(this.rchTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTexto;
        private System.Windows.Forms.Button btnContarLetras;
        private System.Windows.Forms.Button btnPosicaoBranco;
        private System.Windows.Forms.Button btnContarNumeros;
    }
}