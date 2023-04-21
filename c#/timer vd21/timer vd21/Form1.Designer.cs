namespace timer_vd21
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblvalor = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.btndetener = new System.Windows.Forms.Button();
            this.tbrintervalo = new System.Windows.Forms.TrackBar();
            this.tlblvalor = new System.Windows.Forms.Label();
            this.Pbrtrabajo = new System.Windows.Forms.ProgressBar();
            this.btncalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrintervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(48, 63);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(44, 16);
            this.lblvalor.TabIndex = 0;
            this.lblvalor.Text = "label1";
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(146, 31);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(75, 23);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "inicio";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // btndetener
            // 
            this.btndetener.Location = new System.Drawing.Point(146, 77);
            this.btndetener.Name = "btndetener";
            this.btndetener.Size = new System.Drawing.Size(75, 23);
            this.btndetener.TabIndex = 2;
            this.btndetener.Text = "detener";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // tbrintervalo
            // 
            this.tbrintervalo.Location = new System.Drawing.Point(12, 123);
            this.tbrintervalo.Maximum = 1000;
            this.tbrintervalo.Minimum = 100;
            this.tbrintervalo.Name = "tbrintervalo";
            this.tbrintervalo.Size = new System.Drawing.Size(309, 56);
            this.tbrintervalo.TabIndex = 3;
            this.tbrintervalo.TickFrequency = 100;
            this.tbrintervalo.Value = 100;
            this.tbrintervalo.Scroll += new System.EventHandler(this.tbrintervalo_Scroll);
            // 
            // tlblvalor
            // 
            this.tlblvalor.AutoSize = true;
            this.tlblvalor.Location = new System.Drawing.Point(12, 163);
            this.tlblvalor.Name = "tlblvalor";
            this.tlblvalor.Size = new System.Drawing.Size(44, 16);
            this.tlblvalor.TabIndex = 4;
            this.tlblvalor.Text = "label1";
            // 
            // Pbrtrabajo
            // 
            this.Pbrtrabajo.Location = new System.Drawing.Point(15, 163);
            this.Pbrtrabajo.Name = "Pbrtrabajo";
            this.Pbrtrabajo.Size = new System.Drawing.Size(306, 23);
            this.Pbrtrabajo.TabIndex = 5;
            // 
            // btncalculo
            // 
            this.btncalculo.Location = new System.Drawing.Point(137, 224);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(75, 23);
            this.btncalculo.TabIndex = 6;
            this.btncalculo.Text = "calcular";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.btncalculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 272);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.Pbrtrabajo);
            this.Controls.Add(this.tlblvalor);
            this.Controls.Add(this.tbrintervalo);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.lblvalor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbrintervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button btndetener;
        private System.Windows.Forms.TrackBar tbrintervalo;
        private System.Windows.Forms.Label tlblvalor;
        private System.Windows.Forms.ProgressBar Pbrtrabajo;
        private System.Windows.Forms.Button btncalculo;
    }
}

