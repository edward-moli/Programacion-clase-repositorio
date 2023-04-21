namespace programa0505
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
            this.lsbfrutas = new System.Windows.Forms.ListBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.txtfruta = new System.Windows.Forms.TextBox();
            this.lblfruta = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbfrutas
            // 
            this.lsbfrutas.FormattingEnabled = true;
            this.lsbfrutas.ItemHeight = 16;
            this.lsbfrutas.Items.AddRange(new object[] {
            "Manzana",
            "Aguacate",
            "Pera"});
            this.lsbfrutas.Location = new System.Drawing.Point(0, 0);
            this.lsbfrutas.Name = "lsbfrutas";
            this.lsbfrutas.Size = new System.Drawing.Size(120, 84);
            this.lsbfrutas.TabIndex = 0;
            this.lsbfrutas.SelectedIndexChanged += new System.EventHandler(this.lsbfrutas_SelectedIndexChanged);
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(158, 52);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // txtfruta
            // 
            this.txtfruta.Location = new System.Drawing.Point(145, 12);
            this.txtfruta.Name = "txtfruta";
            this.txtfruta.Size = new System.Drawing.Size(100, 22);
            this.txtfruta.TabIndex = 2;
            // 
            // lblfruta
            // 
            this.lblfruta.AutoSize = true;
            this.lblfruta.Location = new System.Drawing.Point(39, 166);
            this.lblfruta.Name = "lblfruta";
            this.lblfruta.Size = new System.Drawing.Size(44, 16);
            this.lblfruta.TabIndex = 3;
            this.lblfruta.Text = "label1";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(158, 107);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblfruta);
            this.Controls.Add(this.txtfruta);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.lsbfrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbfrutas;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.TextBox txtfruta;
        private System.Windows.Forms.Label lblfruta;
        private System.Windows.Forms.Button btneliminar;
    }
}

