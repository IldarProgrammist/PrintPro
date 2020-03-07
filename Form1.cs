using PrintPro.Classes;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          WorkInPrinterModel workInPrinterModel = new WorkInPrinterModel();
          
              workInPrinterModel.AllModelPrinters(dvgListPrinter, PrinterFirmCB);
            //workInPrinterModel.printerModelSelect(PrinterFirmCB);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkInPrinterModel workInPrinterModel = new WorkInPrinterModel();
            //workInPrinterModel.createPrinterModel(PrinterModelTB, PrinterFirmCB);
          //  workInPrinterModel.AllModelPrinters(dvgListPrinter);
        }
    }
}
