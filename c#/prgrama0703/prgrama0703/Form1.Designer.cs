namespace prgrama0703
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblinicion = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.btnfechas = new System.Windows.Forms.Button();
            this.lblseleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 5, 1, 0, 0, 0, 0)};
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2023, 4, 15, 0, 0, 0, 0)};
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblinicion
            // 
            this.lblinicion.AutoSize = true;
            this.lblinicion.Location = new System.Drawing.Point(24, 216);
            this.lblinicion.Name = "lblinicion";
            this.lblinicion.Size = new System.Drawing.Size(44, 16);
            this.lblinicion.TabIndex = 1;
            this.lblinicion.Text = "label1";
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(114, 216);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(44, 16);
            this.lblfinal.TabIndex = 2;
            this.lblfinal.Text = "label2";
            // 
            // btnfechas
            // 
            this.btnfechas.Location = new System.Drawing.Point(302, 12);
            this.btnfechas.Name = "btnfechas";
            this.btnfechas.Size = new System.Drawing.Size(156, 23);
            this.btnfechas.TabIndex = 3;
            this.btnfechas.Text = "seleccionar fechas";
            this.btnfechas.UseVisualStyleBackColor = true;
            this.btnfechas.Click += new System.EventHandler(this.btnfechas_Click);
            // 
            // lblseleccion
            // 
            this.lblseleccion.AutoSize = true;
            this.lblseleccion.Location = new System.Drawing.Point(216, 313);
            this.lblseleccion.Name = "lblseleccion";
            this.lblseleccion.Size = new System.Drawing.Size(44, 16);
            this.lblseleccion.TabIndex = 4;
            this.lblseleccion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 385);
            this.Controls.Add(this.lblseleccion);
            this.Controls.Add(this.btnfechas);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblinicion);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblinicion;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Button btnfechas;
        private System.Windows.Forms.Label lblseleccion;
    }
}

