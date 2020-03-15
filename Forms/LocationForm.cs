using PrintPro.Classes;
using System;
using System.Windows.Forms;

namespace PrintPro.Forms
{
    public partial class LocationForm : MetroFramework.Forms.MetroForm
    {
        public LocationForm()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            LabID.Text = "0";
            TitulTB.Text = string.Empty;
            RoomTB.Text = string.Empty;
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            WorkInLocation workInLocation = new WorkInLocation(dgvPrinterLocation);
            workInLocation.load();
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WorkInLocation workInLocation = new WorkInLocation(dgvPrinterLocation);
            workInLocation.createLocationPrinter(LabID.Text,TitulTB.Text,RoomTB.Text);
            Clear();
        }

        private void dgvPrinterLocation_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = null;

            if (dgvPrinterLocation.SelectedRows.Count > 0)
            {
                selectedRow = dgvPrinterLocation.SelectedRows[0];
            }

            if (selectedRow == null)
                return;
            LabID.Text =   selectedRow.Cells["LocationID"].Value.ToString();
            TitulTB.Text = selectedRow.Cells["Titul"].Value.ToString();
            RoomTB.Text =  selectedRow.Cells["Room"].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WorkInLocation workInLocation = new WorkInLocation(dgvPrinterLocation);
            workInLocation.deletePrinterLocation(LabID.Text);
            Clear();
        }
    }
}
