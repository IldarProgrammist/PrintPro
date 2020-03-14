namespace PrintPro.Forms
{
    partial class PrinteModelForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.IDLB = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PrinterFirmCB = new MetroFramework.Controls.MetroComboBox();
            this.PrinterModelNameTB = new MetroFramework.Controls.MetroTextBox();
            this.dgvprinterModels = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprinterModels)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.IDLB);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.PrinterFirmCB);
            this.metroPanel1.Controls.Add(this.PrinterModelNameTB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 72);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(494, 222);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(258, 153);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(97, 33);
            this.metroButton2.TabIndex = 10;
            this.metroButton2.Text = "Очистить";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Location = new System.Drawing.Point(155, 24);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(16, 19);
            this.IDLB.TabIndex = 9;
            this.IDLB.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(24, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "ID:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(155, 153);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(97, 33);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(117, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Фирма принтера:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Название модели:";
            // 
            // PrinterFirmCB
            // 
            this.PrinterFirmCB.FormattingEnabled = true;
            this.PrinterFirmCB.ItemHeight = 23;
            this.PrinterFirmCB.Location = new System.Drawing.Point(155, 103);
            this.PrinterFirmCB.Name = "PrinterFirmCB";
            this.PrinterFirmCB.Size = new System.Drawing.Size(159, 29);
            this.PrinterFirmCB.TabIndex = 3;
            this.PrinterFirmCB.UseSelectable = true;
            // 
            // PrinterModelNameTB
            // 
            // 
            // 
            // 
            this.PrinterModelNameTB.CustomButton.Image = null;
            this.PrinterModelNameTB.CustomButton.Location = new System.Drawing.Point(277, 1);
            this.PrinterModelNameTB.CustomButton.Name = "";
            this.PrinterModelNameTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterModelNameTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterModelNameTB.CustomButton.TabIndex = 1;
            this.PrinterModelNameTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterModelNameTB.CustomButton.UseSelectable = true;
            this.PrinterModelNameTB.CustomButton.Visible = false;
            this.PrinterModelNameTB.Lines = new string[0];
            this.PrinterModelNameTB.Location = new System.Drawing.Point(155, 57);
            this.PrinterModelNameTB.MaxLength = 32767;
            this.PrinterModelNameTB.Name = "PrinterModelNameTB";
            this.PrinterModelNameTB.PasswordChar = '\0';
            this.PrinterModelNameTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterModelNameTB.SelectedText = "";
            this.PrinterModelNameTB.SelectionLength = 0;
            this.PrinterModelNameTB.SelectionStart = 0;
            this.PrinterModelNameTB.ShortcutsEnabled = true;
            this.PrinterModelNameTB.Size = new System.Drawing.Size(299, 23);
            this.PrinterModelNameTB.TabIndex = 2;
            this.PrinterModelNameTB.UseSelectable = true;
            this.PrinterModelNameTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterModelNameTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvprinterModels
            // 
            this.dgvprinterModels.AllowUserToResizeRows = false;
            this.dgvprinterModels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvprinterModels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvprinterModels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvprinterModels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprinterModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvprinterModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvprinterModels.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvprinterModels.EnableHeadersVisualStyles = false;
            this.dgvprinterModels.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvprinterModels.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvprinterModels.Location = new System.Drawing.Point(23, 341);
            this.dgvprinterModels.Name = "dgvprinterModels";
            this.dgvprinterModels.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprinterModels.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvprinterModels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvprinterModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprinterModels.Size = new System.Drawing.Size(546, 172);
            this.dgvprinterModels.TabIndex = 3;
            this.dgvprinterModels.SelectionChanged += new System.EventHandler(this.dgvprinterModels_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 309);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Список моделей";
            // 
            // PrinteModel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 537);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvprinterModels);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PrinteModel_Form";
            this.Text = "Модель принтера";
            this.Load += new System.EventHandler(this.Printer_Firm_Form_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprinterModels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox PrinterFirmCB;
        private MetroFramework.Controls.MetroTextBox PrinterModelNameTB;
        private MetroFramework.Controls.MetroGrid dgvprinterModels;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroLabel IDLB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}