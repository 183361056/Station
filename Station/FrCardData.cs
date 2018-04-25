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
    public partial class FrCardData : Form
    {
        private string commid;
        private string idn;
        private string fullname;
        private string buildingno;
        private string unitno;
        private string roomno;
        private string floors;
        private string rooms;
        private string workplace;
        private string housetype;
        private string purpose;
        private string usestatus;
        private string contactway;

        public FrCardData()
        {
            InitializeComponent();
        }

        private void FrCardData_Load(object sender, EventArgs e)
        {
            InitUi();
        }

        private void InitUi()
        {
            string _sql = string.Format(" select commid,idn,fullname,buildingno,unitno,roomno,floors,rooms,workplace,housetype,purpose,usestatus,contactway,registertime from T_RESIDENT  where COMMID='{0}' ", Global.commid);

            if(Tbidn.Text.Trim()==""  && Tbfullname.Text.Trim()=="")
            {
                _sql += "  and  to_char(sysdate,'yyyy-MM-dd')=to_char(registertime,'yyyy-MM-dd')";
            }
            else
            {
                if(Tbidn.Text.Trim()!="")
                {
                    _sql += string.Format(" and  idn like '%"+ Tbidn.Text + "%'  ");
                }

                if(Tbfullname.Text.Trim()!="")
                {
                    _sql += string.Format(" and  fullname like '%" + Tbfullname.Text + "%'  ");
                }
            }

            DataSet ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, _sql);
            GrData.AutoGenerateColumns = false;
            GrData.DataSource = ds.Tables[0];
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            InitUi();
        }

        private void GrData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(GrData.CurrentRow!=null)
            {
                
                fullname = GrData.CurrentRow.Cells[0].Value.ToString();
                idn = GrData.CurrentRow.Cells[1].Value.ToString();
                commid= GrData.CurrentRow.Cells[2].Value.ToString();

                buildingno = GrData.CurrentRow.Cells[3].Value.ToString();
                unitno = GrData.CurrentRow.Cells[4].Value.ToString();
        

                roomno = GrData.CurrentRow.Cells[5].Value.ToString();
                floors = GrData.CurrentRow.Cells[6].Value.ToString();
                rooms = GrData.CurrentRow.Cells[7].Value.ToString();

                contactway = GrData.CurrentRow.Cells[8].Value.ToString();
                housetype = GrData.CurrentRow.Cells[9].Value.ToString();
                purpose = GrData.CurrentRow.Cells[10].Value.ToString();
                usestatus = GrData.CurrentRow.Cells[11].Value.ToString();
                workplace = GrData.CurrentRow.Cells[12].Value.ToString();

                FrCardEdit edit = new FrCardEdit(commid,idn, fullname,buildingno, unitno, roomno, floors, rooms, workplace, housetype, purpose, usestatus, contactway);
                edit.ShowDialog();
                edit.Dispose();
            }

        }
    }
}
