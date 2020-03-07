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

        //Для проверки вывода на DatagridView
        public void test(DataGridView dgv)
        {
           using(ContextModel db = new ContextModel())
            {
                dgv.DataSource = db.PrinterModels.ToList();
            }
        }


        //Все модели принтеров
        public void selectAllModelPrinters(DataGridView dgv)
        {
            using (ContextModel db = new ContextModel())
            {

                var printerModel = from mp in db.PrinterModels
                                   join d in db.PrinterFirms on mp.PrinterFirmID equals
                                   d.PritnerFirmID
                                   select new
                                   {
                                       d.PrinterFirmName,
                                       mp.PrinterModelName

                                   };
                dgv.DataSource = printerModel.ToList();
            }
        }


        // Привязка Фирмы принтера в Combobox
        public void printerModelSelect(ComboBox printerFirm)
        {

            using(ContextModel db = new ContextModel())
            {
                printerFirm.DataSource = db.PrinterFirms.ToList();
                printerFirm.DisplayMember = "PrinterFirmName";
                printerFirm.ValueMember = "PritnerFirmID";
            }

        }

        
        public void createPrinterModel(TextBox modelName, ComboBox printerFirm)
        {
           PrinterModel printerModels = new PrinterModel();

            using(ContextModel db = new ContextModel())
            {
                printerModels.PrinterModelName = modelName.Text.Trim();
                printerModels.PrinterFirmID = printerFirm.SelectedIndex;


                db.PrinterModels.Add(printerModels);
                db.SaveChanges();
            }
        }
    }
}
