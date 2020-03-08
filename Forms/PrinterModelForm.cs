using PrintPro.Classes;
using PrintPro.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro
{
    public partial class PrinterModelForm : MetroFramework.Forms.MetroForm
    {
        public PrinterModelForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          WorkInPrinterModel workInPrinterModel = new WorkInPrinterModel();
         
                
              workInPrinterModel.AllModelPrinters(dvgListPrinter, PrinterFirmCB);
            PrinterModelTB.Text = "";  
            PrinterModelIDLB.Text="0";
            PrinterFirmCB.SelectedIndex = -1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkInPrinterModel workInPrinterModel = new WorkInPrinterModel();
            workInPrinterModel.createPrinterModel(PrinterModelIDLB,PrinterModelTB, PrinterFirmCB);
            workInPrinterModel.AllModelPrinters(dvgListPrinter, PrinterFirmCB);
        }

        private void dvgListPrinter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgListPrinter_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgListPrinter_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            
            if(dvgListPrinter.SelectedRows.Count>0)
            {
                selectedRow = dvgListPrinter.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            PrinterModelIDLB.Text = selectedRow.Cells["PrinterModelID"].Value.ToString();
            PrinterModelTB.Text = selectedRow.Cells["PrinterModelName"].Value.ToString();
            PrinterFirmCB.SelectedIndex = PrinterFirmCB.FindStringExact(selectedRow.Cells["PrinterFirm"].Value.ToString());

        }

        private void ClerarBtn_Click(object sender, EventArgs e)
        {
            PrinterModelIDLB.Text = "";
            PrinterModelTB.Text = string.Empty;
            PrinterFirmCB.SelectedIndex = 0;
        }

        private void FrimAdd_Click(object sender, EventArgs e)
        {
            PrinterFirmForm printerFirmForm = new PrinterFirmForm();
            printerFirmForm.Show(this);
        }
    }
}
