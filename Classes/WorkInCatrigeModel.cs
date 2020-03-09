using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPro.Classes
{
    public class WorkInCatrigeModel
    {
       
        private int CatrigeModelID { get; set; }
        private int ColorID { get; set; }
        private MetroTextBox CatrigeModelName { get; set; }
        private MetroGrid Dgv { get; set; }
        private MetroComboBox ColorCB { get; set; }
        private MetroComboBox PrinterModelCB { get; set; }


        public WorkInCatrigeModel(MetroTextBox catrigeModelName, MetroGrid dgv, MetroComboBox colorCB, MetroComboBox printerModelCB)
        {
            CatrigeModelName = catrigeModelName;
            Dgv = dgv;
            ColorCB = colorCB;
            PrinterModelCB = printerModelCB; 
        }


        public void LoadCatrigeModel()
        {
            using(ContextModel db = new ContextModel())
            {
                var selectAll = from cm in db.CatrigeModels
                                select new 
                                {
                                    cm.CatrigeModelID,
                                    
                                    cm.CatrigeName,
                                    cm.Color.ColorName,
                                    cm.PrinterModel.PrinterFirm.PrinterFirmName,
                                    cm.PrinterModel.PrinterModelName
                                };


                ColorCB.DisplayMember = "ColorName";
                ColorCB.ValueMember = "ColorID";
   
                PrinterModelCB.DisplayMember = "PrinterModelName";
                PrinterModelCB.ValueMember = "PrinterModelID";

                ColorCB.DataSource = db.Colors.ToList();
                PrinterModelCB.DataSource = db.PrinterModels.ToList();

             
               
                Dgv.DataSource = selectAll.ToList();
            }
        }

        public void createCatrigeModel(MetroLabel LabID)
        {
            CatrigeModelID = Convert.ToInt32(LabID.Text);

            using(ContextModel db = new ContextModel())
            {
                if (CatrigeModelID == 0)
                {
                    CatrigeModel catrigeModel = new CatrigeModel
                    {
                        CatrigeName = CatrigeModelName.Text,
                        ColorID = Convert.ToInt32(ColorCB.SelectedValue),
                        PrinterModelID = Convert.ToInt32(PrinterModelCB.SelectedValue)
                    };
                    db.CatrigeModels.Add(catrigeModel);
                }
                else
                {
                    var cmUptade =  db.CatrigeModels.SingleOrDefault(c => c.CatrigeModelID == CatrigeModelID);
                    var cUpdate  =  db.CatrigeModels.SingleOrDefault(x=>x.ColorID == ColorID);  
                    if(cmUptade != null)
                    {
                        cmUptade.CatrigeName = CatrigeModelName.Text;
                        cmUptade.ColorID = Convert.ToInt32(ColorCB.SelectedValue);
                        cUpdate.CatrigeModelID = Convert.ToInt32(PrinterModelCB.SelectedValue);
                    }
                   
                }
                db.SaveChanges();
            }

        }
    }
}
