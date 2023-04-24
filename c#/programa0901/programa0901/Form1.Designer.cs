namespace programa0901
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
            this.btninvalidar = new System.Windows.Forms.Button();
            this.btndibujar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninvalidar
            // 
            this.btninvalidar.Location = new System.Drawing.Point(311, 25);
            this.btninvalidar.Name = "btninvalidar";
            this.btninvalidar.Size = new System.Drawing.Size(75, 23);
            this.btninvalidar.TabIndex = 0;
            this.btninvalidar.Text = "invalidar";
            this.btninvalidar.UseVisualStyleBackColor = true;
            this.btninvalidar.Click += new System.EventHandler(this.btninvalidar_Click);
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(311, 72);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(75, 23);
            this.btndibujar.TabIndex = 1;
            this.btndibujar.Text = "dibujar";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 410);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.btninvalidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninvalidar;
        private System.Windows.Forms.Button btndibujar;
    }
}

