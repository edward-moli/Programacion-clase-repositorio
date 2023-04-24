namespace prgrama0803
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
            this.txtfreq = new System.Windows.Forms.TextBox();
            this.txtdura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbeep = new System.Windows.Forms.Button();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnsistema = new System.Windows.Forms.Button();
            this.btntono = new System.Windows.Forms.Button();
            this.btntocar = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtfreq
            // 
            this.txtfreq.Location = new System.Drawing.Point(107, 55);
            this.txtfreq.Name = "txtfreq";
            this.txtfreq.Size = new System.Drawing.Size(100, 22);
            this.txtfreq.TabIndex = 0;
            this.txtfreq.Text = "3000";
            // 
            // txtdura
            // 
            this.txtdura.Location = new System.Drawing.Point(107, 104);
            this.txtdura.Name = "txtdura";
            this.txtdura.Size = new System.Drawing.Size(100, 22);
            this.txtdura.TabIndex = 1;
            this.txtdura.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "freb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "dura";
            // 
            // btnbeep
            // 
            this.btnbeep.Location = new System.Drawing.Point(301, 32);
            this.btnbeep.Name = "btnbeep";
            this.btnbeep.Size = new System.Drawing.Size(75, 23);
            this.btnbeep.TabIndex = 4;
            this.btnbeep.Text = "beep";
            this.btnbeep.UseVisualStyleBackColor = true;
            this.btnbeep.Click += new System.EventHandler(this.btnbeep_Click);
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(107, 190);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 5;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // btnsistema
            // 
            this.btnsistema.Location = new System.Drawing.Point(301, 117);
            this.btnsistema.Name = "btnsistema";
            this.btnsistema.Size = new System.Drawing.Size(75, 23);
            this.btnsistema.TabIndex = 6;
            this.btnsistema.Text = "sistema";
            this.btnsistema.UseVisualStyleBackColor = true;
            this.btnsistema.Click += new System.EventHandler(this.btnsistema_Click);
            // 
            // btntono
            // 
            this.btntono.Location = new System.Drawing.Point(301, 88);
            this.btntono.Name = "btntono";
            this.btntono.Size = new System.Drawing.Size(75, 23);
            this.btntono.TabIndex = 7;
            this.btntono.Text = "tono";
            this.btntono.UseVisualStyleBackColor = true;
            this.btntono.Click += new System.EventHandler(this.btntono_Click);
            // 
            // btntocar
            // 
            this.btntocar.Location = new System.Drawing.Point(301, 181);
            this.btntocar.Name = "btntocar";
            this.btntocar.Size = new System.Drawing.Size(75, 23);
            this.btntocar.TabIndex = 8;
            this.btntocar.Text = "tocar";
            this.btntocar.UseVisualStyleBackColor = true;
            this.btntocar.Click += new System.EventHandler(this.btntocar_Click);
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Location = new System.Drawing.Point(104, 237);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(44, 16);
            this.lblruta.TabIndex = 9;
            this.lblruta.Text = "label3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Wav.|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 315);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btntocar);
            this.Controls.Add(this.btntono);
            this.Controls.Add(this.btnsistema);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.btnbeep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdura);
            this.Controls.Add(this.txtfreq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfreq;
        private System.Windows.Forms.TextBox txtdura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbeep;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnsistema;
        private System.Windows.Forms.Button btntono;
        private System.Windows.Forms.Button btntocar;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

