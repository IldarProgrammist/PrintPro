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
    public  class WorkInPrinterModel
    {        
        //Все модели принтеров
        public void AllModelPrinters(DataGridView dgv,MetroComboBox printerFrimcb)
        {
            using (ContextModel db = new ContextModel())
            {
                printerFrimcb.DataSource = db.PrinterFirms.ToList();
                printerFrimcb.DisplayMember = "PrinterFirmName";
                printerFrimcb.ValueMember = "PritnerFirmID";




                var printerModel = from mp in db.PrinterModels
                                   select new
                                   {
                                       mp.PrinterModelName,
                                       PrinterFirm = mp.PrinterFirm.PrinterFirmName
                                   };
               dgv.DataSource = printerModel.ToList();

            }
        }



        public void createPrinterModel(MetroTextBox modelName, MetroComboBox printerFirm)
        {
            PrinterModel printerModels = new PrinterModel
            {
             PrinterModelName = modelName.Text.Trim(),
             PrinterFirmID = Convert.ToInt32(printerFirm.SelectedValue)
            };

            using(ContextModel db = new ContextModel())
            {
               
                db.PrinterModels.Add(printerModels);
                db.SaveChanges();

               
            }
        }
    }
}
