namespace Programa0502
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
            this.cmbalimentos = new System.Windows.Forms.ComboBox();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.ldlindice = new System.Windows.Forms.Label();
            this.ldltexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbalimentos
            // 
            this.cmbalimentos.FormattingEnabled = true;
            this.cmbalimentos.Items.AddRange(new object[] {
            "Frijol",
            "tomate"});
            this.cmbalimentos.Location = new System.Drawing.Point(12, 64);
            this.cmbalimentos.Name = "cmbalimentos";
            this.cmbalimentos.Size = new System.Drawing.Size(121, 24);
            this.cmbalimentos.TabIndex = 0;
            this.cmbalimentos.Text = "alimentos";
            this.cmbalimentos.SelectedIndexChanged += new System.EventHandler(this.cmbalimentos_SelectedIndexChanged);
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(12, 104);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(100, 22);
            this.txtalimento.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(180, 84);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // ldlindice
            // 
            this.ldlindice.AutoSize = true;
            this.ldlindice.Location = new System.Drawing.Point(12, 176);
            this.ldlindice.Name = "ldlindice";
            this.ldlindice.Size = new System.Drawing.Size(44, 16);
            this.ldlindice.TabIndex = 3;
            this.ldlindice.Text = "label1";
            // 
            // ldltexto
            // 
            this.ldltexto.AutoSize = true;
            this.ldltexto.Location = new System.Drawing.Point(12, 142);
            this.ldltexto.Name = "ldltexto";
            this.ldltexto.Size = new System.Drawing.Size(44, 16);
            this.ldltexto.TabIndex = 4;
            this.ldltexto.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ldltexto);
            this.Controls.Add(this.ldlindice);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtalimento);
            this.Controls.Add(this.cmbalimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbalimentos;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label ldlindice;
        private System.Windows.Forms.Label ldltexto;
    }
}

