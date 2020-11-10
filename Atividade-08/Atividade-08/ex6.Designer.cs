namespace Atividade_08
{
    partial class ex6
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
            this.btnCalcularMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularMedia
            // 
            this.btnCalcularMedia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMedia.Location = new System.Drawing.Point(270, 250);
            this.btnCalcularMedia.Name = "btnCalcularMedia";
            this.btnCalcularMedia.Size = new System.Drawing.Size(159, 42);
            this.btnCalcularMedia.TabIndex = 0;
            this.btnCalcularMedia.Text = "Calcular Média";
            this.btnCalcularMedia.UseVisualStyleBackColor = true;
            this.btnCalcularMedia.Click += new System.EventHandler(this.btnCalcularMedia_Click);
            // 
            // ex6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btnCalcularMedia);
            this.Name = "ex6";
            this.Text = "ex6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularMedia;
    }
}