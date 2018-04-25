using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Station
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void MiCard_Click(object sender, EventArgs e)
        {
            if(Global.temp_frcard_instance==false)
            {
                Global.InitApp();

                Global.temp_frcard_instance = true;
                FrIDCard card = new  FrIDCard();
                card.Focus();
                card.Show();
            }            
           
        }

        private void FrMain_Load(object sender, EventArgs e)
        {

            FrLogin login = new FrLogin();
            if(login.ShowDialog()==DialogResult.Cancel)
            {
                System.Environment.Exit(0);
            }

            login.Dispose();

            InitUI();
        }


        private void InitUI()
        {
            //MdiClient ctlMDI;
            //foreach (Control ctl in this.Controls)
            //{
            //    try
            //    {
            //        ctlMDI = (MdiClient)ctl;
            //        ctlMDI.BackColor = this.BackColor;


            //    }
            //    catch (InvalidCastException e)
            //    {

            //    }
            //}


            TssLa2.Text = Global.commname+"("+Global.commid+")";

        }
        private void MiExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MiBaseData_Click(object sender, EventArgs e)
        {
            FrCardData data = new FrCardData();
            data.ShowDialog();
            data.Dispose();
        }
    }
}
