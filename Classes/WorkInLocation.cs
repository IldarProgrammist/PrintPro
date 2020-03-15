using MetroFramework.Controls;
using PrintPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PrintPro.Classes
{
    public class WorkInLocation
    {
        private int LocationID { get; set; } 
        private MetroGrid Dgv { get; set; } 

         public WorkInLocation(MetroGrid dgv)
         {
           
            Dgv = dgv;
         }

        
        public void load()
        {
            using (ContextModel db = new ContextModel())
            {
                var SelectPrinterLocation = from pl in db.PrinterLocations
                                            select new
                                            {
                                                pl.LocationID,
                                                pl.Titul,
                                                pl.Room
                                            };
                Dgv.DataSource = SelectPrinterLocation.ToList();
            }
        }

        public void createLocationPrinter(string metroLabel, string titul, string room)
        {
            LocationID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {

                if (LocationID == 0)
                {
                    PrinterLocation printerLocation = new PrinterLocation
                    {
                        Titul = titul,
                        Room = room
                    };
                    db.PrinterLocations.Add(printerLocation);

                }
                else
                {
                    var mpToUpdate = db.PrinterLocations.SingleOrDefault(pm => pm.LocationID == LocationID);
                    if (mpToUpdate != null)
                    {
                        mpToUpdate.Titul = titul;
                        mpToUpdate.Room = room;
                    }
                }
                db.SaveChanges();
                load();
            }
        }

        public void deletePrinterLocation(string metroLabel)
        {

            int ID = Convert.ToInt32(metroLabel);

            using (ContextModel db = new ContextModel())
            {
                PrinterLocation printerLocation = db.PrinterLocations
                   .Where(p => p.LocationID == ID)
                   .FirstOrDefault();
                db.PrinterLocations.Remove(printerLocation);
                db.SaveChanges();
                load();
            }

        }
    }
}
