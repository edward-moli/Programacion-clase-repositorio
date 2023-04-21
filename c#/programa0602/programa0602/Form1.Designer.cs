namespace programa0602
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
            this.btnoperaciones = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnoperaciones
            // 
            this.btnoperaciones.Location = new System.Drawing.Point(93, 111);
            this.btnoperaciones.Name = "btnoperaciones";
            this.btnoperaciones.Size = new System.Drawing.Size(115, 32);
            this.btnoperaciones.TabIndex = 0;
            this.btnoperaciones.Text = "operaciones";
            this.btnoperaciones.UseVisualStyleBackColor = true;
            this.btnoperaciones.Click += new System.EventHandler(this.btnoperaciones_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(0, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(44, 16);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 344);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.btnoperaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnoperaciones;
        private System.Windows.Forms.Label lblfecha;
    }
}

