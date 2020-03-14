using MetroFramework;
using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Linq;

namespace PrintPro.Classes
{
    public class WorkInPrinterFirm
    {
        private MetroGrid Dgv { get; set; }
        private int PrinterFirmID { get; set; }


        public WorkInPrinterFirm(MetroGrid dgv)
        {
            Dgv = dgv;
        }

        public void LoadFirm()
        {
            using (ContextModel db = new ContextModel())
            {

                var SelectFirmAll = from np in db.PrinterFirms
                                    select new
                                    { np.PritnerFirmID,
                                        np.PrinterFirmName
                                    };

                Dgv.DataSource = SelectFirmAll.ToList();
            }
        }

        public void createPrinterFirm(string metroLabel, string firmName)
        {
            PrinterFirmID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {

                if (PrinterFirmID == 0)
                {
                    PrinterFirm printerFirm = new PrinterFirm
                    {
                        PrinterFirmName = firmName,
                    };
                    db.PrinterFirms.Add(printerFirm);
                   
                }
                else
                {
                    var mpToUpdate = db.PrinterFirms.SingleOrDefault(pm => pm.PritnerFirmID == PrinterFirmID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.PrinterFirmName = firmName;
                    }
                }
                db.SaveChanges();

                LoadFirm();

            }
        }

        public void deleteFirm(string metroLabel)
        {
            PrinterFirmID = Convert.ToInt32(metroLabel);

            using(ContextModel db = new ContextModel())
            {
                PrinterFirm printerFirm = db.PrinterFirms
                   .Where(p => p.PritnerFirmID == PrinterFirmID)
                   .FirstOrDefault();
                db.PrinterFirms.Remove(printerFirm);
                db.SaveChanges();
            }
        }
    }    
}

