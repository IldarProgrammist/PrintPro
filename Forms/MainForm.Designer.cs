namespace PrintPro.Forms
{
    partial class MainForm
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
            this.Printers = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Printers
            // 
            this.Printers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Printers.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Printers.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Printers.Location = new System.Drawing.Point(20, 60);
            this.Printers.Name = "Printers";
            this.Printers.Size = new System.Drawing.Size(713, 85);
            this.Printers.TabIndex = 1;
            this.Printers.Text = "Принтеры";
            this.Printers.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(20, 145);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(713, 85);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Картриджи";
            this.metroButton2.UseSelectable = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 508);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Printers);
            this.Name = "MainForm";
            this.Text = "Учет картриджей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton Printers;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}