namespace programa0802
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtciruela = new System.Windows.Forms.RadioButton();
            this.rbtpera = new System.Windows.Forms.RadioButton();
            this.rbtmanzana = new System.Windows.Forms.RadioButton();
            this.chkimportado = new System.Windows.Forms.CheckBox();
            this.chkorganico = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(12, 12);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(100, 22);
            this.txtmensaje.TabIndex = 0;
            this.txtmensaje.TextChanged += new System.EventHandler(this.txtmensaje_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtciruela);
            this.groupBox1.Controls.Add(this.rbtpera);
            this.groupBox1.Controls.Add(this.rbtmanzana);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbtciruela
            // 
            this.rbtciruela.AutoSize = true;
            this.rbtciruela.Location = new System.Drawing.Point(3, 70);
            this.rbtciruela.Name = "rbtciruela";
            this.rbtciruela.Size = new System.Drawing.Size(68, 20);
            this.rbtciruela.TabIndex = 2;
            this.rbtciruela.Text = "ciruela";
            this.rbtciruela.UseVisualStyleBackColor = true;
            this.rbtciruela.CheckedChanged += new System.EventHandler(this.rbtciruela_CheckedChanged);
            // 
            // rbtpera
            // 
            this.rbtpera.AutoSize = true;
            this.rbtpera.Location = new System.Drawing.Point(3, 44);
            this.rbtpera.Name = "rbtpera";
            this.rbtpera.Size = new System.Drawing.Size(56, 20);
            this.rbtpera.TabIndex = 1;
            this.rbtpera.Text = "pera";
            this.rbtpera.UseVisualStyleBackColor = true;
            this.rbtpera.CheckedChanged += new System.EventHandler(this.rbtpera_CheckedChanged);
            // 
            // rbtmanzana
            // 
            this.rbtmanzana.AutoSize = true;
            this.rbtmanzana.Checked = true;
            this.rbtmanzana.Location = new System.Drawing.Point(3, 18);
            this.rbtmanzana.Name = "rbtmanzana";
            this.rbtmanzana.Size = new System.Drawing.Size(83, 20);
            this.rbtmanzana.TabIndex = 0;
            this.rbtmanzana.TabStop = true;
            this.rbtmanzana.Text = "manzana";
            this.rbtmanzana.UseVisualStyleBackColor = true;
            this.rbtmanzana.CheckedChanged += new System.EventHandler(this.rbtmanzana_CheckedChanged);
            // 
            // chkimportado
            // 
            this.chkimportado.AutoSize = true;
            this.chkimportado.Location = new System.Drawing.Point(244, 84);
            this.chkimportado.Name = "chkimportado";
            this.chkimportado.Size = new System.Drawing.Size(90, 20);
            this.chkimportado.TabIndex = 2;
            this.chkimportado.Text = "importado";
            this.chkimportado.UseVisualStyleBackColor = true;
            // 
            // chkorganico
            // 
            this.chkorganico.AutoSize = true;
            this.chkorganico.Location = new System.Drawing.Point(244, 110);
            this.chkorganico.Name = "chkorganico";
            this.chkorganico.Size = new System.Drawing.Size(82, 20);
            this.chkorganico.TabIndex = 3;
            this.chkorganico.Text = "organico";
            this.chkorganico.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkorganico);
            this.Controls.Add(this.chkimportado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtciruela;
        private System.Windows.Forms.RadioButton rbtpera;
        private System.Windows.Forms.RadioButton rbtmanzana;
        private System.Windows.Forms.CheckBox chkimportado;
        private System.Windows.Forms.CheckBox chkorganico;
    }
}

