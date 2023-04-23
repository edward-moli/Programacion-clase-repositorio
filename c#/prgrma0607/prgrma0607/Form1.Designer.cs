namespace prgrma0607
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
            this.lblmensajes = new System.Windows.Forms.Label();
            this.btnfuente = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // lblmensajes
            // 
            this.lblmensajes.AutoSize = true;
            this.lblmensajes.Location = new System.Drawing.Point(57, 97);
            this.lblmensajes.Name = "lblmensajes";
            this.lblmensajes.Size = new System.Drawing.Size(81, 16);
            this.lblmensajes.TabIndex = 0;
            this.lblmensajes.Text = "hola a todos";
            // 
            // btnfuente
            // 
            this.btnfuente.Location = new System.Drawing.Point(175, 97);
            this.btnfuente.Name = "btnfuente";
            this.btnfuente.Size = new System.Drawing.Size(75, 23);
            this.btnfuente.TabIndex = 1;
            this.btnfuente.Text = "fuente";
            this.btnfuente.UseVisualStyleBackColor = true;
            this.btnfuente.Click += new System.EventHandler(this.btnfuente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 371);
            this.Controls.Add(this.btnfuente);
            this.Controls.Add(this.lblmensajes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensajes;
        private System.Windows.Forms.Button btnfuente;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

