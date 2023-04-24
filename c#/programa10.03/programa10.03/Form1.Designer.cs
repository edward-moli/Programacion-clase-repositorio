namespace programa10._03
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(0, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(44, 16);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "label1";
            // 
            // txtcontenido
            // 
            this.txtcontenido.AllowDrop = true;
            this.txtcontenido.Location = new System.Drawing.Point(22, 38);
            this.txtcontenido.Multiline = true;
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtcontenido.Size = new System.Drawing.Size(289, 226);
            this.txtcontenido.TabIndex = 1;
            this.txtcontenido.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtcontenido_DragDrop);
            this.txtcontenido.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtcontenido_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.lblArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.TextBox txtcontenido;
    }
}

