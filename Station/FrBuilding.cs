using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Station
{
    public partial class FrBuilding : Form
    {
        public FrBuilding()
        {
            InitializeComponent();
        }

        private void FrBuilding_Load(object sender, EventArgs e)
        {


            DataSet ds = SqlHelper.ExecuteDataset(Global.ConnectionString,CommandType.Text,string.Format(" select buildingno,unitno from T_COMMGATE where commid='{0}' and gatetype='2' ", Global.commid));

            GrBuilding.DataSource = ds.Tables[0];
            GrBuilding.AutoGenerateColumns = false;

        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

            if(GrBuilding.Rows.Count>0)
            {
                if(GrBuilding.SelectedRows.Count>0)
                {
                    Global.temp_building_unit = GrBuilding.SelectedRows[0].Cells[0].Value.ToString() + "#" + GrBuilding.SelectedRows[0].Cells[1].Value.ToString();
                    Close();
                }
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Global.temp_building_unit = "";
            Close();
        }

        private void GrBuilding_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSelect_Click(sender, e);
        }
    }
}
