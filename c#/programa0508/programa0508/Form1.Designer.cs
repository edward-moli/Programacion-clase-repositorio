namespace programa0508
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
            this.lsvalimentos = new System.Windows.Forms.ListView();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.grboxgrupos = new System.Windows.Forms.GroupBox();
            this.rbtfrutas = new System.Windows.Forms.RadioButton();
            this.rbtcarne = new System.Windows.Forms.RadioButton();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lblseleccionado = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.grboxgrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvalimentos
            // 
            this.lsvalimentos.HideSelection = false;
            this.lsvalimentos.Location = new System.Drawing.Point(0, 0);
            this.lsvalimentos.Name = "lsvalimentos";
            this.lsvalimentos.Size = new System.Drawing.Size(316, 228);
            this.lsvalimentos.TabIndex = 0;
            this.lsvalimentos.UseCompatibleStateImageBehavior = false;
            this.lsvalimentos.View = System.Windows.Forms.View.SmallIcon;
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(38, 286);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(100, 22);
            this.txtelemento.TabIndex = 1;
            // 
            // grboxgrupos
            // 
            this.grboxgrupos.Controls.Add(this.btnadicionar);
            this.grboxgrupos.Controls.Add(this.rbtcarne);
            this.grboxgrupos.Controls.Add(this.rbtfrutas);
            this.grboxgrupos.Location = new System.Drawing.Point(176, 262);
            this.grboxgrupos.Name = "grboxgrupos";
            this.grboxgrupos.Size = new System.Drawing.Size(200, 100);
            this.grboxgrupos.TabIndex = 2;
            this.grboxgrupos.TabStop = false;
            this.grboxgrupos.Text = "grupos";
            // 
            // rbtfrutas
            // 
            this.rbtfrutas.AutoSize = true;
            this.rbtfrutas.Checked = true;
            this.rbtfrutas.Location = new System.Drawing.Point(3, 18);
            this.rbtfrutas.Name = "rbtfrutas";
            this.rbtfrutas.Size = new System.Drawing.Size(60, 20);
            this.rbtfrutas.TabIndex = 0;
            this.rbtfrutas.TabStop = true;
            this.rbtfrutas.Text = "frutas";
            this.rbtfrutas.UseVisualStyleBackColor = true;
            // 
            // rbtcarne
            // 
            this.rbtcarne.AutoSize = true;
            this.rbtcarne.Location = new System.Drawing.Point(6, 44);
            this.rbtcarne.Name = "rbtcarne";
            this.rbtcarne.Size = new System.Drawing.Size(69, 20);
            this.rbtcarne.TabIndex = 3;
            this.rbtcarne.Text = "carnes";
            this.rbtcarne.UseVisualStyleBackColor = true;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(110, 24);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 4;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lblseleccionado
            // 
            this.lblseleccionado.AutoSize = true;
            this.lblseleccionado.Location = new System.Drawing.Point(345, 88);
            this.lblseleccionado.Name = "lblseleccionado";
            this.lblseleccionado.Size = new System.Drawing.Size(44, 16);
            this.lblseleccionado.TabIndex = 3;
            this.lblseleccionado.Text = "label1";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(348, 189);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.lblseleccionado);
            this.Controls.Add(this.grboxgrupos);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.lsvalimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grboxgrupos.ResumeLayout(false);
            this.grboxgrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvalimentos;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.GroupBox grboxgrupos;
        private System.Windows.Forms.RadioButton rbtcarne;
        private System.Windows.Forms.RadioButton rbtfrutas;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lblseleccionado;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

