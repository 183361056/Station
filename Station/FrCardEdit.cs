using Oracle.ManagedDataAccess.Client;
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
    public partial class FrCardEdit : Form
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
        public FrCardEdit()
        {
            InitializeComponent();
        }

        public FrCardEdit(string _commid,string _idn, string _fullname, string _buildingno, string _unitno, string _roomno, string _floors, string _rooms, string _workplace, string  _housetype, string _purpose, string _usestatus, string _contactway)
        {
            InitializeComponent();

            commid = _commid;
            idn = _idn;
            fullname = _fullname;
            buildingno = _buildingno;
            unitno = _unitno;
            roomno = _roomno;
            floors = _floors;
            rooms = _rooms;

            workplace = _workplace;
            housetype = _housetype;
            purpose = _purpose;
            usestatus = _usestatus;
            contactway = _contactway;

        }

        private void InitControl()
        {
            DataSet ds = null;


            try
            {

                ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, " select typename from T_HOUSETYPE ");

                Cbroompurpose.Items.Clear();
                for (int i=0;i<ds.Tables[0].Rows.Count;i++)
                {
                    Cbroompurpose.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
          
                ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, " select purpose from T_ROOMPURPOSE ");

                Cbhousetype.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Cbhousetype.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
           
                ds = SqlHelper.ExecuteDataset(Global.ConnectionString, CommandType.Text, " select usestatus from T_ROOMUSESTATUS ");
                Cbroomstatus.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Cbroomstatus.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }

                label_name.Text = fullname+"("+idn+")";

                Tbbuildingno.Text = buildingno;
                Tbunitno.Text = unitno;
                Tbroomno.Text = roomno;
                Nufloor.Value = Convert.ToInt32(floors);
                Nurooms.Value = Convert.ToInt32(rooms);
                Tbworkplace.Text = workplace;
                Cbhousetype.Text = housetype;
                Cbroompurpose.Text = purpose;
                Cbroomstatus.Text = usestatus;
                Tbcontactway.Text = contactway;

                LaInfo.Text = "";

            }
            catch(Exception e)
            {
                LaInfo.Text = "数据初始化发生错误！";
            }

           
        }

        private bool Check()
        {
           

            if (Tbbuildingno.Text == "")
            {
                LaInfo.Text = "楼号不能为空！";
                return false;
            }

            if (Tbunitno.Text == "")
            {
                LaInfo.Text = "单元号不能为空！";
                return false;
            }

            if (Tbroomno.Text == "")
            {
                LaInfo.Text = "房间号不能为空！";
                return false;
            }

            if (Nufloor.Value == 0)
            {
                LaInfo.Text = "楼层不能为0！";
                return false;
            }

            if (Nurooms.Value == 0)
            {
                LaInfo.Text = "房间数不能为0！";
                return false;
            }

            if (Cbhousetype.Text == "")
            {
                LaInfo.Text = "请选择房屋类型！";
                return false;
            }

            if (Cbroompurpose.Text == "")
            {
                LaInfo.Text = "请选择房屋用途！";
                return false;
            }

            if (Cbroomstatus.Text == "")
            {
                LaInfo.Text = "请选择居住现状！";
                return false;
            }

            if (Tbcontactway.Text == "")
            {
                LaInfo.Text = "联系方式不能为空！";
                return false;
            }

            return true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(Global.ConnectionString);
            OracleTransaction tran = null;

            if (Check())
            {


                buildingno = Tbbuildingno.Text;
                unitno = Tbunitno.Text;
                roomno = Tbroomno.Text;
                floors = Nufloor.Value.ToString();
                rooms = Nurooms.Value.ToString();

                workplace = Tbworkplace.Text;
                housetype = Cbhousetype.Text;
                purpose = Cbroompurpose.Text;
                usestatus = Cbroomstatus.Text;
                contactway = Tbcontactway.Text;

                try
                {

                    conn.Open();
                    tran = conn.BeginTransaction();


                    OracleCommand cmd = conn.CreateCommand();
                    cmd.Connection = conn;
                    cmd.Transaction = tran;
                    cmd.CommandText = "update T_RESIDENT set buildingno=:buildingno,unitno=:unitno,roomno=:roomno,floors=:floors,rooms=:rooms,workplace=:workplace,purpose=:purpose,usestatus=:usestatus,contactway=:contactway,housetype=:housetype where idn=:idn and commid=:commid";


                    //rid, idn, fullname, sex, nation, birthdate, address, registerdept, validbegindate, validenddate, fingercount, fingerdesc, fingerleftbmp, fingerrightbmp, bigimage,smallimage,
                    //buildingno,unitno,roomno,floors,rooms,workplace,purpose,usestatus,contactway,housetype

                    //:buildingno,:unitno,:roomno,:floors,:rooms,:workplace,:purpose,:usestatus,:contactway,:housetype

                    cmd.Parameters.Add("buildingno", OracleDbType.NVarchar2, 18).Value = buildingno;
                    cmd.Parameters.Add("unitno", OracleDbType.NVarchar2, 32).Value = unitno;
                    cmd.Parameters.Add("roomno", OracleDbType.NVarchar2, 32).Value = roomno;
                    cmd.Parameters.Add("floors", OracleDbType.Int32).Value = floors;
                    cmd.Parameters.Add("rooms", OracleDbType.Int32).Value = rooms;

                    cmd.Parameters.Add("workplace", OracleDbType.NVarchar2, 32).Value =workplace;
                    cmd.Parameters.Add("purpose", OracleDbType.NVarchar2, 100).Value = purpose;
                    cmd.Parameters.Add("usestatus", OracleDbType.NVarchar2, 32).Value = usestatus;
                    cmd.Parameters.Add("contactway", OracleDbType.NVarchar2, 32).Value = contactway;
                    cmd.Parameters.Add("housetype", OracleDbType.NVarchar2, 32).Value = housetype;

                    cmd.Parameters.Add("idn", OracleDbType.NVarchar2, 18).Value =idn;
                    cmd.Parameters.Add("commid", OracleDbType.NVarchar2, 32).Value = commid;

                    cmd.ExecuteNonQuery();

                    tran.Commit();

                    LaInfo.Text = "保存成功.....";

                    System.Timers.Timer timersTimer = new System.Timers.Timer();

                    timersTimer.Interval = 2000;
                    timersTimer.Elapsed += new System.Timers.ElapsedEventHandler(theout);
                    timersTimer.SynchronizingObject = this;
                    timersTimer.Enabled = true;

                }
                catch (Exception er)
                {

                    tran.Rollback();

                    LogHelper.WriteLog(LogFile.Error, er.ToString());

                    LaInfo.Text = "保存失败，请重试.....";



                }
                finally
                {
                    conn.Close();
                }


            }

          

        }

        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
          
            Close();
        }


        private void FrCardEdit_Load(object sender, EventArgs e)
        {
            InitControl();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
