using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASSETCODEGENERATOR
{
    public partial class FrmDelete_Data : Form
    {
        public FrmDelete_Data()
        {
            InitializeComponent();
        }
        DB objdb = new DB();
        int id = 0;
        private void FrmDelete_Data_Load(object sender, EventArgs e)
        {
            string sql = "Select * from tblBarcode";
            DataTable dt3 = objdb.RetrunDataTable(sql);
            cmbid.DataSource = dt3;
            cmbid.DisplayMember = "barcodeId";
            cmbid.ValueMember = "barcodeId";
        }

        private void cmbid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = 0;
            if (int.TryParse(cmbid.SelectedValue.ToString(), out id))
            {
                string sql1 = "Select * from tblBarcode where barcodeId='" + id + "'";
                DataTable dt3 = objdb.RetrunDataTable(sql1);
                cmbbarcode.DataSource = dt3;
                cmbbarcode.DisplayMember = "barcode";
                cmbbarcode.ValueMember = "barcodeId";
            }
        }
    }
}
