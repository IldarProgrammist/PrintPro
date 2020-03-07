namespace PrintPro
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.FrimAdd = new MetroFramework.Controls.MetroButton();
            this.PrinterFirmCB = new MetroFramework.Controls.MetroComboBox();
            this.PrinterModelTB = new MetroFramework.Controls.MetroTextBox();
            this.dvgListPrinter = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.PrinterModelIDLB = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListPrinter)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(184, 134);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 40);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.PrinterModelIDLB);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.FrimAdd);
            this.metroPanel1.Controls.Add(this.PrinterFirmCB);
            this.metroPanel1.Controls.Add(this.SaveBtn);
            this.metroPanel1.Controls.Add(this.PrinterModelTB);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(77, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(555, 197);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FrimAdd
            // 
            this.FrimAdd.Location = new System.Drawing.Point(423, 89);
            this.FrimAdd.Name = "FrimAdd";
            this.FrimAdd.Size = new System.Drawing.Size(116, 27);
            this.FrimAdd.TabIndex = 14;
            this.FrimAdd.Text = "Добавить фирму";
            this.FrimAdd.UseSelectable = true;
            // 
            // PrinterFirmCB
            // 
            this.PrinterFirmCB.FormattingEnabled = true;
            this.PrinterFirmCB.ItemHeight = 23;
            this.PrinterFirmCB.Location = new System.Drawing.Point(184, 87);
            this.PrinterFirmCB.Name = "PrinterFirmCB";
            this.PrinterFirmCB.Size = new System.Drawing.Size(232, 29);
            this.PrinterFirmCB.TabIndex = 13;
            this.PrinterFirmCB.UseSelectable = true;
            // 
            // PrinterModelTB
            // 
            // 
            // 
            // 
            this.PrinterModelTB.CustomButton.Image = null;
            this.PrinterModelTB.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.PrinterModelTB.CustomButton.Name = "";
            this.PrinterModelTB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrinterModelTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrinterModelTB.CustomButton.TabIndex = 1;
            this.PrinterModelTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrinterModelTB.CustomButton.UseSelectable = true;
            this.PrinterModelTB.CustomButton.Visible = false;
            this.PrinterModelTB.Lines = new string[0];
            this.PrinterModelTB.Location = new System.Drawing.Point(184, 46);
            this.PrinterModelTB.MaxLength = 32767;
            this.PrinterModelTB.Name = "PrinterModelTB";
            this.PrinterModelTB.PasswordChar = '\0';
            this.PrinterModelTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrinterModelTB.SelectedText = "";
            this.PrinterModelTB.SelectionLength = 0;
            this.PrinterModelTB.SelectionStart = 0;
            this.PrinterModelTB.ShortcutsEnabled = true;
            this.PrinterModelTB.Size = new System.Drawing.Size(232, 23);
            this.PrinterModelTB.TabIndex = 12;
            this.PrinterModelTB.UseSelectable = true;
            this.PrinterModelTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrinterModelTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dvgListPrinter
            // 
            this.dvgListPrinter.AllowUserToResizeRows = false;
            this.dvgListPrinter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgListPrinter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgListPrinter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgListPrinter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgListPrinter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgListPrinter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgListPrinter.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgListPrinter.EnableHeadersVisualStyles = false;
            this.dvgListPrinter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgListPrinter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgListPrinter.Location = new System.Drawing.Point(77, 312);
            this.dvgListPrinter.Name = "dvgListPrinter";
            this.dvgListPrinter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgListPrinter.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgListPrinter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgListPrinter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgListPrinter.Size = new System.Drawing.Size(332, 189);
            this.dvgListPrinter.TabIndex = 15;
            this.dvgListPrinter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgListPrinter_CellContentClick_1);
            this.dvgListPrinter.SelectionChanged += new System.EventHandler(this.dvgListPrinter_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(77, 275);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 25);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Все модели";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(27, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(151, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Индинтификатор:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(27, 43);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 25);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Модель принтера:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(33, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 25);
            this.metroLabel4.TabIndex = 17;
            this.metroLabel4.Text = "Фирма:";
            // 
            // PrinterModelIDLB
            // 
            this.PrinterModelIDLB.AutoSize = true;
            this.PrinterModelIDLB.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PrinterModelIDLB.Location = new System.Drawing.Point(184, 10);
            this.PrinterModelIDLB.Name = "PrinterModelIDLB";
            this.PrinterModelIDLB.Size = new System.Drawing.Size(21, 25);
            this.PrinterModelIDLB.TabIndex = 18;
            this.PrinterModelIDLB.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 524);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dvgListPrinter);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListPrinter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton FrimAdd;
        private MetroFramework.Controls.MetroComboBox PrinterFirmCB;
        private MetroFramework.Controls.MetroTextBox PrinterModelTB;
        private MetroFramework.Controls.MetroGrid dvgListPrinter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel PrinterModelIDLB;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

