namespace PrintPro.Forms
{
    partial class PrintersForm
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
            this.dgvPrinters = new MetroFramework.Controls.MetroGrid();
            this.PrinterID = new MetroFramework.Controls.MetroLabel();
            this.PrinterSerialNamber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.StatusCB = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinters)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrinters
            // 
            this.dgvPrinters.AllowUserToResizeRows = false;
            this.dgvPrinters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrinters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinters.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrinters.EnableHeadersVisualStyles = false;
            this.dgvPrinters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinters.Location = new System.Drawing.Point(67, 317);
            this.dgvPrinters.Name = "dgvPrinters";
            this.dgvPrinters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrinters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinters.Size = new System.Drawing.Size(729, 187);
            this.dgvPrinters.TabIndex = 0;
            this.dgvPrinters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // PrinterID
            // 
            this.PrinterID.AutoSize = true;
            this.PrinterID.Location = new System.Drawing.Point(218, 69);
            this.PrinterID.Name = "PrinterID";
            this.PrinterID.Size = new System.Drawing.Size(16, 19);
            this.PrinterID.TabIndex = 1;
            this.PrinterID.Text = "0";
            // 
            // PrinterSerialNamber
            // 
            // 
            // 
            // 
            this.PrinterSerialNamber.CustomButton.Image = null;
            this.PrinterSerialNamber.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.PrinterSerialNamber.CustomButton.Name = "";
            this.PrinterSerialNamber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterSerialNamber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterSerialNamber.CustomButton.TabIndex = 1;
            this.PrinterSerialNamber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterSerialNamber.CustomButton.UseSelectable = true;
            this.PrinterSerialNamber.CustomButton.Visible = false;
            this.PrinterSerialNamber.Lines = new string[0];
            this.PrinterSerialNamber.Location = new System.Drawing.Point(218, 102);
            this.PrinterSerialNamber.MaxLength = 32767;
            this.PrinterSerialNamber.Name = "PrinterSerialNamber";
            this.PrinterSerialNamber.PasswordChar = '\0';
            this.PrinterSerialNamber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterSerialNamber.SelectedText = "";
            this.PrinterSerialNamber.SelectionLength = 0;
            this.PrinterSerialNamber.SelectionStart = 0;
            this.PrinterSerialNamber.ShortcutsEnabled = true;
            this.PrinterSerialNamber.Size = new System.Drawing.Size(226, 23);
            this.PrinterSerialNamber.TabIndex = 2;
            this.PrinterSerialNamber.UseSelectable = true;
            this.PrinterSerialNamber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterSerialNamber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(67, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Серийный номер:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(218, 152);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(226, 29);
            this.metroComboBox1.TabIndex = 4;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(67, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(145, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Место расположение:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(67, 217);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Статус:";
            // 
            // StatusCB
            // 
            this.StatusCB.FormattingEnabled = true;
            this.StatusCB.ItemHeight = 23;
            this.StatusCB.Location = new System.Drawing.Point(218, 212);
            this.StatusCB.Name = "StatusCB";
            this.StatusCB.Size = new System.Drawing.Size(226, 29);
            this.StatusCB.TabIndex = 6;
            this.StatusCB.UseSelectable = true;
            // 
            // PrintersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 563);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.StatusCB);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PrinterSerialNamber);
            this.Controls.Add(this.PrinterID);
            this.Controls.Add(this.dgvPrinters);
            this.Name = "PrintersForm";
            this.Text = "Принтеры";
            this.Load += new System.EventHandler(this.PrintersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvPrinters;
        private MetroFramework.Controls.MetroLabel PrinterID;
        private MetroFramework.Controls.MetroTextBox PrinterSerialNamber;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox StatusCB;
    }
}