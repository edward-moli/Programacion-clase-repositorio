namespace prgrama0203
{
    partial class Form2
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
            this.lblmensage = new System.Windows.Forms.Label();
            this.lnlComentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensage
            // 
            this.lblmensage.AutoSize = true;
            this.lblmensage.Location = new System.Drawing.Point(0, 0);
            this.lblmensage.Name = "lblmensage";
            this.lblmensage.Size = new System.Drawing.Size(44, 16);
            this.lblmensage.TabIndex = 0;
            this.lblmensage.Text = "label1";
            // 
            // lnlComentario
            // 
            this.lnlComentario.AutoSize = true;
            this.lnlComentario.Location = new System.Drawing.Point(123, 176);
            this.lnlComentario.Name = "lnlComentario";
            this.lnlComentario.Size = new System.Drawing.Size(44, 16);
            this.lnlComentario.TabIndex = 1;
            this.lnlComentario.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 369);
            this.Controls.Add(this.lnlComentario);
            this.Controls.Add(this.lblmensage);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensage;
        private System.Windows.Forms.Label lnlComentario;
    }
}