namespace Pograma0501
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
            this.chkboxelementos = new System.Windows.Forms.CheckedListBox();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkboxelementos
            // 
            this.chkboxelementos.CheckOnClick = true;
            this.chkboxelementos.FormattingEnabled = true;
            this.chkboxelementos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.chkboxelementos.Location = new System.Drawing.Point(0, 12);
            this.chkboxelementos.Name = "chkboxelementos";
            this.chkboxelementos.Size = new System.Drawing.Size(121, 106);
            this.chkboxelementos.TabIndex = 1;
            this.chkboxelementos.SelectedIndexChanged += new System.EventHandler(this.chkboxelementos_SelectedIndexChanged);
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(-19, 222);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(100, 22);
            this.txtalimento.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(115, 181);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(167, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 351);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtalimento);
            this.Controls.Add(this.chkboxelementos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkboxelementos;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblNombre;
    }
}

