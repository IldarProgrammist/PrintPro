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
            workInCatrigeModel.createCatrigeModel(CatirgeModelLab);
            workInCatrigeModel.LoadCatrigeModel();
        }
    }
}
