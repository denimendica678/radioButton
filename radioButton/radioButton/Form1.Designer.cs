namespace radioButton
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
            this.vrstaPrijevoza = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioBtnAvion = new System.Windows.Forms.RadioButton();
            this.radioBtnVlastitiPrijevoz = new System.Windows.Forms.RadioButton();
            this.radioBtnAutobus = new System.Windows.Forms.RadioButton();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtIspisOdabira = new System.Windows.Forms.TextBox();
            this.vrstaPrijevoza.SuspendLayout();
            this.SuspendLayout();
            // 
            // vrstaPrijevoza
            // 
            this.vrstaPrijevoza.Controls.Add(this.radioBtnVlastitiPrijevoz);
            this.vrstaPrijevoza.Controls.Add(this.radioBtnAutobus);
            this.vrstaPrijevoza.Controls.Add(this.radioBtnAvion);
            this.vrstaPrijevoza.Location = new System.Drawing.Point(302, 12);
            this.vrstaPrijevoza.Name = "vrstaPrijevoza";
            this.vrstaPrijevoza.Size = new System.Drawing.Size(188, 174);
            this.vrstaPrijevoza.TabIndex = 0;
            this.vrstaPrijevoza.TabStop = false;
            this.vrstaPrijevoza.Text = "Odaberite vrstu prijevoza";
            // 
            // radioBtnAvion
            // 
            this.radioBtnAvion.AutoSize = true;
            this.radioBtnAvion.Location = new System.Drawing.Point(32, 37);
            this.radioBtnAvion.Name = "radioBtnAvion";
            this.radioBtnAvion.Size = new System.Drawing.Size(64, 21);
            this.radioBtnAvion.TabIndex = 0;
            this.radioBtnAvion.TabStop = true;
            this.radioBtnAvion.Text = "Avion";
            this.radioBtnAvion.UseVisualStyleBackColor = true;
            // 
            // radioBtnVlastitiPrijevoz
            // 
            this.radioBtnVlastitiPrijevoz.AutoSize = true;
            this.radioBtnVlastitiPrijevoz.Location = new System.Drawing.Point(32, 115);
            this.radioBtnVlastitiPrijevoz.Name = "radioBtnVlastitiPrijevoz";
            this.radioBtnVlastitiPrijevoz.Size = new System.Drawing.Size(123, 21);
            this.radioBtnVlastitiPrijevoz.TabIndex = 1;
            this.radioBtnVlastitiPrijevoz.TabStop = true;
            this.radioBtnVlastitiPrijevoz.Text = "Vlastiti prijevoz";
            this.radioBtnVlastitiPrijevoz.UseVisualStyleBackColor = true;
            // 
            // radioBtnAutobus
            // 
            this.radioBtnAutobus.AutoSize = true;
            this.radioBtnAutobus.Location = new System.Drawing.Point(32, 78);
            this.radioBtnAutobus.Name = "radioBtnAutobus";
            this.radioBtnAutobus.Size = new System.Drawing.Size(81, 21);
            this.radioBtnAutobus.TabIndex = 2;
            this.radioBtnAutobus.TabStop = true;
            this.radioBtnAutobus.Text = "Autobus";
            this.radioBtnAutobus.UseVisualStyleBackColor = true;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(302, 209);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(188, 23);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtIspisOdabira
            // 
            this.txtIspisOdabira.Location = new System.Drawing.Point(302, 255);
            this.txtIspisOdabira.Multiline = true;
            this.txtIspisOdabira.Name = "txtIspisOdabira";
            this.txtIspisOdabira.Size = new System.Drawing.Size(188, 59);
            this.txtIspisOdabira.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspisOdabira);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.vrstaPrijevoza);
            this.Name = "Form1";
            this.Text = "Upotreba RadioButton kontrole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.vrstaPrijevoza.ResumeLayout(false);
            this.vrstaPrijevoza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox vrstaPrijevoza;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioBtnVlastitiPrijevoz;
        private System.Windows.Forms.RadioButton radioBtnAutobus;
        private System.Windows.Forms.RadioButton radioBtnAvion;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtIspisOdabira;
    }
}

