﻿using PrintPro.Classes;
using PrintPro.Models;
using System;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class PrinterFirmForm : MetroFramework.Forms.MetroForm
    {   
        public PrinterFirmForm()
        {
            InitializeComponent();

        }

        //очистить
        private void metroButton2_Click(object sender, EventArgs e)
        {
            PrinterFirmIDLB.Text = "0";
            PrinterFirmTB.Text = "";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WorkInPrinterFirm workInPrinterFirm = new WorkInPrinterFirm(dgvFirm);
            workInPrinterFirm.createPrinterFirm(PrinterFirmIDLB.Text, PrinterFirmTB.Text);

        }

        private void PrinterFirmForm_Load(object sender, EventArgs e)
        {
            WorkInPrinterFirm workInPrinterFirm = new WorkInPrinterFirm(dgvFirm);
            workInPrinterFirm.LoadFirm();
            PrinterFirmIDLB.Text = "0";
            PrinterFirmTB.Text = "";

        }


        private void dgvFirm_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvFirm.SelectedRows.Count > 0)
            {
                selectedRow = dgvFirm.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            PrinterFirmIDLB.Text = selectedRow.Cells["PritnerFirmID"].Value.ToString();
            PrinterFirmTB.Text = selectedRow.Cells["PrinterFirmName"].Value.ToString();
        }

        private void DeleteFirm_Click(object sender, EventArgs e)
        {
            WorkInPrinterFirm workInPrinterFirm = new WorkInPrinterFirm(dgvFirm);
            
            PrinterFirmForm printerFimForm = new PrinterFirmForm();

            MessageBox.Show("Вы уверены что хотите удалить данную фирму?", "Удаление", MessageBoxButtons.YesNo);
            workInPrinterFirm.deleteFirm(PrinterFirmIDLB.Text);
            workInPrinterFirm.LoadFirm();









        }
    }
}
