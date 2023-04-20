namespace Aplicacion__video_7
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
            this.chkmonitor = new System.Windows.Forms.CheckBox();
            this.thkteclado = new System.Windows.Forms.CheckBox();
            this.chkmouse = new System.Windows.Forms.CheckBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lnlmensage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkmonitor
            // 
            this.chkmonitor.AutoSize = true;
            this.chkmonitor.Location = new System.Drawing.Point(0, 0);
            this.chkmonitor.Name = "chkmonitor";
            this.chkmonitor.Size = new System.Drawing.Size(104, 20);
            this.chkmonitor.TabIndex = 0;
            this.chkmonitor.Text = "monitor $250";
            this.chkmonitor.UseVisualStyleBackColor = true;
            this.chkmonitor.CheckedChanged += new System.EventHandler(this.chkmonitor_CheckedChanged);
            // 
            // thkteclado
            // 
            this.thkteclado.AutoSize = true;
            this.thkteclado.Location = new System.Drawing.Point(0, 37);
            this.thkteclado.Name = "thkteclado";
            this.thkteclado.Size = new System.Drawing.Size(98, 20);
            this.thkteclado.TabIndex = 1;
            this.thkteclado.Text = "teclado $15";
            this.thkteclado.UseVisualStyleBackColor = true;
            // 
            // chkmouse
            // 
            this.chkmouse.AutoSize = true;
            this.chkmouse.Location = new System.Drawing.Point(0, 75);
            this.chkmouse.Name = "chkmouse";
            this.chkmouse.Size = new System.Drawing.Size(94, 20);
            this.chkmouse.TabIndex = 2;
            this.chkmouse.Text = "mouse $20";
            this.chkmouse.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(163, 37);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lnlmensage
            // 
            this.lnlmensage.AutoSize = true;
            this.lnlmensage.Location = new System.Drawing.Point(212, 103);
            this.lnlmensage.Name = "lnlmensage";
            this.lnlmensage.Size = new System.Drawing.Size(44, 16);
            this.lnlmensage.TabIndex = 4;
            this.lnlmensage.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnlmensage);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.chkmouse);
            this.Controls.Add(this.thkteclado);
            this.Controls.Add(this.chkmonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkmonitor;
        private System.Windows.Forms.CheckBox thkteclado;
        private System.Windows.Forms.CheckBox chkmouse;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lnlmensage;
    }
}

