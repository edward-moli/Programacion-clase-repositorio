namespace programa0801
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
            this.components = new System.ComponentModel.Container();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnabrirnotepad = new System.Windows.Forms.Button();
            this.btncerrarnotepad = new System.Windows.Forms.Button();
            this.prcNotePad = new System.Diagnostics.Process();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(30, 90);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(74, 16);
            this.lblestado.TabIndex = 0;
            this.lblestado.Text = "Esperando";
            // 
            // btnabrirnotepad
            // 
            this.btnabrirnotepad.Location = new System.Drawing.Point(174, 66);
            this.btnabrirnotepad.Name = "btnabrirnotepad";
            this.btnabrirnotepad.Size = new System.Drawing.Size(105, 31);
            this.btnabrirnotepad.TabIndex = 1;
            this.btnabrirnotepad.Text = "abrir notepad";
            this.btnabrirnotepad.UseVisualStyleBackColor = true;
            this.btnabrirnotepad.Click += new System.EventHandler(this.btnabrirnotepad_Click);
            // 
            // btncerrarnotepad
            // 
            this.btncerrarnotepad.Location = new System.Drawing.Point(174, 112);
            this.btncerrarnotepad.Name = "btncerrarnotepad";
            this.btncerrarnotepad.Size = new System.Drawing.Size(105, 29);
            this.btncerrarnotepad.TabIndex = 2;
            this.btncerrarnotepad.Text = "cerrar notepad";
            this.btncerrarnotepad.UseVisualStyleBackColor = true;
            this.btncerrarnotepad.Click += new System.EventHandler(this.btncerrarnotepad_Click);
            // 
            // prcNotePad
            // 
            this.prcNotePad.StartInfo.Domain = "";
            this.prcNotePad.StartInfo.FileName = "notepad.exe";
            this.prcNotePad.StartInfo.LoadUserProfile = false;
            this.prcNotePad.StartInfo.Password = null;
            this.prcNotePad.StartInfo.StandardErrorEncoding = null;
            this.prcNotePad.StartInfo.StandardOutputEncoding = null;
            this.prcNotePad.StartInfo.UserName = "";
            this.prcNotePad.StartInfo.WorkingDirectory = "%system%System32";
            this.prcNotePad.SynchronizingObject = this;
            this.prcNotePad.Exited += new System.EventHandler(this.prcNotePad_Exited);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Abre aplicaciones";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.mostrarToolStripMenuItem.Text = "mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncerrarnotepad);
            this.Controls.Add(this.btnabrirnotepad);
            this.Controls.Add(this.lblestado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnabrirnotepad;
        private System.Windows.Forms.Button btncerrarnotepad;
        private System.Diagnostics.Process prcNotePad;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esconderToolStripMenuItem;
    }
}

