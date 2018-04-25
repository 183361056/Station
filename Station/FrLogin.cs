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
    public partial class FrLogin : Form
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
       
            if(Check(TxUserId.Text,TxUserPwd.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }           
        }


        private bool Check(string userid,string userpwd)
        {
      
            OracleDataReader dr = SqlHelper.ExecuteReader(Global.ConnectionString, CommandType.Text, string.Format(" select * from V_COMMUSER  where userid='{0}' ", userid));
            try
            {
                if (dr.Read())
                {
                   string _userpwd = dr["USERPWD"] == null ? "" : dr["USERPWD"].ToString();
                    
                    if(_userpwd==userpwd)
                    {
                        Global.userid = userid;
                        Global.username = dr["username"] == null ? "" : dr["username"].ToString();
                        Global.commid= dr["commid"] == null ? "" : dr["commid"].ToString();
                        Global.commname= dr["commname"] == null ? "" : dr["commname"].ToString();

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {

                    return false;
                }

            }
            catch
            {
                return false;
            }
            finally
            {
                dr.Close();
            }
            
        }
    }
}
