namespace programa0204
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.txtcontenido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(80, 59);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 0;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(12, 12);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(100, 22);
            this.txtmensaje.TabIndex = 1;
            // 
            // txtcontenido
            // 
            this.txtcontenido.Location = new System.Drawing.Point(144, 12);
            this.txtcontenido.Name = "txtcontenido";
            this.txtcontenido.Size = new System.Drawing.Size(100, 22);
            this.txtcontenido.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 319);
            this.Controls.Add(this.txtcontenido);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.btnsalir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.TextBox txtcontenido;
    }
}