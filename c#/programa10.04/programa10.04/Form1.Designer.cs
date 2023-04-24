namespace programa10._04
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
            this.btnatras = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnrecargar = new System.Windows.Forms.Button();
            this.btnalto = new System.Windows.Forms.Button();
            this.btnir = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(0, 12);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(23, 23);
            this.btnatras.TabIndex = 0;
            this.btnatras.Text = "<";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(29, 12);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(23, 23);
            this.btnsiguiente.TabIndex = 1;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnrecargar
            // 
            this.btnrecargar.Location = new System.Drawing.Point(58, 12);
            this.btnrecargar.Name = "btnrecargar";
            this.btnrecargar.Size = new System.Drawing.Size(23, 23);
            this.btnrecargar.TabIndex = 2;
            this.btnrecargar.Text = "R";
            this.btnrecargar.UseVisualStyleBackColor = true;
            this.btnrecargar.Click += new System.EventHandler(this.btnrecargar_Click);
            // 
            // btnalto
            // 
            this.btnalto.Location = new System.Drawing.Point(87, 12);
            this.btnalto.Name = "btnalto";
            this.btnalto.Size = new System.Drawing.Size(23, 23);
            this.btnalto.TabIndex = 3;
            this.btnalto.Text = "S";
            this.btnalto.UseVisualStyleBackColor = true;
            this.btnalto.Click += new System.EventHandler(this.btnalto_Click);
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(500, 12);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(23, 23);
            this.btnir.TabIndex = 4;
            this.btnir.Text = "ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(116, 12);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(23, 23);
            this.btnhome.TabIndex = 5;
            this.btnhome.Text = "H";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(145, 13);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(349, 22);
            this.txturl.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(511, 368);
            this.webBrowser1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 446);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnir);
            this.Controls.Add(this.btnalto);
            this.Controls.Add(this.btnrecargar);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnatras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnrecargar;
        private System.Windows.Forms.Button btnalto;
        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

