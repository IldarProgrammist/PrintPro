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

namespace PrintPro.Forms
{
    public partial class PrintersForm : MetroFramework.Forms.MetroForm
    {
        public PrintersForm()
        {
            InitializeComponent();
        }

        private void PrintersForm_Load(object sender, EventArgs e)
        {
            WorkInPrinter workInPrinter = new WorkInPrinter(dgvPrinters);
            workInPrinter.LoadPrinter();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
