namespace Ejercicio_11
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblseguro = new System.Windows.Forms.Label();
            this.rnbasico = new System.Windows.Forms.RadioButton();
            this.rbnterceros = new System.Windows.Forms.RadioButton();
            this.rbntotal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBEquipo = new System.Windows.Forms.GroupBox();
            this.lblequipo = new System.Windows.Forms.Label();
            this.chkaire = new System.Windows.Forms.CheckBox();
            this.chkaudio = new System.Windows.Forms.CheckBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.btncotizar = new System.Windows.Forms.Button();
            this.txtcotizacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gBEquipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(71, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 0;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 16);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "nombre";
            // 
            // lblseguro
            // 
            this.lblseguro.AutoSize = true;
            this.lblseguro.Location = new System.Drawing.Point(6, 35);
            this.lblseguro.Name = "lblseguro";
            this.lblseguro.Size = new System.Drawing.Size(49, 16);
            this.lblseguro.TabIndex = 2;
            this.lblseguro.Text = "seguro";
            // 
            // rnbasico
            // 
            this.rnbasico.AutoSize = true;
            this.rnbasico.Checked = true;
            this.rnbasico.Location = new System.Drawing.Point(19, 72);
            this.rnbasico.Name = "rnbasico";
            this.rnbasico.Size = new System.Drawing.Size(69, 20);
            this.rnbasico.TabIndex = 3;
            this.rnbasico.TabStop = true;
            this.rnbasico.Text = "basico";
            this.rnbasico.UseVisualStyleBackColor = true;
            // 
            // rbnterceros
            // 
            this.rbnterceros.AutoSize = true;
            this.rbnterceros.Location = new System.Drawing.Point(19, 98);
            this.rbnterceros.Name = "rbnterceros";
            this.rbnterceros.Size = new System.Drawing.Size(89, 20);
            this.rbnterceros.TabIndex = 4;
            this.rbnterceros.Text = "A terceros";
            this.rbnterceros.UseVisualStyleBackColor = true;
            // 
            // rbntotal
            // 
            this.rbntotal.AutoSize = true;
            this.rbntotal.Location = new System.Drawing.Point(19, 124);
            this.rbntotal.Name = "rbntotal";
            this.rbntotal.Size = new System.Drawing.Size(59, 20);
            this.rbntotal.TabIndex = 5;
            this.rbntotal.Text = "Total";
            this.rbntotal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnterceros);
            this.groupBox1.Controls.Add(this.lblseguro);
            this.groupBox1.Controls.Add(this.rbntotal);
            this.groupBox1.Controls.Add(this.rnbasico);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "seguros a seleccionar";
            // 
            // gBEquipo
            // 
            this.gBEquipo.Controls.Add(this.chkaudio);
            this.gBEquipo.Controls.Add(this.chkaire);
            this.gBEquipo.Controls.Add(this.lblequipo);
            this.gBEquipo.Location = new System.Drawing.Point(269, 46);
            this.gBEquipo.Name = "gBEquipo";
            this.gBEquipo.Size = new System.Drawing.Size(227, 184);
            this.gBEquipo.TabIndex = 6;
            this.gBEquipo.TabStop = false;
            this.gBEquipo.Text = "equipo de audio";
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(6, 35);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(49, 16);
            this.lblequipo.TabIndex = 3;
            this.lblequipo.Text = "equipo";
            // 
            // chkaire
            // 
            this.chkaire.AutoSize = true;
            this.chkaire.Location = new System.Drawing.Point(9, 54);
            this.chkaire.Name = "chkaire";
            this.chkaire.Size = new System.Drawing.Size(146, 20);
            this.chkaire.TabIndex = 4;
            this.chkaire.Text = "Aire acondicionado";
            this.chkaire.UseVisualStyleBackColor = true;
            // 
            // chkaudio
            // 
            this.chkaudio.AutoSize = true;
            this.chkaudio.Location = new System.Drawing.Point(9, 80);
            this.chkaudio.Name = "chkaudio";
            this.chkaudio.Size = new System.Drawing.Size(132, 20);
            this.chkaudio.TabIndex = 5;
            this.chkaudio.Text = "sistema de audio";
            this.chkaudio.UseVisualStyleBackColor = true;
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Location = new System.Drawing.Point(28, 260);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(40, 16);
            this.lblcosto.TabIndex = 7;
            this.lblcosto.Text = "costo";
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(85, 260);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(100, 22);
            this.txtcosto.TabIndex = 8;
            // 
            // btncotizar
            // 
            this.btncotizar.Location = new System.Drawing.Point(266, 260);
            this.btncotizar.Name = "btncotizar";
            this.btncotizar.Size = new System.Drawing.Size(75, 23);
            this.btncotizar.TabIndex = 9;
            this.btncotizar.Text = "cotizar";
            this.btncotizar.UseVisualStyleBackColor = true;
            this.btncotizar.Click += new System.EventHandler(this.btncotizar_Click);
            // 
            // txtcotizacion
            // 
            this.txtcotizacion.Location = new System.Drawing.Point(31, 305);
            this.txtcotizacion.Multiline = true;
            this.txtcotizacion.Name = "txtcotizacion";
            this.txtcotizacion.Size = new System.Drawing.Size(462, 118);
            this.txtcotizacion.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcotizacion);
            this.Controls.Add(this.btncotizar);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.gBEquipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBEquipo.ResumeLayout(false);
            this.gBEquipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblseguro;
        private System.Windows.Forms.RadioButton rnbasico;
        private System.Windows.Forms.RadioButton rbnterceros;
        private System.Windows.Forms.RadioButton rbntotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBEquipo;
        private System.Windows.Forms.CheckBox chkaudio;
        private System.Windows.Forms.CheckBox chkaire;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Button btncotizar;
        private System.Windows.Forms.TextBox txtcotizacion;
    }
}

