namespace PrintPro.Forms
{
    partial class CatrigeModelForm_
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
            this.ColorCB = new MetroFramework.Controls.MetroComboBox();
            this.CatrigeModelCB = new MetroFramework.Controls.MetroComboBox();
            this.CatrigeModelName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dgvCatrigeModel = new MetroFramework.Controls.MetroGrid();
            this.CatirgeModelLabID = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatrigeModel)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorCB
            // 
            this.ColorCB.FormattingEnabled = true;
            this.ColorCB.ItemHeight = 23;
            this.ColorCB.Location = new System.Drawing.Point(191, 210);
            this.ColorCB.Name = "ColorCB";
            this.ColorCB.Size = new System.Drawing.Size(354, 29);
            this.ColorCB.TabIndex = 0;
            this.ColorCB.UseSelectable = true;
            // 
            // CatrigeModelCB
            // 
            this.CatrigeModelCB.FormattingEnabled = true;
            this.CatrigeModelCB.ItemHeight = 23;
            this.CatrigeModelCB.Location = new System.Drawing.Point(191, 148);
            this.CatrigeModelCB.Name = "CatrigeModelCB";
            this.CatrigeModelCB.Size = new System.Drawing.Size(354, 29);
            this.CatrigeModelCB.TabIndex = 1;
            this.CatrigeModelCB.UseSelectable = true;
            // 
            // CatrigeModelName
            // 
            // 
            // 
            // 
            this.CatrigeModelName.CustomButton.Image = null;
            this.CatrigeModelName.CustomButton.Location = new System.Drawing.Point(332, 1);
            this.CatrigeModelName.CustomButton.Name = "";
            this.CatrigeModelName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.CatrigeModelName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CatrigeModelName.CustomButton.TabIndex = 1;
            this.CatrigeModelName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CatrigeModelName.CustomButton.UseSelectable = true;
            this.CatrigeModelName.CustomButton.Visible = false;
            this.CatrigeModelName.Lines = new string[0];
            this.CatrigeModelName.Location = new System.Drawing.Point(191, 91);
            this.CatrigeModelName.MaxLength = 32767;
            this.CatrigeModelName.Name = "CatrigeModelName";
            this.CatrigeModelName.PasswordChar = '\0';
            this.CatrigeModelName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CatrigeModelName.SelectedText = "";
            this.CatrigeModelName.SelectionLength = 0;
            this.CatrigeModelName.SelectionStart = 0;
            this.CatrigeModelName.ShortcutsEnabled = true;
            this.CatrigeModelName.Size = new System.Drawing.Size(354, 23);
            this.CatrigeModelName.TabIndex = 2;
            this.CatrigeModelName.UseSelectable = true;
            this.CatrigeModelName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CatrigeModelName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Название картриджа:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(114, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Модель прнтера:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Цвет:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(191, 257);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 32);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Сохранить";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(313, 257);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(113, 32);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Очистить";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dgvCatrigeModel
            // 
            this.dgvCatrigeModel.AllowUserToResizeRows = false;
            this.dgvCatrigeModel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatrigeModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatrigeModel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCatrigeModel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatrigeModel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatrigeModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatrigeModel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatrigeModel.EnableHeadersVisualStyles = false;
            this.dgvCatrigeModel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCatrigeModel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCatrigeModel.Location = new System.Drawing.Point(76, 357);
            this.dgvCatrigeModel.Name = "dgvCatrigeModel";
            this.dgvCatrigeModel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatrigeModel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatrigeModel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCatrigeModel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatrigeModel.Size = new System.Drawing.Size(548, 150);
            this.dgvCatrigeModel.TabIndex = 8;
            this.dgvCatrigeModel.SelectionChanged += new System.EventHandler(this.dgvCatrigeModel_SelectionChanged);
            // 
            // CatirgeModelLabID
            // 
            this.CatirgeModelLabID.AutoSize = true;
            this.CatirgeModelLabID.Location = new System.Drawing.Point(191, 50);
            this.CatirgeModelLabID.Name = "CatirgeModelLabID";
            this.CatirgeModelLabID.Size = new System.Drawing.Size(16, 19);
            this.CatirgeModelLabID.TabIndex = 9;
            this.CatirgeModelLabID.Text = "0";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(432, 257);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(113, 32);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Удалить";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // CatrigeModelForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 545);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.CatirgeModelLabID);
            this.Controls.Add(this.dgvCatrigeModel);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CatrigeModelName);
            this.Controls.Add(this.CatrigeModelCB);
            this.Controls.Add(this.ColorCB);
            this.Name = "CatrigeModelForm_";
            this.Load += new System.EventHandler(this.CatrigeModelForm__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatrigeModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ColorCB;
        private MetroFramework.Controls.MetroComboBox CatrigeModelCB;
        private MetroFramework.Controls.MetroTextBox CatrigeModelName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid dgvCatrigeModel;
        private MetroFramework.Controls.MetroLabel CatirgeModelLabID;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}