namespace programa0101
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
            this.btnsaludo = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btndespedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsaludo
            // 
            this.btnsaludo.Location = new System.Drawing.Point(0, 0);
            this.btnsaludo.Name = "btnsaludo";
            this.btnsaludo.Size = new System.Drawing.Size(75, 23);
            this.btnsaludo.TabIndex = 0;
            this.btnsaludo.Text = "Saludo";
            this.btnsaludo.UseVisualStyleBackColor = true;
            this.btnsaludo.Click += new System.EventHandler(this.btnsaludo_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(104, 9);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(44, 16);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "label1";
            // 
            // btndespedida
            // 
            this.btndespedida.Location = new System.Drawing.Point(0, 44);
            this.btndespedida.Name = "btndespedida";
            this.btndespedida.Size = new System.Drawing.Size(85, 24);
            this.btndespedida.TabIndex = 2;
            this.btndespedida.Text = "despedida";
            this.btndespedida.UseVisualStyleBackColor = true;
            this.btndespedida.Click += new System.EventHandler(this.btndespedida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndespedida);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnsaludo);
            this.Name = "Form1";
            this.Text = "Programa01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaludo;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btndespedida;
    }
}

