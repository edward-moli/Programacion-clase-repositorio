namespace vd28
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
            this.dupfrutas = new System.Windows.Forms.DomainUpDown();
            this.txtfruta = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dupfrutas
            // 
            this.dupfrutas.Location = new System.Drawing.Point(0, 0);
            this.dupfrutas.Name = "dupfrutas";
            this.dupfrutas.Size = new System.Drawing.Size(120, 22);
            this.dupfrutas.TabIndex = 0;
            this.dupfrutas.Text = "frutas";
            this.dupfrutas.SelectedItemChanged += new System.EventHandler(this.dupfrutas_SelectedItemChanged);
            // 
            // txtfruta
            // 
            this.txtfruta.Location = new System.Drawing.Point(0, 39);
            this.txtfruta.Name = "txtfruta";
            this.txtfruta.Size = new System.Drawing.Size(100, 22);
            this.txtfruta.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(141, 12);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(12, 83);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(44, 16);
            this.lblmensaje.TabIndex = 3;
            this.lblmensaje.Text = "label1";
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(141, 41);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 4;
            this.btnborrar.Text = "borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtfruta);
            this.Controls.Add(this.dupfrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DomainUpDown dupfrutas;
        private System.Windows.Forms.TextBox txtfruta;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnborrar;
    }
}

