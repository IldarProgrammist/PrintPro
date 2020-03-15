namespace PrintPro.Forms
{
    partial class LocationForm
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
            this.dgvPrinterLocation = new MetroFramework.Controls.MetroGrid();
            this.LabID = new MetroFramework.Controls.MetroLabel();
            this.TitulTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.RoomTB = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrinterLocation
            // 
            this.dgvPrinterLocation.AllowUserToResizeRows = false;
            this.dgvPrinterLocation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterLocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrinterLocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterLocation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrinterLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrinterLocation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrinterLocation.EnableHeadersVisualStyles = false;
            this.dgvPrinterLocation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPrinterLocation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPrinterLocation.Location = new System.Drawing.Point(54, 284);
            this.dgvPrinterLocation.Name = "dgvPrinterLocation";
            this.dgvPrinterLocation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrinterLocation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrinterLocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrinterLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinterLocation.Size = new System.Drawing.Size(301, 134);
            this.dgvPrinterLocation.TabIndex = 0;
            this.dgvPrinterLocation.SelectionChanged += new System.EventHandler(this.dgvPrinterLocation_SelectionChanged);
            // 
            // LabID
            // 
            this.LabID.AutoSize = true;
            this.LabID.Location = new System.Drawing.Point(173, 78);
            this.LabID.Name = "LabID";
            this.LabID.Size = new System.Drawing.Size(16, 19);
            this.LabID.TabIndex = 1;
            this.LabID.Text = "0";
            // 
            // TitulTB
            // 
            // 
            // 
            // 
            this.TitulTB.CustomButton.Image = null;
            this.TitulTB.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.TitulTB.CustomButton.Name = "";
            this.TitulTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TitulTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TitulTB.CustomButton.TabIndex = 1;
            this.TitulTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TitulTB.CustomButton.UseSelectable = true;
            this.TitulTB.CustomButton.Visible = false;
            this.TitulTB.Lines = new string[0];
            this.TitulTB.Location = new System.Drawing.Point(173, 112);
            this.TitulTB.MaxLength = 32767;
            this.TitulTB.Name = "TitulTB";
            this.TitulTB.PasswordChar = '\0';
            this.TitulTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TitulTB.SelectedText = "";
            this.TitulTB.SelectionLength = 0;
            this.TitulTB.SelectionStart = 0;
            this.TitulTB.ShortcutsEnabled = true;
            this.TitulTB.Size = new System.Drawing.Size(279, 23);
            this.TitulTB.TabIndex = 2;
            this.TitulTB.UseSelectable = true;
            this.TitulTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TitulTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Титул:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(69, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Кабинет:";
            // 
            // RoomTB
            // 
            // 
            // 
            // 
            this.RoomTB.CustomButton.Image = null;
            this.RoomTB.CustomButton.Location = new System.Drawing.Point(257, 1);
            this.RoomTB.CustomButton.Name = "";
            this.RoomTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RoomTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RoomTB.CustomButton.TabIndex = 1;
            this.RoomTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RoomTB.CustomButton.UseSelectable = true;
            this.RoomTB.CustomButton.Visible = false;
            this.RoomTB.Lines = new string[0];
            this.RoomTB.Location = new System.Drawing.Point(173, 158);
            this.RoomTB.MaxLength = 32767;
            this.RoomTB.Name = "RoomTB";
            this.RoomTB.PasswordChar = '\0';
            this.RoomTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RoomTB.SelectedText = "";
            this.RoomTB.SelectionLength = 0;
            this.RoomTB.SelectionStart = 0;
            this.RoomTB.ShortcutsEnabled = true;
            this.RoomTB.Size = new System.Drawing.Size(279, 23);
            this.RoomTB.TabIndex = 5;
            this.RoomTB.UseSelectable = true;
            this.RoomTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RoomTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 44);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(331, 219);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 44);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Удалить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.RoomTB);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TitulTB);
            this.Controls.Add(this.LabID);
            this.Controls.Add(this.dgvPrinterLocation);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            this.Load += new System.EventHandler(this.LocationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvPrinterLocation;
        private MetroFramework.Controls.MetroLabel LabID;
        private MetroFramework.Controls.MetroTextBox TitulTB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox RoomTB;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}