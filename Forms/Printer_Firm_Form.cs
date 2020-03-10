using PrintPro.Models;
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
    public partial class Printer_Firm_Form : MetroFramework.Forms.MetroForm
    {
        public Printer_Firm_Form()
        {
            InitializeComponent();
        }

        private void Printer_Firm_Form_Load(object sender, EventArgs e)
        {

            LoadPrinterModel();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int PrinterModelID;

            PrinterModelID = Convert.ToInt32(IDLB.Text);

            using (ContextModel db = new ContextModel())
            {
                if (PrinterModelID == 0)
                {
                    PrinterModel printerModels = new PrinterModel
                    {
                        PrinterModelName = PrinterModelNameTB.Text.Trim(),
                        PrinterFirmID = Convert.ToInt32(PrinterFirmCB.SelectedValue)
                    };
                    db.PrinterModels.Add(printerModels);
                }
                else
                {
                    var mpToUpdate = db.PrinterModels.SingleOrDefault(pm => pm.PrinterModelID == PrinterModelID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterModelName = PrinterModelNameTB.Text;
                        mpToUpdate.PrinterFirmID = Convert.ToInt32(PrinterFirmCB.SelectedValue);
                    }
                }
                db.SaveChanges();   
            }
            LoadPrinterModel();
        }

    
        private void LoadPrinterModel()
        {
           

            using (var db = new Models.ContextModel())
            {
                PrinterFirmCB.DataSource = db.PrinterFirms.ToList();
                PrinterFirmCB.ValueMember = "PritnerFirmID";
                PrinterFirmCB.DisplayMember = "PrinterFirmName";
                var printerModels = from pm in db.PrinterModels
                                    select new
                                    {   pm.PrinterModelID,
                                        pm.PrinterModelName,
                                        PrinterFirm = pm.PrinterFirm.PrinterFirmName
                                    };
                dgvprinterModels.DataSource = printerModels.ToList();

            }

        }

        private void dgvprinterModels_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if(dgvprinterModels.SelectedRows.Count>0)
            {
                selectedRow = dgvprinterModels.SelectedRows[0];
            }
            if (selectedRow == null)
                return;
            IDLB.Text = selectedRow.Cells["PrinterModelID"].Value.ToString();
            PrinterModelNameTB.Text = selectedRow.Cells["PrinterModelName"].Value.ToString();
            PrinterFirmCB.SelectedIndex = PrinterFirmCB.FindStringExact(selectedRow.Cells["PrinterFirm"].Value.ToString());


            
        }
    }
}
