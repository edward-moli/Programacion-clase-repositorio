namespace progrma0701
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
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.helpProvider1.SetHelpString(this.txtmensaje, "coloca aqui el mensaje que deseas mostrar");
            this.txtmensaje.Location = new System.Drawing.Point(12, 12);
            this.txtmensaje.Name = "txtmensaje";
            this.helpProvider1.SetShowHelp(this.txtmensaje, true);
            this.txtmensaje.Size = new System.Drawing.Size(100, 22);
            this.txtmensaje.TabIndex = 0;
            // 
            // btnmostrar
            // 
            this.helpProvider1.SetHelpString(this.btnmostrar, "este mensaje permite mostrar el mesanje");
            this.btnmostrar.Location = new System.Drawing.Point(136, 12);
            this.btnmostrar.Name = "btnmostrar";
            this.helpProvider1.SetShowHelp(this.btnmostrar, true);
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(12, 65);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(44, 16);
            this.lblmensaje.TabIndex = 2;
            this.lblmensaje.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 335);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtmensaje);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lblmensaje;
    }
}

