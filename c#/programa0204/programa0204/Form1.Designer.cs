namespace programa0204
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
            this.lnlmensaje = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnabrirforma = new System.Windows.Forms.Button();
            this.lblcontenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnlmensaje
            // 
            this.lnlmensaje.AutoSize = true;
            this.lnlmensaje.Location = new System.Drawing.Point(0, 0);
            this.lnlmensaje.Name = "lnlmensaje";
            this.lnlmensaje.Size = new System.Drawing.Size(63, 16);
            this.lnlmensaje.TabIndex = 0;
            this.lnlmensaje.Text = "++++++++";
            // 
            // btnabrirforma
            // 
            this.btnabrirforma.Location = new System.Drawing.Point(12, 59);
            this.btnabrirforma.Name = "btnabrirforma";
            this.btnabrirforma.Size = new System.Drawing.Size(105, 23);
            this.btnabrirforma.TabIndex = 1;
            this.btnabrirforma.Text = "abrir forma2";
            this.btnabrirforma.UseVisualStyleBackColor = true;
            this.btnabrirforma.Click += new System.EventHandler(this.btnabrirforma_Click);
            // 
            // lblcontenido
            // 
            this.lblcontenido.AutoSize = true;
            this.lblcontenido.Location = new System.Drawing.Point(163, 166);
            this.lblcontenido.Name = "lblcontenido";
            this.lblcontenido.Size = new System.Drawing.Size(18, 16);
            this.lblcontenido.TabIndex = 2;
            this.lblcontenido.Text = "la";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 349);
            this.Controls.Add(this.lblcontenido);
            this.Controls.Add(this.btnabrirforma);
            this.Controls.Add(this.lnlmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnlmensaje;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnabrirforma;
        private System.Windows.Forms.Label lblcontenido;
    }
}

