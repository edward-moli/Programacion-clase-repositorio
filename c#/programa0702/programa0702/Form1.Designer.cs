namespace programa0702
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
            this.mtxtdato = new System.Windows.Forms.MaskedTextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mtxtdato
            // 
            this.mtxtdato.Location = new System.Drawing.Point(0, 0);
            this.mtxtdato.Mask = "00/00/LL";
            this.mtxtdato.Name = "mtxtdato";
            this.mtxtdato.Size = new System.Drawing.Size(75, 22);
            this.mtxtdato.TabIndex = 0;
            this.mtxtdato.ValidatingType = typeof(System.DateTime);
            this.mtxtdato.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtdato_MaskInputRejected);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(101, 0);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(12, 34);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(44, 16);
            this.lblmensaje.TabIndex = 2;
            this.lblmensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 158);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.mtxtdato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtdato;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lblmensaje;
    }
}

