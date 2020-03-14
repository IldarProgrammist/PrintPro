using PrintPro.Classes;
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
    public partial class CatrigeModelForm_ : MetroFramework.Forms.MetroForm
    {
        public CatrigeModelForm_()
        {
            InitializeComponent();
        }

        private void CatrigeModelForm__Load(object sender, EventArgs e)
        {
            WorkInCatrigeModel workInCatrigeModel = new WorkInCatrigeModel(CatrigeModelName,dgvCatrigeModel, ColorCB, CatrigeModelCB);

            workInCatrigeModel.LoadCatrigeModel();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WorkInCatrigeModel workInCatrigeModel = new WorkInCatrigeModel(CatrigeModelName, dgvCatrigeModel, ColorCB, CatrigeModelCB);
            workInCatrigeModel.createCatrigeModel(CatirgeModelLabID);
            workInCatrigeModel.LoadCatrigeModel();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            CatirgeModelLabID.Text = "0";
            CatrigeModelName.Text = string.Empty;
            CatrigeModelCB.SelectedIndex = -1;
            ColorCB.SelectedIndex = -1;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            WorkInCatrigeModel workInCatrigeModel = new WorkInCatrigeModel(CatrigeModelName, dgvCatrigeModel, ColorCB, CatrigeModelCB);
            workInCatrigeModel.deleteCatrigeModel(CatirgeModelLabID.Text);
        
        }

        private void dgvCatrigeModel_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dgvCatrigeModel.SelectedRows.Count > 0)
            {
                selectedRow = dgvCatrigeModel.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            CatirgeModelLabID.Text = selectedRow.Cells["CatrigeModelID"].Value.ToString();
            CatrigeModelName.Text = selectedRow.Cells["CatrigeName"].Value.ToString();
            CatrigeModelCB.SelectedIndex = CatrigeModelCB.FindStringExact(selectedRow.Cells["PrinterModelName"].Value.ToString());
            ColorCB.SelectedIndex = ColorCB.FindStringExact(selectedRow.Cells["ColorName"].Value.ToString());
        }
    }
}
