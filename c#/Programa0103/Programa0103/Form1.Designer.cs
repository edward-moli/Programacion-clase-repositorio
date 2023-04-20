namespace Programa0103
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btndivicion = new System.Windows.Forms.Button();
            this.btnmultiplcacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 35);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 69);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 16);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(90, 113);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(44, 16);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "label1";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(34, 35);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 3;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(34, 66);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 4;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(179, 35);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(32, 22);
            this.btnsuma.TabIndex = 5;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(226, 36);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(38, 21);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btndivicion
            // 
            this.btndivicion.Location = new System.Drawing.Point(226, 69);
            this.btndivicion.Name = "btndivicion";
            this.btndivicion.Size = new System.Drawing.Size(38, 21);
            this.btndivicion.TabIndex = 8;
            this.btndivicion.Text = "/";
            this.btndivicion.UseVisualStyleBackColor = true;
            this.btndivicion.Click += new System.EventHandler(this.btndivicion_Click);
            // 
            // btnmultiplcacion
            // 
            this.btnmultiplcacion.Location = new System.Drawing.Point(179, 68);
            this.btnmultiplcacion.Name = "btnmultiplcacion";
            this.btnmultiplcacion.Size = new System.Drawing.Size(32, 22);
            this.btnmultiplcacion.TabIndex = 7;
            this.btnmultiplcacion.Text = "*";
            this.btnmultiplcacion.UseVisualStyleBackColor = true;
            this.btnmultiplcacion.Click += new System.EventHandler(this.btnmultiplcacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 193);
            this.Controls.Add(this.btndivicion);
            this.Controls.Add(this.btnmultiplcacion);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btndivicion;
        private System.Windows.Forms.Button btnmultiplcacion;
    }
}

