namespace prgrama0203
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
            this.btnenvio1 = new System.Windows.Forms.Button();
            this.txtmensage = new System.Windows.Forms.TextBox();
            this.btnenvio2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnenvio1
            // 
            this.btnenvio1.Location = new System.Drawing.Point(135, 35);
            this.btnenvio1.Name = "btnenvio1";
            this.btnenvio1.Size = new System.Drawing.Size(75, 23);
            this.btnenvio1.TabIndex = 0;
            this.btnenvio1.Text = "envio1";
            this.btnenvio1.UseVisualStyleBackColor = true;
            this.btnenvio1.Click += new System.EventHandler(this.btnenvio1_Click);
            // 
            // txtmensage
            // 
            this.txtmensage.Location = new System.Drawing.Point(12, 35);
            this.txtmensage.Name = "txtmensage";
            this.txtmensage.Size = new System.Drawing.Size(100, 22);
            this.txtmensage.TabIndex = 1;
            // 
            // btnenvio2
            // 
            this.btnenvio2.Location = new System.Drawing.Point(147, 100);
            this.btnenvio2.Name = "btnenvio2";
            this.btnenvio2.Size = new System.Drawing.Size(75, 23);
            this.btnenvio2.TabIndex = 2;
            this.btnenvio2.Text = "envio2";
            this.btnenvio2.UseVisualStyleBackColor = true;
            this.btnenvio2.Click += new System.EventHandler(this.btnenvio2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnenvio2);
            this.Controls.Add(this.txtmensage);
            this.Controls.Add(this.btnenvio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenvio1;
        private System.Windows.Forms.TextBox txtmensage;
        private System.Windows.Forms.Button btnenvio2;
    }
}

