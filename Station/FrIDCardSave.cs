using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Station
{
    public partial class FrIDCardSave : Form
    {


        public FrIDCardSave()
        {
            InitializeComponent();
        }

        private void FrIDCardSave_Load(object sender, EventArgs e)
        {
       

            BtnTry.Enabled = false;
            BtnClose.Enabled = false;

            Save();
        }


        private void Save()
        {

            StringBuilder sb = new StringBuilder(8000);

            if(Global.fingerLeftBmp!="" && Global.fingerRightBmp!="")
            {
                sb.Clear();
                sb.Append("insert into T_RESIDENT(rid, idn, fullname, sex, nation, birthdate, address, registerdept, validbegindate, validenddate, fingercount, fingerdesc, fingerleftbmp, fingerrightbmp, bigimage, smallimage,buildingno,unitno,roomno,floors,rooms,workplace,purpose,usestatus,contactway,housetype,registertime,commid)  ");
                sb.Append("  values (:rid, :idn, :fullname, :sex, :nation, :birthdate, :address, :registerdept, :validbegindate, :validenddate, :fingercount, :fingerdesc,:fingerleftbmp, :fingerrightbmp, :bigimage, :smallimage,:buildingno,:unitno,:roomno,:floors,:rooms,:workplace,:purpose,:usestatus,:contactway,:housetype,sysdate,:commid) ");

            }
            else
            {
                sb.Clear();
                sb.Append("insert into T_RESIDENT(rid, idn, fullname, sex, nation, birthdate, address, registerdept, validbegindate, validenddate, fingercount, fingerdesc,  bigimage, smallimage,buildingno,unitno,roomno,floors,rooms,workplace,purpose,usestatus,contactway,housetype)  ");
                sb.Append("  values (:rid, :idn, :fullname, :sex, :nation, :birthdate, :address, :registerdept, :validbegindate, :validenddate, :fingercount, :fingerdesc, :bigimage, :smallimage,:buildingno,:unitno,:roomno,:floors,:rooms,:workplace,:purpose,:usestatus,:contactway,:housetype) ");

            }

            OracleConnection conn = new OracleConnection(Global.ConnectionString);
            OracleTransaction tran = null;
     
 
            try
            {

                conn.Open();
                tran = conn.BeginTransaction();

                OracleCommand cmd1 = conn.CreateCommand();
                cmd1.Connection = conn;
                cmd1.Transaction = tran;
                cmd1.CommandText = string.Format(" delete  from T_RESIDENT where idn='{0}' and commid='{1}'",Global.IDN,Global.commid);
                cmd1.ExecuteNonQuery();


                OracleCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.Transaction = tran;
                cmd.CommandText = sb.ToString();


                //rid, idn, fullname, sex, nation, birthdate, address, registerdept, validbegindate, validenddate, fingercount, fingerdesc, fingerleftbmp, fingerrightbmp, bigimage,smallimage,
                //buildingno,unitno,roomno,floors,rooms,workplace,purpose,usestatus,contactway,housetype

                cmd.Parameters.Add("rid", OracleDbType.NVarchar2, 32).Value = Guid.NewGuid().ToString("N");
                cmd.Parameters.Add("idn", OracleDbType.NVarchar2, 18).Value = Global.IDN;
                cmd.Parameters.Add("fullname", OracleDbType.NVarchar2, 32).Value = Global.fullname;
                cmd.Parameters.Add("sex", OracleDbType.NVarchar2, 32).Value = Global.sex;
                cmd.Parameters.Add("nation", OracleDbType.NVarchar2, 32).Value = Global.nation;
                cmd.Parameters.Add("birthdate", OracleDbType.NVarchar2, 32).Value = Global.birthDate;
                cmd.Parameters.Add("address", OracleDbType.NVarchar2, 100).Value = Global.address;
                cmd.Parameters.Add("registerdept", OracleDbType.NVarchar2, 32).Value = Global.regDept;
                cmd.Parameters.Add("validbegindate", OracleDbType.NVarchar2, 32).Value = Global.validBeginDate;
                cmd.Parameters.Add("validenddate", OracleDbType.NVarchar2, 32).Value = Global.validEndDate;


                cmd.Parameters.Add("fingercount", OracleDbType.Int32).Value = Global.fingerCount;
                cmd.Parameters.Add("fingerdesc", OracleDbType.NVarchar2, 100).Value = Global.fingerDesc;

                if (Global.fingerLeftBmp != "" && Global.fingerRightBmp != "")
                {
                    cmd.Parameters.Add("fingerleftbmp", OracleDbType.Blob).Value = Global.ImageToBytes(Global.fingerLeftBmp);
                    cmd.Parameters.Add("fingerrightbmp", OracleDbType.Blob).Value = Global.ImageToBytes(Global.fingerRightBmp);
                }
                
                cmd.Parameters.Add("bigimage", OracleDbType.Blob).Value = Global.ImageToBytes(Global.bigImage);
                cmd.Parameters.Add("smallimage", OracleDbType.Blob).Value = Global.ImageToBytes(Global.smallImage);

                //:buildingno,:unitno,:roomno,:floors,:rooms,:workplace,:purpose,:usestatus,:contactway,:housetype

                cmd.Parameters.Add("buildingno", OracleDbType.NVarchar2, 18).Value = Global.buildingno;
                cmd.Parameters.Add("unitno", OracleDbType.NVarchar2, 32).Value = Global.unitno;
                cmd.Parameters.Add("roomno", OracleDbType.NVarchar2, 32).Value = Global.roomno;
                cmd.Parameters.Add("floors", OracleDbType.Int32).Value = Global.floors; 
                cmd.Parameters.Add("rooms", OracleDbType.Int32).Value = Global.rooms; 

                cmd.Parameters.Add("workplace", OracleDbType.NVarchar2, 32).Value = Global.workplace;
                cmd.Parameters.Add("purpose", OracleDbType.NVarchar2, 100).Value = Global.purpose;
                cmd.Parameters.Add("usestatus", OracleDbType.NVarchar2, 32).Value = Global.usestatus;
                cmd.Parameters.Add("contactway", OracleDbType.NVarchar2, 32).Value = Global.contactway;
                cmd.Parameters.Add("housetype", OracleDbType.NVarchar2, 32).Value = Global.housetype;

                cmd.Parameters.Add("commid", OracleDbType.NVarchar2, 32).Value = Global.commid;  

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

                BtnTry.Enabled = true;
                BtnClose.Enabled = true;

            }
            finally
            {
                conn.Close();
            }

        }


        public void theout(object source, System.Timers.ElapsedEventArgs e)
        {
            Global.temp_frcard_instance = false;

            Close();
        }



        private void BtnTry_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            Global.temp_frcard_instance = false;

            Close();
        }
    }
}
