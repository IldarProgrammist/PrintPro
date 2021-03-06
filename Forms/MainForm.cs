﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PrinterFirmForm printerFirmForm = new PrinterFirmForm();
            printerFirmForm.Show();
        }

        private void Printers_Click(object sender, EventArgs e)
        {
            PrinteModelForm printeModel_Form = new PrinteModelForm();
            printeModel_Form.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CatrigeModelForm_ catrigeModelForm_ = new CatrigeModelForm_();
            catrigeModelForm_.Show();
        }
    }
}
