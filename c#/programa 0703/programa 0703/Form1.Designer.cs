namespace programa_0703
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
            this.btnabrir = new System.Windows.Forms.Button();
            this.lblabrir = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(12, 26);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(75, 23);
            this.btnabrir.TabIndex = 0;
            this.btnabrir.Text = "abrir";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // lblabrir
            // 
            this.lblabrir.AutoSize = true;
            this.lblabrir.Location = new System.Drawing.Point(21, 75);
            this.lblabrir.Name = "lblabrir";
            this.lblabrir.Size = new System.Drawing.Size(44, 16);
            this.lblabrir.TabIndex = 1;
            this.lblabrir.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 204);
            this.Controls.Add(this.lblabrir);
            this.Controls.Add(this.btnabrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Label lblabrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

