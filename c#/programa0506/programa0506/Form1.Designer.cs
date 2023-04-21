namespace programa0506
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
            this.picimagen = new System.Windows.Forms.PictureBox();
            this.btncargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picimagen
            // 
            this.picimagen.Image = global::programa0506.Properties.Resources._137343;
            this.picimagen.Location = new System.Drawing.Point(60, 56);
            this.picimagen.Name = "picimagen";
            this.picimagen.Size = new System.Drawing.Size(157, 118);
            this.picimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picimagen.TabIndex = 0;
            this.picimagen.TabStop = false;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(0, 0);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 1;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.picimagen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picimagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picimagen;
        private System.Windows.Forms.Button btncargar;
    }
}

