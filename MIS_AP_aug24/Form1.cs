using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace MIS
{
    public partial class MISmain : Form
    {   
       
        
        #region required database connectivity variables

        private System.Data.Odbc.OdbcConnection OdbcCon;
        private System.Data.Odbc.OdbcCommand OdbcCom;
        private System.Data.Odbc.OdbcDataReader OdbcDR;
        DateTime newday = new DateTime();
        private string ConStr;
        string today;
        
        #endregion
        bool[] flagfield=new bool[15];
        string[] ServiceStr ={ "pcc", "pcl", "afs", "hcd", "uan" };
        #region required excel object variables
        Excel.Application oXL;
        Excel._Workbook oWB;
        Excel._Worksheet oSheet;
        Excel._Chart oChart;
        Excel.Range oRng;
        Excel.Series oSeries;

        #endregion
        public MISmain()
        {   
                InitializeComponent();
                newday = DateTime.Today.Subtract(System.TimeSpan.FromDays(1)); //convert today to yesterday
                today = newday.ToString("yyyyMMdd");
                
        }

        private void MISmain_Load(object sender, EventArgs e)
        {
            while (true)
            {
                authenticate A1 = new authenticate();
                A1.ShowDialog();

                if (validity.cancelled == true)
                {
                    this.Close();
                    break;
                }
                else if (validity.authenticated == true)
                {
                    this.Show();
                    break;
                }
                else if (validity.authenticated == false)
                    MessageBox.Show(" Incorrect Username and Password");


            }
             

            this.paneluser.Enabled = false;
            this.pnldisplayselection.Enabled = false;


        }
       
        #region windows event handlers
        
        
        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkbxservicesall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxservicesall.Checked == true)
                chkbxpcc.Checked = chkbxpcl.Checked = chkbxafs.Checked = chkbxhcd.Checked = chkbxuan.Checked = true;
            else
            {
                chkbxpcc.Checked = chkbxpcl.Checked = chkbxafs.Checked = chkbxhcd.Checked = chkbxuan.Checked = false;
            }
        }

        private void chkbxcallingparty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxcallingparty.Checked) txtbxcallingparty.Enabled = true;
            else
            {
                txtbxcallingparty.Enabled = false; txtbxcallingparty.Text = "";
            }
        }

       

        private void chkbxcardno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxcardno.Checked) txtbxcardno.Enabled = true;
            else
            {
                txtbxcardno.Enabled = false; txtbxcardno.Text = "";
            }
        }

        
        private void cmbbxdsplsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btndisplay.Enabled = true;
            if (cmbbxdsplsel.Text == "Annual Report" || cmbbxdsplsel.Text == "Monthly Report")
            {
                pnldisplayselection.Enabled = false; paneluser.Enabled = false;
            }
            else { pnldisplayselection.Enabled = true; paneluser.Enabled = true; }

            if (cmbbxdsplsel.Text == "Monthly Report")
            {
                cmbbxmonthsel.Enabled = true; cmbbxmonthsel.Text = DateTime.Today.ToString("MM");
            }
            else cmbbxmonthsel.Enabled = false;

            if (cmbbxdsplsel.Text == "Summary Report")
            {
                chkbxcallingparty.Enabled = false;  chkbxcardno.Enabled = false;
                cmbBoxSummary.Enabled= true;        pnldisplayselection.Enabled = false;
                txtbxcallingparty.Enabled = false; txtbxcardno.Enabled = false;
            }
            if (cmbbxdsplsel.Text == "Normal Report")
            {
                cmbBoxSummary.Enabled = false; chkbxcallingparty.Enabled = true; chkbxcardno.Enabled = true;
                chkbxcallingparty.Checked = false; chkbxcardno.Checked = false;
            }
        }

        private void cmbbxdsplsel_TextChanged(object sender, EventArgs e)
        {   
            if(cmbbxdsplsel.Text!="Normal Report" || cmbbxdsplsel.Text!="Monthly Report" || cmbbxdsplsel.Text!="Annual Report")
                btndisplay.Enabled=false;
            else
                btndisplay.Enabled=true;
            if (cmbbxdsplsel.Text == "Monthly Report") { cmbbxmonthsel.Enabled = true; cmbbxmonthsel.Text = DateTime.Today.ToString("MM"); }
        }

        private void chkbxselall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxselall.Checked == true)
            {
                chkbxselcp.Checked = chkbxseltp.Checked = chkbxshp.Checked = chkbxsdt.Checked = chkbxedt.Checked = chkbxdur.Checked = chkbxccst.Checked = chkbxccls.Checked = chkbxscpt.Checked = chkbxuid.Checked = chkbxssno.Checked = chkbxfcnt.Checked = chkbxbcc.Checked = chkbxecc.Checked = true;
                for (int i = 1; i < 15; i++)
                    flagfield[i] = true;
            }
            else
            {
                chkbxselcp.Checked = chkbxseltp.Checked = chkbxshp.Checked = chkbxsdt.Checked = chkbxedt.Checked = chkbxdur.Checked = chkbxccst.Checked = chkbxccls.Checked = chkbxscpt.Checked = chkbxuid.Checked = chkbxssno.Checked = chkbxfcnt.Checked = chkbxbcc.Checked = chkbxecc.Checked = false;
            }

        }

        private void chkbxselcp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxselcp.Checked == false)
                { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxselcp)]=false;}
            else 
                    flagfield[pnldisplayselection.Controls.IndexOf(chkbxselcp)]=true;
            if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
                chkbxselall.Checked = true;
            

        }

        private void chkbxseltp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxseltp.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxseltp)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxseltp)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxshp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxshp.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxshp)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxshp)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxsdt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxsdt.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxsdt)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxsdt)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxedt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxedt.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxedt)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxedt)] = true;
           
           
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxdur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxdur.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxdur)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxdur)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxccst_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxccst.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxccst)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxccst)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxccls_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxccls.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxccls)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxccls)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxscpt_CheckedChanged(object sender, EventArgs e)
        {
             if (chkbxscpt.Checked == false)
             { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxscpt)] = false; }
            else
                 flagfield[pnldisplayselection.Controls.IndexOf(chkbxscpt)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxuid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxuid.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxuid)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxuid)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxssno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxssno.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxssno)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxssno)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxfcnt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxfcnt.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxfcnt)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxfcnt)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxbcc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxbcc.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxbcc)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxbcc)] = true;
        if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxecc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxecc.Checked == false)
            { chkbxselall.Checked = false; flagfield[pnldisplayselection.Controls.IndexOf(chkbxecc)] = false; }
            else
                flagfield[pnldisplayselection.Controls.IndexOf(chkbxecc)] = true;
            if (chkbxselcp.Checked == true & chkbxseltp.Checked == true & chkbxshp.Checked == true & chkbxsdt.Checked == true & chkbxedt.Checked == true & chkbxdur.Checked == true & chkbxccst.Checked == true & chkbxccls.Checked == true & chkbxscpt.Checked == true & chkbxuid.Checked == true & chkbxssno.Checked == true & chkbxfcnt.Checked == true & chkbxbcc.Checked == true & chkbxecc.Checked == true)
            chkbxselall.Checked = true;
        }

        private void chkbxpcc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxpcc.Checked == false)
                chkbxservicesall.Checked = false;
            if (chkbxpcc.Checked == true & chkbxpcl.Checked == true & chkbxafs.Checked ==true & chkbxhcd.Checked ==true & chkbxuan.Checked == true)
                chkbxservicesall.Checked = true;
        }

        private void chkbxpcl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxpcl.Checked == false)
                chkbxservicesall.Checked = false;
            if (chkbxpcc.Checked == true & chkbxpcl.Checked == true & chkbxafs.Checked == true & chkbxhcd.Checked == true & chkbxuan.Checked == true)
                chkbxservicesall.Checked = true;
        }

        private void chkbxafs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxafs.Checked == false)
                chkbxservicesall.Checked = false;
            if (chkbxpcc.Checked == true & chkbxpcl.Checked == true & chkbxafs.Checked == true & chkbxhcd.Checked == true & chkbxuan.Checked == true)
                chkbxservicesall.Checked = true;
        }

        private void chkbxhcd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxhcd.Checked == false)
                chkbxservicesall.Checked = false;
            if (chkbxpcc.Checked == true & chkbxpcl.Checked == true & chkbxafs.Checked == true & chkbxhcd.Checked == true & chkbxuan.Checked == true)
                chkbxservicesall.Checked = true;
        }

        private void chkbxuan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxuan.Checked == false)
                chkbxservicesall.Checked = false;
            if (chkbxpcc.Checked == true & chkbxpcl.Checked == true & chkbxafs.Checked == true & chkbxhcd.Checked == true & chkbxuan.Checked == true)
                chkbxservicesall.Checked = true;
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkbxpcc.Checked = chkbxpcl.Checked = chkbxafs.Checked = chkbxhcd.Checked = chkbxuan.Checked = false;
        }

        private void displaySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkbxselcp.Checked = chkbxseltp.Checked = chkbxshp.Checked = chkbxsdt.Checked =chkbxedt.Checked = chkbxdur.Checked= chkbxccst.Checked = chkbxccls.Checked = chkbxscpt.Checked = chkbxuid.Checked = chkbxssno.Checked = chkbxfcnt.Checked = chkbxbcc.Checked = chkbxecc.Checked = false;
        }

        private void userInputsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkbxcallingparty.Checked = false;
            txtbxcallingparty.Text = null;
            txtbxcallingparty.Enabled = false;

       
            //chkbxchargeclasss.Checked = false;
            
            

            chkbxcardno.Checked = false;
            txtbxcardno.Text = null;
            txtbxcardno.Enabled = false;

            

        }

        private void allFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkbxcallingparty.Checked = false;
            txtbxcallingparty.Text = null;
            txtbxcallingparty.Enabled = false;


            //chkbxchargeclasss.Checked = false;
            
            
            chkbxcardno.Checked = false;
            txtbxcardno.Text = null;
            txtbxcardno.Enabled = false;

            

            chkbxpcc.Checked = chkbxpcl.Checked = chkbxafs.Checked = chkbxhcd.Checked = chkbxuan.Checked = false;
            
            chkbxselcp.Checked = chkbxseltp.Checked = chkbxshp.Checked = chkbxsdt.Checked = chkbxedt.Checked = chkbxdur.Checked = chkbxccst.Checked = chkbxccls.Checked = chkbxscpt.Checked = chkbxuid.Checked = chkbxssno.Checked = chkbxfcnt.Checked = chkbxbcc.Checked = chkbxecc.Checked = false;

        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectionToolStripMenuItem.Text == "Connect")
            {
                connection newcon = new connection();
                newcon.ShowDialog();
                if (constring.connect == true)
                {
                    ConStr = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=" + constring.hostname + "; PORT=" + constring.portno + "; DATABASE=" + constring.database + "; UID=" + constring.username + "; PWD=" + constring.password + ";OPTION=3";
                    OdbcCon = new System.Data.Odbc.OdbcConnection(ConStr);
                    
                    try
                    {
                        statusstrip.Text = "Openning connection...";
                        if (OdbcCon.State == ConnectionState.Closed)
                        {
                            OdbcCon.Open();
                            this.btnupdate.Enabled = true;

                        }
                        statusstrip.Text = "Connection opened";
                        connectionToolStripMenuItem.Text = "Disconnect";
                    }
                    catch (System.Data.Odbc.OdbcException Ex)
                    {
                        statusstrip.Text = Ex.Message;
                        //MessageBox.Show("Could not access the database.\r\nPlease make sure you completed the fields with the correct information and try again.\r\n\r\nMore details:\r\n" + Ex.Message, "Database connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        newcon.Close();
                    }
                }
            }
            else if (connectionToolStripMenuItem.Text == "Disconnect")
            {
                OdbcCon.Close();
                statusstrip.Text = "Connection closed";
                connectionToolStripMenuItem.Text = "Connect";
            }
                    
        }
          #endregion

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (connectionToolStripMenuItem.Text == "Connect")
            {
                MessageBox.Show("Connection not opened");
            }

            else if (OdbcCon.State == ConnectionState.Open)
            {
                int updatethedatabase = checkupdatestate();
                if (updatethedatabase == 1)
                {
                    OdbcCom = new OdbcCommand("SELECT date_modified FROM update_state WHERE tables='pcc'", OdbcCon);
                    OdbcDR = OdbcCom.ExecuteReader();
                    string date_recvd = "";
                    System.DateTime datetime_recvd = new DateTime();

                    while (OdbcDR.Read())
                    {
                        datetime_recvd = (DateTime)OdbcDR[0];
                        datetime_recvd += System.TimeSpan.FromDays(1);
                        date_recvd = datetime_recvd.ToString("yyyyMMdd");
                    }
                    OdbcDR.Close();

                    toolStripProgressBar.Visible = true;

                    do
                    {

                        int new_rows = 0;
                        int prev_rows = 0;

                        #region queries to create the services tables
                        if (string.Compare("" + datetime_recvd.Day, "1") == 0)
                        {
                            OdbcCom = new OdbcCommand("CREATE TABLE pcc" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create pcc table");

                            }
                            OdbcCom = new OdbcCommand("CREATE TABLE pcl" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create pcl table");

                            }
                            OdbcCom = new OdbcCommand("CREATE TABLE hcd" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create hcd table");

                            }
                            OdbcCom = new OdbcCommand("CREATE TABLE afs" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create afs table");

                            }
                            OdbcCom = new OdbcCommand("CREATE TABLE uan" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create uan table");

                            }

                            toolStripProgressBar.Value = toolStripProgressBar.Step * 2;

                        }
                        #endregion

                        #region queries to load the cdr
                        OdbcCom = new System.Data.Odbc.OdbcCommand("CREATE TABLE cdr_rec" + date_recvd + "(StreamNo INT(6),ServiceKey INT(8),ChargeMode CHAR(1),ChargeRecordid TINYINT(2),CallingPartyNumber  VARCHAR(16),CalledPartyNumber VARCHAR(18),TranslatedPartyNumber VARCHAR(18),LocationNumber VARCHAR(4),ChargedPartyidind TINYINT(2),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),BearerCapability CHAR(2),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                        try
                        {
                            OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show("Unable to create cdr raw table " + Ex.Message);

                        }
                        OdbcCom = new OdbcCommand("load data infile 'c:/testing/rec" + date_recvd + "_101.unl' into table cdr_rec" + date_recvd + " fields terminated by '|'", OdbcCon);
                        try
                        {
                            OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show("Unable to load the raw data file :: " + Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }
                        //statusstrip.Text = "loading call data record for date "+ date_recvd;
                        toolStripProgressBar.Value = toolStripProgressBar.Step * 4;
                        #endregion

                        #region queries to insert the pcc data
                        OdbcCom = new OdbcCommand("INSERT INTO pcc" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 200 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='pcc'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='pcc'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        //statusstrip.Text = "loading pre-paid calling card data completed";
                        toolStripProgressBar.Value += toolStripProgressBar.Step;
                        #endregion

                        #region queries to insert the pcl data
                        OdbcCom = new OdbcCommand("INSERT INTO pcl" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 216 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='pcl'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='pcl'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        //statusstrip.Text = "loading PSTN credit limit data completed";
                        toolStripProgressBar.Value += toolStripProgressBar.Step;
                        #endregion

                        #region queries to insert the hcd data
                        OdbcCom = new OdbcCommand("INSERT INTO hcd" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 201 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='hcd'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='hcd'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        //statusstrip.Text = "loading home country direct data completed";
                        toolStripProgressBar.Value += toolStripProgressBar.Step;
                        #endregion

                        #region queries to insert the afs data
                        OdbcCom = new OdbcCommand("INSERT INTO afs" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 800 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='afs'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='afs'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        //statusstrip.Text = "loading advanced free phone service data completed";
                        toolStripProgressBar.Value += toolStripProgressBar.Step;
                        #endregion

                        #region queries to insert the uan data
                        OdbcCom = new OdbcCommand("INSERT INTO uan" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 701 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='uan'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='uan'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        //statusstrip.Text = "loading universal access number data completed";
                        toolStripProgressBar.Value += toolStripProgressBar.Step;
                        #endregion

                        #region queries to delete the cdr_rec tables
                        OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        toolStripProgressBar.Value = 0;
                        # endregion


                        datetime_recvd += System.TimeSpan.FromDays(1);
                        date_recvd = datetime_recvd.ToString("yyyyMMdd");

                        //toolStripProgressBar.Visible = false;
                        //statusstrip.Text = " All data updating completed for date "+date_recvd;

                    } while (datetime_recvd.CompareTo(System.DateTime.Today) != 0);

                    toolStripProgressBar.Visible = false;
                    toolStripProgressBar.Value = 0;
                    statusstrip.Text = " All data updating completed";
                }
                else if (updatethedatabase == 0)
                    statusstrip.Text = "Database already updated till date";

            }
            else if (OdbcCon.State == ConnectionState.Closed)
                statusstrip.Text = " unable to make connection";
        }

        #region /////
        /*  private void btnupdate_Click(object sender, EventArgs e)
        {
            if (connectionToolStripMenuItem.Text == "Connect")
            {
                MessageBox.Show("Connection not opened");
            }
           
            else if (OdbcCon.State == ConnectionState.Open)
            {
                int updatethedatabase = checkupdatestate();
                if (updatethedatabase == 1)
                {
                    OdbcCom = new OdbcCommand("SELECT date_modified FROM update_state WHERE tables='pcc'", OdbcCon);
                    OdbcDR = OdbcCom.ExecuteReader();
                    string date_recvd="";
                    System.DateTime datetime_recvd=new DateTime();

                    while (OdbcDR.Read())
                    {
                        datetime_recvd = (DateTime)OdbcDR[0];
                        datetime_recvd += System.TimeSpan.FromDays(1);
                        date_recvd = datetime_recvd.ToString("yyyyMMdd");
                    }
                    OdbcDR.Close();

                    do
                    {
                        
                        int new_rows = 0;
                        int prev_rows = 0;

                        #region queries to create the services tables
                        if (string.Compare(""+datetime_recvd.Day, "1") == 0)
                        {
                            OdbcCom = new OdbcCommand("CREATE TABLE pcc" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create pcc table");

                            }    
                            OdbcCom = new OdbcCommand("CREATE TABLE pcl" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create pcl table");

                            }    
                            OdbcCom = new OdbcCommand("CREATE TABLE hcd" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create hcd table");

                            }    
                            OdbcCom = new OdbcCommand("CREATE TABLE afs" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create afs table");

                            }    
                            OdbcCom = new OdbcCommand("CREATE TABLE uan" + datetime_recvd.ToString("MM") + "(ServiceKey INT(8),CallingPartyNumber  VARCHAR(16),TranslatedPartyNumber VARCHAR(18),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                            try
                            {
                                OdbcCom.ExecuteNonQuery();
                            }
                            catch (System.Data.Odbc.OdbcException Ex)
                            {
                                MessageBox.Show("Unable to create uan table");

                            }    

                        }
                        #endregion
                                                   
                        #region queries to load the cdr
                        OdbcCom = new System.Data.Odbc.OdbcCommand("CREATE TABLE cdr_rec" + date_recvd + "(StreamNo INT(6),ServiceKey INT(8),ChargeMode CHAR(1),ChargeRecordid TINYINT(2),CallingPartyNumber  VARCHAR(16),CalledPartyNumber VARCHAR(18),TranslatedPartyNumber VARCHAR(18),LocationNumber VARCHAR(4),ChargedPartyidind TINYINT(2),SpecificChargePart VARCHAR(22),StartDateandTime DATETIME,StopDateandTime  DATETIME,Duration INT(8),CallCost INT(8),BearerCapability CHAR(2),ChargeClass INT(4),SpecificChgPrtType TINYINT (2),UserID INT(8),SubServiceNumber VARCHAR(28),FeeCount INT(8),BaseCallCost INT(8),ExtraCallCost INT(8))", OdbcCon);
                        try
                        {
                            OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show("Unable to create cdr raw table " + Ex.Message);

                        }    
                        OdbcCom = new OdbcCommand("load data infile 'c:/testing/rec" + date_recvd + "_101.unl' into table cdr_rec" + date_recvd + " fields terminated by '|'", OdbcCon);
                        try
                        {
                            OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show("Unable to load the raw data file :: "+ Ex.Message);
                            //OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            //OdbcCom.ExecuteNonQuery();
                        }    
                        statusstrip.Text = "loading call data record completed";
                        #endregion

                        #region queries to insert the pcc data
                        OdbcCom = new OdbcCommand("INSERT INTO pcc" + datetime_recvd.ToString("MM")+ " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 200 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }    
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='pcc'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='pcc'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        statusstrip.Text = "loading pre-paid calling card data completed";
                        #endregion

                        #region queries to insert the pcl data
                        OdbcCom = new OdbcCommand("INSERT INTO pcl" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 216 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }    
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='pcl'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='pcl'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        statusstrip.Text = "loading PSTN credit limit data completed";
                        #endregion

                        #region queries to insert the hcd data
                        OdbcCom = new OdbcCommand("INSERT INTO hcd" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 201 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }    
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='hcd'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='hcd'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        statusstrip.Text = "loading home country direct data completed";
                        #endregion

                        #region queries to insert the afs data
                        OdbcCom = new OdbcCommand("INSERT INTO afs" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 800 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }    
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='afs'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='afs'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        statusstrip.Text = "loading advanced free phone service data completed";
                        #endregion

                        #region queries to insert the uan data
                        OdbcCom = new OdbcCommand("INSERT INTO uan" + datetime_recvd.ToString("MM") + " SELECT ServiceKey,CallingPartyNumber,TranslatedPartyNumber,SpecificChargePart,StartDateandTime,StopDateandTime,Duration,CallCost,ChargeClass,SpecificChgPrtType,UserID,SubServiceNumber,FeeCount,BaseCallCost,ExtraCallCost FROM cdr_rec" + date_recvd + " WHERE ServiceKey = 701 ", OdbcCon);
                        try
                        {
                            new_rows = OdbcCom.ExecuteNonQuery();
                        }
                        catch (System.Data.Odbc.OdbcException Ex)
                        {
                            MessageBox.Show(Ex.Message);
                            OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                            OdbcCom.ExecuteNonQuery();
                        }    
                        OdbcCom = new OdbcCommand("SELECT no_of_rows FROM update_state WHERE tables='uan'", OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        while (OdbcDR.Read())
                        {
                            prev_rows = (int)OdbcDR[0];
                        }
                        OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date_recvd + ",created='Y',no_of_rows=" + (new_rows + prev_rows) + " WHERE tables='uan'", OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        statusstrip.Text = "loading universal access number data completed";
                        #endregion

                        #region queries to delete the cdr_rec tables
                        OdbcCom = new OdbcCommand("DROP TABLE cdr_rec" + date_recvd, OdbcCon);
                        OdbcCom.ExecuteNonQuery();
                        # endregion


                        datetime_recvd += System.TimeSpan.FromDays(1);
                        date_recvd = datetime_recvd.ToString("yyyyMMdd");

                    } while (datetime_recvd.CompareTo(System.DateTime.Today)!=0);

                    statusstrip.Text = " All data updating completed";
                }
                else if (updatethedatabase == 0)
                    statusstrip.Text = "Database already updated till date";

            }
            else if (OdbcCon.State == ConnectionState.Closed)
                statusstrip.Text = " unable to make connection";
        }*/
        #endregion

        private void dateTimePickerstart_ValueChanged(object sender, EventArgs e)
        {
            forform1.stat_datetimestart = DateTime.Parse(dateTimePickerstart.Text);
        }


        #region programmer designed functions

        private int checkupdatestate()
        {
            int updated = 0;
            if (OdbcCon.State == ConnectionState.Closed)
                MessageBox.Show("Connection not opened");

            else if (OdbcCon.State == ConnectionState.Open)
            {
                //--------check if the updating process has been performed beforehand or not---------------




                int i = 0;
                OdbcCom = new OdbcCommand("SELECT date_modified FROM update_state", OdbcCon);
                OdbcDR = OdbcCom.ExecuteReader();
                System.DateTime[] datetime_recvd = new DateTime[5];
                while (OdbcDR.Read())
                {
                    datetime_recvd[i] = (DateTime) OdbcDR[0];
                    if (i>0)
                        if (datetime_recvd[i] != datetime_recvd[i - 1])
                            deleterecords(i-1,datetime_recvd[i]);     
                    
                    i++;
                }
                OdbcCom = new OdbcCommand("SELECT date_modified FROM update_state", OdbcCon);
                OdbcDR = OdbcCom.ExecuteReader();
                
                while (OdbcDR.Read())
                {
                    datetime_recvd[0] = (DateTime)OdbcDR[0];
                    
                    string date_recvd = datetime_recvd[0].ToString("yyyyMMdd");
                                        
                    if (today.CompareTo(date_recvd)==0)
                        updated = 0;
                    else if (today.CompareTo(date_recvd)!=0)
                    {
                        updated = 1;
                        break;
                    }
                  //  i++;
                }


                

            }
       
            return updated;
        }


        public void deleterecords(int i,System.DateTime date)
        {   
            string[] tablename={"pcc","pcl","hcd","afs","uan"};
            for(int j=i;j>=0;--j)
            {
                OdbcCom = new OdbcCommand("DELETE from "+tablename[j]+date.ToString("MM")+" where day(StopDateandTime)="+date.Add(System.TimeSpan.FromDays(1)).ToString("dd") , OdbcCon);
                MessageBox.Show("DELETE from "+tablename[j]+date.ToString("MM")+" where day(StopDateandTime)="+date.Add(System.TimeSpan.FromDays(1)).ToString("dd")); 
                OdbcCom.ExecuteNonQuery();

                OdbcCom = new OdbcCommand("UPDATE update_state SET date_modified=" + date.ToString("yyyyMMdd") + " WHERE tables='" + tablename[j].ToString()+"'", OdbcCon);
                MessageBox.Show("UPDATE update_state SET date_modified=" + date.ToString("yyyyMMdd") + " WHERE tables='" +tablename[j].ToString()+"'");
                OdbcCom.ExecuteNonQuery();
            }
        }
          
        #endregion

        private void btndisplay_Click(object sender, EventArgs e)
        {
            if (connectionToolStripMenuItem.Text == "Connect")
            {
                MessageBox.Show("Connection not opened");
            }

            else
            {
                int SheetsRequired = 0;
                bool[] flagServices ={ false, false, false, false, false };

                if (this.chkbxpcc.Checked == true) { SheetsRequired++; flagServices[0]=true; }
                if (this.chkbxpcl.Checked == true) { SheetsRequired++; flagServices[1]=true; }
                if (this.chkbxafs.Checked == true) { SheetsRequired++; flagServices[2]=true; }
                if (this.chkbxhcd.Checked == true) { SheetsRequired++; flagServices[3]=true; }
                if (this.chkbxuan.Checked == true) { SheetsRequired++; flagServices[4]=true; }

                bool CheckValidDates = true;
                //5,4,... for pcc, pcl,afs ,.....
                               

                    #region Summary Report Code
                    if (cmbbxdsplsel.Text == "Summary Report")
                    {
                        int DatesDifference = System.DateTime.Compare(DateTime.Parse(dateTimePickerend.Text), DateTime.Parse(dateTimePickerstart.Text));
                        forform1.stat_datetimestart = DateTime.Parse(dateTimePickerstart.Text);
                        forform1.stat_datetimeend = DateTime.Parse(dateTimePickerend.Text);
                        flagServices.CopyTo(forform1.stat_flagservices, 0);
                        if (DateTime.Parse(dateTimePickerend.Text).Month - DateTime.Parse(dateTimePickerstart.Text).Month > 11) CheckValidDates = false;
                        if (DatesDifference < 0) CheckValidDates = false;
                        if (DateTime.Parse(dateTimePickerend.Text).Date > DateTime.Today.Date) CheckValidDates = false;
                        if (DateTime.Parse(dateTimePickerstart.Text).Date > DateTime.Today.Date) CheckValidDates = false;

                        if (CheckValidDates)
                        {
                            if (cmbBoxSummary.Text == "ChargeClass Wise")
                            {
                                this.statusStrip1.Text = "Please Wait...";
                                SummReport objSummReport = new SummReport();
                                objSummReport.Show();
                                this.statusStrip1.Text = "";

                            }

                            else if (cmbBoxSummary.Text == "Day Wise")
                            {
                                if (gridViewToolStripMenuItem.Checked)
                                {
                                    int UsingSheetNo = 0;
                                    if (this.chkbxpcc.Checked == true) ShowDaySummary("pcc", ++UsingSheetNo);
                                    if (this.chkbxpcl.Checked == true) ShowDaySummary("pcl", ++UsingSheetNo);
                                    if (this.chkbxafs.Checked == true) ShowDaySummary("hcd", ++UsingSheetNo);
                                    if (this.chkbxhcd.Checked == true) ShowDaySummary("afs", ++UsingSheetNo);
                                    if (this.chkbxuan.Checked == true) ShowDaySummary("uan", ++UsingSheetNo);
                                }
                                else if (excelToolStripMenuItem.Checked && validity.uservalue)
                                {
                                    
                                    int UsingSheetNo = 0;
                                    oXL = new Excel.Application();
                                    oXL.Visible = true;
                                    oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));

                                    if (SheetsRequired > 3)
                                        for (int i = 1; i <= SheetsRequired - 3; i++)
                                            oSheet = (Excel._Worksheet)oWB.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                                        

                                    if (this.chkbxpcc.Checked == true) ShowDaySummary("pcc", ++UsingSheetNo);
                                    if (this.chkbxpcl.Checked == true) ShowDaySummary("pcl", ++UsingSheetNo);
                                    if (this.chkbxafs.Checked == true) ShowDaySummary("hcd", ++UsingSheetNo);
                                    if (this.chkbxhcd.Checked == true) ShowDaySummary("afs", ++UsingSheetNo);
                                    if (this.chkbxuan.Checked == true) ShowDaySummary("uan", ++UsingSheetNo);
                                }
                            }

                        }
                        else MessageBox.Show("The dates aren't Valid");

                    }

                    #endregion

                    #region Monthly Report Code

                    if (cmbbxdsplsel.Text == "Monthly Report")
                    {
                        if (gridViewToolStripMenuItem.Checked)
                        {
                            MessageBox.Show("The grid View for Monthly Report is not available");
                        }
                        else if (excelToolStripMenuItem.Checked && validity.uservalue)
                        {
                            int UsingSheetNo = 0;
                            oXL = new Excel.Application();
                            oXL.Visible = true;
                            oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                            //oSheet=(Excel._Worksheet) oWB.ActiveSheet;


                            if (SheetsRequired > 3)
                                for (int i = 1; i <= SheetsRequired - 3; i++)
                                    oSheet = (Excel._Worksheet)oWB.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);

                            if (this.chkbxpcc.Checked == true) { DisplayMonthlyReport("pcc", ++UsingSheetNo, SheetsRequired); }
                            if (this.chkbxpcl.Checked == true) { DisplayMonthlyReport("pcl", ++UsingSheetNo, SheetsRequired); }
                            if (this.chkbxafs.Checked == true) { DisplayMonthlyReport("afs", ++UsingSheetNo, SheetsRequired); }
                            if (this.chkbxhcd.Checked == true) { DisplayMonthlyReport("hcd", ++UsingSheetNo, SheetsRequired); }
                            if (this.chkbxuan.Checked == true) { DisplayMonthlyReport("uan", ++UsingSheetNo, SheetsRequired); }
                        }
                    }
                    #endregion

                    #region Annual Report Code
                    if (cmbbxdsplsel.Text == "Annual Report")
                    {
                        DialogResult AnnualDialogResult = MessageBox.Show("This requires the complete data tables for last 12 months. Do you want to proceed?", "Caution", MessageBoxButtons.YesNo);
                        if (AnnualDialogResult == DialogResult.Yes)
                        {
                            if (gridViewToolStripMenuItem.Checked)
                            {
                                MessageBox.Show("The grid view for Annual Report is not available");
                            }
                            else if (excelToolStripMenuItem.Checked && validity.uservalue)
                            {
                                int UsingSheetNo = 0;
                                oXL = new Excel.Application();
                                oXL.Visible = true;
                                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));

                                if (SheetsRequired > 3)
                                    for (int i = 1; i <= SheetsRequired - 3; i++)
                                        oSheet = (Excel._Worksheet)oWB.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);

                                if (this.chkbxpcc.Checked == true) DisplayAnnualReport("pcc", ++UsingSheetNo);
                                if (this.chkbxpcl.Checked == true) DisplayAnnualReport("pcl", ++UsingSheetNo);
                                if (this.chkbxafs.Checked == true) DisplayAnnualReport("afs", ++UsingSheetNo);
                                if (this.chkbxhcd.Checked == true) DisplayAnnualReport("hcd", ++UsingSheetNo);
                                if (this.chkbxuan.Checked == true) DisplayAnnualReport("uan", ++UsingSheetNo);
                            }
                        }
                    }
                    //oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                
                    #endregion

                    #region Normal Report Code
                    if (cmbbxdsplsel.Text == "Normal Report")
                    {

                        int DatesDifference = System.DateTime.Compare(DateTime.Parse(dateTimePickerend.Text), DateTime.Parse(dateTimePickerstart.Text));
                        if (DateTime.Parse(dateTimePickerend.Text).Month - DateTime.Parse(dateTimePickerstart.Text).Month > 11) CheckValidDates = false;
                        if (DatesDifference < 0) CheckValidDates = false;
                        if (DateTime.Parse(dateTimePickerend.Text).Date > DateTime.Today.Date) CheckValidDates = false;
                        if (DateTime.Parse(dateTimePickerstart.Text).Date > DateTime.Today.Date) CheckValidDates = false;

                        if (CheckValidDates)
                        {
                          
                            int MonthStart = System.DateTime.Parse(dateTimePickerstart.Text).Month;
                            int MonthEnd = System.DateTime.Parse(dateTimePickerend.Text).Month;
                            
                                string MonthString;
                                bool UserInputFlag = false;
                                string whereCondition = "";

                                string QueryStr_PartI = "SELECT ";
                                string QueryStr, QueryStr_PartII;
                                string QueryStr_PartIII = "";
                                String[] CtrlNames = { "", "CallingPartyNumber", "TranslatedPartyNumber", "SpecificChargePart", "StartDateandTime", "StopDateandTime", "Duration", "CallCost", "ChargeClass", "SpecificChgPrtType", "UserID", "SubServiceNumber", "FeeCount", "BaseCallCost", "ExtraCallCost" };
                                int No_of_Columns = 0;
                                //int DatefieldIndex1 = 0, DatefieldIndex2 = 0;
                                
                                #region Checking for user inputs and WhereCondition
                                if (txtbxcallingparty.Enabled && txtbxcallingparty.Text != "" && txtbxcardno.Enabled && txtbxcardno.Text != "")
                                {
                                    UserInputFlag = true;
                                    whereCondition = " callingpartynumber = " + txtbxcallingparty.Text + " and SpecificChargePart=" + txtbxcardno.Text + " and";
                                }
                            
                                else if (txtbxcallingparty.Enabled && txtbxcallingparty.Text != "")
                                {
                                    UserInputFlag = true;
                                    whereCondition = " callingpartynumber like "+"\'"+ txtbxcallingparty.Text.Insert(txtbxcallingparty.Text.Length, "%")+"\'" + " and ";
                                }
                               
                                else if (txtbxcardno.Enabled && txtbxcardno.Text != "")
                                {
                                    UserInputFlag = true;
                                    whereCondition = " specificChargePart like "+"\'"+ txtbxcardno.Text.Insert(txtbxcardno.Text.Length, "%")+ "\'" +" and ";
                                }
                                else if ((txtbxcallingparty.Text == "" && txtbxcardno.Text == ""))// || (txtbxcallingparty))
                                {
                                    UserInputFlag = false;
                                    MessageBox.Show("Please Select CallingPartyNumber or Card No or Both");
                                }
                                #endregion
                                int DatefieldIndex1=0;
                                int DatefieldIndex2=0;
                                if (UserInputFlag)
                                {
                                    # region For UserFlag On      
                                    statusstrip.Text="Please Wait...";
                                   
                                    #region QueryI
                                    for (int i = 1; i < 15; i++)
                                    {
                                        if (flagfield[15 - i] == true)
                                        {
                                            QueryStr_PartI = string.Concat(QueryStr_PartI, CtrlNames[i], " ,");
                                            if (i == 4) { DatefieldIndex1 = No_of_Columns;}// MessageBox.Show("i=" + i.ToString() + "din1=" + DatefieldIndex1.ToString()); }
                                            if (i == 5) { DatefieldIndex2 = No_of_Columns;}// MessageBox.Show("i=" + i.ToString() + "din2=" + DatefieldIndex2.ToString()); }

                                            No_of_Columns++;
                                        }
                                    }
                                    #endregion
                                    if (No_of_Columns == 0)
                                    {
                                        MessageBox.Show("Please Select fields to show from Display Selection Panel");
                                    }
                                    else
                                    {
                                        QueryStr_PartI = QueryStr_PartI.Remove(QueryStr_PartI.Length - 1);

                                        if (excelToolStripMenuItem.Checked && validity.uservalue)
                                        {
                                            #region Excel Part

                                            #region Excel No of Sheets
                                            oXL = new Excel.Application();
                                            oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                                            string CellSelectionStr;

                                            if (SheetsRequired > 3)
                                                for (int i = 1; i <= SheetsRequired - 3; i++)
                                                    oSheet = (Excel._Worksheet)oWB.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);

                                            #endregion

                                            oXL.Visible = true;

                                            #region Region Main Part
                                            int UsingSheetNo = 0;

                                            for (int ServiceIndex = 0; ServiceIndex <= 4; ServiceIndex++)
                                            {
                                                No_of_Columns = 0;
                                                if (!flagServices[ServiceIndex]) continue;
                                                oSheet = (Excel._Worksheet)oWB.Worksheets.get_Item(++UsingSheetNo);

                                                #region No of Columns Required
                                                for (int i = 1; i < 15; i++)
                                                {
                                                    if (flagfield[15 - i] == true)
                                                    {
                                                        //For displaying the column Titles
                                                        CellSelectionStr = string.Concat((Char)(65 + No_of_Columns), 1);
                                                        oRng = oSheet.get_Range(CellSelectionStr, CellSelectionStr);
                                                        oRng.Value2 = CtrlNames[i];
                                                        oRng.Font.Bold = true;

                                                        No_of_Columns++;
                                                    }
                                                }


                                                #endregion
                                                int ExcelFormRowNo = 2;
                                                for (int MonthNo = MonthStart; MonthNo <= MonthEnd; MonthNo++)
                                                {
                                                    if (MonthNo > 9) MonthString = MonthNo.ToString();
                                                    else MonthString = string.Concat("0", MonthNo.ToString());


                                                    QueryStr_PartII = " from " + ServiceStr[ServiceIndex] + MonthString + " where " + whereCondition;
                                                    if (MonthStart == MonthEnd) QueryStr_PartIII = string.Concat(" day(StopDateAndTime)>=" + DateTime.Parse(dateTimePickerstart.Text).Day + " and day(StopDateAndTime)<=" + DateTime.Parse(dateTimePickerend.Text).Day);
                                                    else if (MonthNo == MonthStart) QueryStr_PartIII = string.Concat(" day(StopDateAndTime)>=" + DateTime.Parse(dateTimePickerstart.Text).Day);
                                                    else if (MonthNo != MonthEnd && MonthNo != MonthStart) QueryStr_PartIII = string.Concat(" month(StopDateAndTime)=" + MonthNo.ToString());
                                                    else if (MonthNo == MonthEnd) QueryStr_PartIII = string.Concat(" day(StopDateAndTime)<=" + DateTime.Parse(dateTimePickerend.Text).Day);


                                                    QueryStr = string.Concat(QueryStr_PartI, QueryStr_PartII, QueryStr_PartIII);
                                                    MessageBox.Show(QueryStr);
                                                    OdbcCom = new OdbcCommand(QueryStr, OdbcCon);
                                                    OdbcDR = OdbcCom.ExecuteReader();
                                                    //MessageBox.Show("Done for Month=" + MonthNo.ToString());
                                                    string Formula;
                                                    while (OdbcDR.Read())  //rows
                                                    {
                                                        for (int i = 0; i < No_of_Columns; i++)  //columns
                                                        {
                                                            CellSelectionStr = string.Concat((Char)(65 + i), ExcelFormRowNo);

                                                           
                                                                MessageBox.Show(i.ToString());
                                                                if (i == DatefieldIndex1 || i == DatefieldIndex2)   //=TEXT(39295.39773, "d-mmm-yyyy hh:mm:ss")
                                                                {  //Formula="=TEXT("+OdbcDR[i].ToString()+", \"d-mm-yyyy hh:mm:ss\")";
                                                                    //MessageBox.Show("=TEXT(" + OdbcDR[i].ToString() + ", \"d-mm-yyyy hh:mm:ss\")");
                                                                    MessageBox.Show(OdbcDR[i].ToString());
                                                                    oSheet.get_Range(CellSelectionStr, CellSelectionStr).Formula = OdbcDR[i].ToString();
                                                                }
                                                                //oSheet.get_Range(CellSelectionStr, CellSelectionStr).Formula=" =OdbcDR[i].ToString();
                                                                    
                                                                 oSheet.get_Range(CellSelectionStr, CellSelectionStr).Value2 = OdbcDR[i];
                                                        }
                                                        ExcelFormRowNo++;
                                                    }

                                                } //end for for loop
                                                oSheet.get_Range("A1", "O1").EntireColumn.AutoFit();
                                                CellSelectionStr = string.Concat("A", (ExcelFormRowNo + 2));
                                                oRng = oSheet.get_Range(CellSelectionStr, CellSelectionStr);
                                                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                                oRng.Formula = "Total Records :";
                                                oRng.Font.Bold = true;

                                                CellSelectionStr = string.Concat("B", (ExcelFormRowNo + 2));
                                                oRng = oSheet.get_Range(CellSelectionStr, CellSelectionStr);
                                                oRng.Value2 = ExcelFormRowNo - 2;
                                                //oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                                                oRng.Font.Bold = true;
                                            }
                                            #endregion


                                            #endregion
                                        }
                                        else if (gridViewToolStripMenuItem.Checked)
                                        {
                                            RecordViewForm MyNormalForm = new RecordViewForm();
                                            #region Region Main Form Part
                                            int UsingSheetNo = 0;

                                            for (int ServiceIndex = 0; ServiceIndex <= 4; ServiceIndex++)
                                            {
                                                if (!flagServices[ServiceIndex]) continue;
                                                
                                                DataTable MyDataTable = new DataTable(pnlservices.Controls[5-ServiceIndex].Text);
                                                DataRow dr;

                                                #region No of Columns Required
                                                No_of_Columns = 0;
                                                for (int i = 1; i < 15; i++)
                                                {
                                                    if (flagfield[15 - i] == true)
                                                    {
                                                        //For displaying the column Titles
                                                        MyDataTable.Columns.Add(new DataColumn(CtrlNames[i], typeof(string))); 
                                                        No_of_Columns++;
                                                    }
                                                }
                                                
                                                #endregion
                                 
                                                for (int MonthNo = MonthStart; MonthNo <= MonthEnd; MonthNo++)
                                                {
                                                    if (MonthNo > 9) MonthString = MonthNo.ToString();
                                                    else MonthString = string.Concat("0", MonthNo.ToString());

                                                    QueryStr_PartII = " from " + ServiceStr[ServiceIndex] + MonthString + " where " + whereCondition;
                                                    if (MonthStart == MonthEnd) QueryStr_PartIII = string.Concat(" day(StopDateAndTime)>=" + DateTime.Parse(dateTimePickerstart.Text).Day + " and day(StopDateAndTime)<=" + DateTime.Parse(dateTimePickerend.Text).Day);
                                                    else if (MonthNo == MonthStart) QueryStr_PartIII = string.Concat(" day(StopDateAndTime)>=" + DateTime.Parse(dateTimePickerstart.Text).Day);
                                                    else if (MonthNo != MonthEnd && MonthNo != MonthStart) QueryStr_PartIII = string.Concat(" month(StopDateAndTime)=" + MonthNo.ToString());
                                                    else if (MonthNo == MonthEnd) QueryStr_PartIII = string.Concat(" day(StopDateAndTime)<=" + DateTime.Parse(dateTimePickerend.Text).Day);


                                                    QueryStr = string.Concat(QueryStr_PartI, QueryStr_PartII, QueryStr_PartIII);
                                                    //MessageBox.Show(QueryStr);
                                                    OdbcCom = new OdbcCommand(QueryStr, OdbcCon);
                                                    OdbcDR = OdbcCom.ExecuteReader();
                                                    //MessageBox.Show("Done for Month=" + MonthNo.ToString());

                                                    while (OdbcDR.Read())  //rows
                                                    {
                                                        dr = MyDataTable.NewRow();
                                                        for (int i = 0; i < No_of_Columns; i++)  //columns
                                                        {
                                                            dr[i] = OdbcDR[i].ToString();
                                                        }
                                                        MyDataTable.Rows.Add(dr);
                                                    }

                                                } //end for for loop
                                                DataView MyView = new DataView(MyDataTable);
                                                MyView = MyDataTable.DefaultView;
                                                MyView.AllowEdit = false;
                                                
                                                MyNormalForm.Text = "Normal Form";

                                                DataGridTableStyle MyGridStyle = new DataGridTableStyle();
                                                MyGridStyle.AlternatingBackColor = System.Drawing.Color.AliceBlue;
                                                MyGridStyle.GridLineColor = System.Drawing.Color.MediumSlateBlue;
                                                MyGridStyle.ColumnHeadersVisible=true;
                                                
                                                MyGridStyle.ReadOnly = true;
                                                
                                                MyNormalForm.DataGridRecords.TableStyles.Add(MyGridStyle);
                                                MyNormalForm.DataGridRecords.SetDataBinding(MyView, "");
                                                MyNormalForm.Show();
                                                UsingSheetNo++;

                                            }
                                            #endregion

                                        }
                                    }
                                    statusstrip.Text = "";
                                    #endregion
                                }

                           
                        }
                        else MessageBox.Show("Please Enter the Valid Date");
                    }
                    #endregion
                
                

                //oXL.UserControl = true;
            }
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fclsabout About = new fclsabout();
            About.ShowDialog();
        }

        void ShowDaySummary(string ServiceStr, int UsingSheetNo)
        {
            
            string QueryStr_PartI = "SELECT date(max(StopDateandTime)), count(*), sum(CallCost), sum(CallCost)/count(*), sum(Duration), sum(Duration)/count(*)";
            string QueryStr = "";
            string QueryStr_PartII = "";
            string QueryStr_PartIII = "";

            int MonthStart = System.DateTime.Parse(dateTimePickerstart.Text).Month;
            int MonthEnd = System.DateTime.Parse(dateTimePickerend.Text).Month;
            string MonthString, CellSelectionStr, CellSelectionStr1, CellSelectionStr2;
            string[] TitleStr ={ "Date", "No. of Calls", "Total Call Cost(Rs.)", "Avg Call Cost(Rs.)", "Total Call Duration(sec)", "Total Call Duration(hh:mm:ss)", "Average Call(sec)" };
            string Formula;

            this.statusStrip1.Text = "Please Wait...";

            if (excelToolStripMenuItem.Checked && validity.uservalue)
            {
                #region Allignments and titles
                oSheet = (Excel._Worksheet)oWB.Worksheets.get_Item(UsingSheetNo);
                oRng = oSheet.get_Range("A3", "G3");
                oRng.Value2 = TitleStr;
                oRng.Interior.ColorIndex = 36;

                oRng.EntireRow.RowHeight = 25;
                oRng.EntireRow.Font.Bold = true;
                oRng.EntireRow.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.EntireRow.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                oRng = oSheet.get_Range("A1", "G1");
                oRng.EntireColumn.AutoFit();
                oRng.Merge(Missing.Value);
                oRng.Formula = "Statistics of " + ServiceStr + " Calls from " + DateTime.Parse(dateTimePickerstart.Text).Date.ToString("yyyy-MM-dd") + " TO " + DateTime.Parse(dateTimePickerend.Text).Date.ToString("yyyy-MM-dd");
                oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                oRng.Font.Bold = true;
                oRng.Font.Underline = true;
                oSheet.Name = ServiceStr;
                #endregion       

                int ExcelRowNo = 4; int DayStart = 0; int DayEnd = 0;
                for (int MonthNo = MonthStart; MonthNo <= MonthEnd; MonthNo++)
                {
                    #region for each month
                    if (MonthNo > 9) MonthString = MonthNo.ToString();
                    else MonthString = string.Concat("0", MonthNo.ToString());

                    QueryStr_PartII = " from " + ServiceStr + MonthString + " where ";

                    if (MonthNo == MonthStart) DayStart = DateTime.Parse(dateTimePickerstart.Text).Day;
                    else DayStart = 1;
                    if (MonthNo == MonthEnd) DayEnd = DateTime.Parse(dateTimePickerend.Text).Day;
                    else DayEnd = System.DateTime.DaysInMonth(DateTime.Parse(dateTimePickerend.Text).Year, MonthEnd);

                    for (int DayNo = DayStart; DayNo <= DayEnd; DayNo++)
                    {
                        #region for each day
                        QueryStr_PartIII = string.Concat("day(StopDateAndTime)= " + DayNo);
                        QueryStr = string.Concat(QueryStr_PartI, QueryStr_PartII, QueryStr_PartIII);

                        OdbcCom = new OdbcCommand(QueryStr, OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        //MessageBox.Show(QueryStr);

                        while (OdbcDR.Read())  //rows
                        {
                            if (OdbcDR[0].ToString() == "") continue;
                            for (int i = 0; i < 7; i++)  //columns
                            {
                                CellSelectionStr = string.Concat((Char)(65 + i), ExcelRowNo);
                                oRng = oSheet.get_Range(CellSelectionStr, CellSelectionStr);

                                if (i == 1)
                                {
                                    if (OdbcDR[1].ToString() == "0") break; //{ MessageBox.Show("Condition Valid"); break; }
                                }
    
                                if (i <= 4 && i>=1) oRng.Value2 = OdbcDR[i];
                                else if( i!=0) oRng.Value2 = OdbcDR[i - 1];
                                if (i == 5) oRng.Formula = "=ROUNDDOWN((" + oRng.Value2.ToString() + "/3600),0)&\":\"&ROUNDDOWN(MOD(" + oRng.Value2.ToString() + ",3600)/60,0)&\":\"&MOD((MOD(" + oRng.Value2.ToString() + ",3600)),60)";
                                if (i == 2 || i == 3) oRng.Formula = "=" + oRng.Value2.ToString() + "/10000";
                                if (i == 0) { oRng.Value2 = DateTime.Parse(OdbcDR[i].ToString()).Date.ToString("yyyy-MM-dd"); } 
                           
                            }
                            ExcelRowNo++;
                            if (ExcelRowNo == 5)
                            {
                                oRng = oSheet.get_Range("A1", "G1");
                                oRng.EntireColumn.AutoFit();
                            }
                        }
                        #endregion
                    }
                    #endregion

                }
                ExcelRowNo--;
                #region Summing Region
                for (int RowNo = ExcelRowNo + 3; RowNo <= ExcelRowNo + 6; RowNo++)
                {
                    CellSelectionStr1 = "B" + RowNo;
                    CellSelectionStr2 = "D" + RowNo;
                    CellSelectionStr = "E" + RowNo;


                    if (RowNo == ExcelRowNo + 3)
                    {
                        oRng = oSheet.get_Range(CellSelectionStr1, CellSelectionStr2);
                        oRng.Merge(Missing.Value);
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Font.Bold = true;
                        oRng.Formula = "Total No of Calls :";
                        Formula = "=sum(B4:B" + ExcelRowNo.ToString();
                        oSheet.get_Range(CellSelectionStr, CellSelectionStr).Formula = Formula;
                    }
                    else if (RowNo == ExcelRowNo + 4)
                    {
                        oRng = oSheet.get_Range(CellSelectionStr1, CellSelectionStr2);
                        oRng.Merge(Missing.Value);
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Font.Bold = true;
                        oRng.Formula = "Total Call Cost in Rs. :";
                        Formula = "=sum(C4:C" + ExcelRowNo.ToString();
                        oSheet.get_Range(CellSelectionStr, CellSelectionStr).Formula = Formula;
                    }
                    else if (RowNo == ExcelRowNo + 5)
                    {
                        oRng = oSheet.get_Range(CellSelectionStr1, CellSelectionStr2);
                        oRng.Merge(Missing.Value);
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Font.Bold = true;
                        oRng.Formula = "Average Call Duration in second  :";
                        Formula = "=sum(E4:E" + ExcelRowNo.ToString() + ")/E" + (int)(RowNo - 2);
                        oSheet.get_Range(CellSelectionStr, CellSelectionStr).Formula = Formula;

                    }

                    else if (RowNo == ExcelRowNo + 6)
                    {
                        oRng = oSheet.get_Range(CellSelectionStr1, CellSelectionStr2);
                        oRng.Merge(Missing.Value);
                        oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        oRng.Font.Bold = true;
                        oRng.Formula = "Average Call Cost in Rs :";
                        Formula = "=E" + (int)(RowNo - 2) + "/E" + (int)(RowNo - 3);
                        oSheet.get_Range(CellSelectionStr, CellSelectionStr).Formula = Formula;

                    }

                }
                #endregion

            }
            else if (gridViewToolStripMenuItem.Checked)
            {
                
                RecordViewForm MyDayRecordForm = new RecordViewForm();
                DataTable MyDataTable = new DataTable("ChargeClassTable");
                DataRow dr;
                MyDayRecordForm.Show();
                
                MyDataTable.Columns.Add(new DataColumn("Date", typeof(System.DateTime)));
                MyDataTable.Columns.Add(new DataColumn("Total_Calls", typeof(string)));
                MyDataTable.Columns.Add(new DataColumn("Total_Cost", typeof(string)));
                MyDataTable.Columns.Add(new DataColumn("Average CallCost", typeof(string)));
                MyDataTable.Columns.Add(new DataColumn("Total_Duration", typeof(string)));
                MyDataTable.Columns.Add(new DataColumn("Avg. Call Duration", typeof(string)));
                MyDayRecordForm.Text = ServiceStr + " Grid View";
   
                int DayStart = 0; int DayEnd = 0;
                for (int MonthNo = MonthStart; MonthNo <= MonthEnd; MonthNo++)
                {
                    #region for each month
                    if (MonthNo > 9) MonthString = MonthNo.ToString();
                    else MonthString = string.Concat("0", MonthNo.ToString());

                    QueryStr_PartII = " from " + ServiceStr + MonthString + " where ";

                    if (MonthNo == MonthStart) DayStart = DateTime.Parse(dateTimePickerstart.Text).Day;
                    else DayStart = 1;
                    if (MonthNo == MonthEnd) DayEnd = DateTime.Parse(dateTimePickerend.Text).Day;
                    else DayEnd = System.DateTime.DaysInMonth(DateTime.Parse(dateTimePickerend.Text).Year, MonthEnd);

                    for (int DayNo = DayStart; DayNo <= DayEnd; DayNo++)
                    {
                        #region for each day
                        
                        QueryStr_PartIII = string.Concat("day(StopDateAndTime)= " + DayNo);
                        QueryStr = string.Concat(QueryStr_PartI, QueryStr_PartII, QueryStr_PartIII);

                        OdbcCom = new OdbcCommand(QueryStr, OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();
                        MessageBox.Show(QueryStr);

                        while (OdbcDR.Read())  //rows
                        {
                            if (OdbcDR[0].ToString() == "")  continue; 
                            dr = MyDataTable.NewRow();
                            for (int i = 0; i < 6; i++)  //columns
                            {
                                //MessageBox.Show(OdbcDR[i].ToString());
                                dr[i] =  OdbcDR[i].ToString();
                                if (i == 1)
                                {
                                    if (OdbcDR[1].ToString() == "0") {  break; }
                                }  
                            }
                            MyDataTable.Rows.Add(dr);
                        }
                        #endregion
                    }
                    #endregion
                }
                
                DataView MyView = new DataView(MyDataTable);
                MyView = MyDataTable.DefaultView;
                MyView.AllowEdit = false;
                DataGridTableStyle MyGridStyle = new DataGridTableStyle();
                MyGridStyle.AlternatingBackColor = System.Drawing.Color.AliceBlue;
                MyGridStyle.GridLineColor = System.Drawing.Color.MediumSlateBlue;
                MyGridStyle.ReadOnly = true;

                              

                MyDayRecordForm.DataGridRecords.TableStyles.Add(MyGridStyle);
                MyDayRecordForm.DataGridRecords.SetDataBinding(MyView, "");
                
                MyDayRecordForm.Show();
            }
            this.statusStrip1.Text = "";

        }

        void DisplayNormalReport(string ServiceStr, int UsingSheetNo, int SheetsRequired)
        {
            
            
        }

        void DisplayAnnualReport(string ServiceStr, int UsingSheetNo)
        {
           
            String[,] monthstr ={ { "January" }, { " Feburary" }, { " March" }, { "April" }, { " May" }, { "Jun" }, { "July " }, { " August" }, { "September" }, { " Octuber" }, { "November" }, { "December" } };
            String[,] monthstrSorted = new String[12, 1];
            String[] str ={ "pcc", "pcl", "afs", "hcd", "uan" };
            String[] annualtitle ={ "Month", "Total Calls", "Total Cost" };

            oSheet = (Excel._Worksheet)oWB.Worksheets.get_Item(UsingSheetNo);
            oSheet.Name = "Annual" + ServiceStr + "Table";
            oRng = oSheet.get_Range("A1", "C1"); oRng.Value2 = annualtitle;
            oRng = oSheet.get_Range("A2", "A13");

            for (int i = 0, m = 0; i < 12; i++)
            {
                m = i + System.DateTime.Today.Month;
                if (m >= 12) m -= 12;
                // MessageBox.Show("i="+i.ToString()+" m="+m.ToString());
                monthstrSorted[i, 0] = monthstr[m, 0];
            }
            oRng.Value2 = monthstrSorted;
            oRng.Font.Bold = true;
            oRng.EntireColumn.AutoFit();

            int j; int k = 0;
            string MonthModified;
            for (k = 0; k < 12; k++)   //For 12 Months which Starts from the last year to current running month
            {
                j = DateTime.Today.Month + k;
                if (j >= 12) j = j - 12;
                if (j < 9) MonthModified = string.Concat("0", j + 1);
                else MonthModified = string.Concat("", j + 1);

                OdbcCom = new OdbcCommand("SELECT count(*), sum(CallCost) FROM " + ServiceStr + MonthModified, OdbcCon);
                OdbcDR = OdbcCom.ExecuteReader();

                while (OdbcDR.Read())                  //No. of Rows
                {
                    for (int i = 0; i <= 1; i++)       //No. of Columns
                    {
                        string str1 = string.Concat((Char)(66 + i), k + 2);
                        oSheet.get_Range(str1, str1).Value2 = OdbcDR[i];
                    }
                }
            }

            oRng = oSheet.get_Range("B2", "B13");
            oChart = (Excel._Chart)oWB.Charts.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oChart.ChartWizard(oRng, Excel.XlChartType.xl3DColumn, Missing.Value, Excel.XlRowCol.xlColumns, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oChart.Name = "Annual" + ServiceStr + "Bar";
            oSeries = (Excel.Series)oChart.SeriesCollection(1);
            oSeries.XValues = oSheet.get_Range("A2", "A13");
            oSeries.Name = "Total Calls";
            oChart.Location(Excel.XlChartLocation.xlLocationAsObject, oSheet.Name);

            oRng = oSheet.get_Range("C2", "C13");
            oChart = (Excel._Chart)oWB.Charts.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oChart.ChartWizard(oRng, Excel.XlChartType.xl3DColumn, Missing.Value, Excel.XlRowCol.xlColumns, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oSeries = (Excel.Series)oChart.SeriesCollection(1);
            oSeries.XValues = oSheet.get_Range("A2", "A13");
            oSeries.Name = "Total Costs";
            oChart.Location(Excel.XlChartLocation.xlLocationAsObject, oSheet.Name);

            //Move the chart1 so as not to cover your data.
            oRng = (Excel.Range)oSheet.Rows.get_Item(2, Missing.Value);
            oSheet.Shapes.Item("Chart 1").Top = (float)(double)oRng.Top;
            oRng = (Excel.Range)oSheet.Columns.get_Item(5, Missing.Value);
            oSheet.Shapes.Item("Chart 1").Left = (float)(double)oRng.Left;

            //Move the chart2 so as not to cover your data.
            oRng = (Excel.Range)oSheet.Rows.get_Item(17, Missing.Value);
            oSheet.Shapes.Item("Chart 2").Top = (float)(double)oRng.Top;
            oRng = (Excel.Range)oSheet.Columns.get_Item(5, Missing.Value);
            oSheet.Shapes.Item("Chart 2").Left = (float)(double)oRng.Left;
        
        }

        void DisplayMonthlyReport(string ServiceStr, int UsingSheetNo, int SheetsRequired)
        {

            string[] statustitle = { "Charge Class", "Total Records", "Call Cost", "Total Duration", "Call Type", "Call Types General", "Call Cost2", "% Call Cost" };
            oSheet = (Excel._Worksheet)oWB.Worksheets.get_Item(UsingSheetNo);
            oSheet.Name = ServiceStr + "Table";

            oRng = oSheet.get_Range("A1", "H1");
            oRng.Value2 = statustitle;
            oRng.Font.Bold = true;
            oRng.EntireColumn.AutoFit();

            for (int k = 1; k <= 11; k++)
            {
                OdbcCom = new OdbcCommand("SELECT sum(ChargeClass)/count(*), count(*), sum(CallCost), sum(Duration) FROM " + ServiceStr + cmbbxmonthsel.Text + " WHERE ChargeClass=" + k.ToString(), OdbcCon);
                //OdbcCom = new OdbcCommand("SELECT CallCost, TotalDuration FROM mycdr WHERE ChargeClass=3", OdbcCon);
                OdbcDR = OdbcCom.ExecuteReader();

                while (OdbcDR.Read())  //rows
                {
                    for (int i = 0; i <= 3; i++)  //columns
                    {
                        string str1 = new string((Char)(65 + i), 1);
                        str1 = string.Concat(str1, k + 1);
                        oSheet.get_Range(str1, str1).Value2 = OdbcDR[i];
                    }

                }
            }


            string[,] calltypestr = { { "Local" }, { "STD A" }, { "STD B" }, { "Zonal PSTN" }, { "Trans Boarder" }, { "ISD 00" }, { "" }, { "India" }, { "SAARC except India" }, { "Budget Call" }, { "Zonal Mobile" } };
            oRng = oSheet.get_Range("E2", "E12");
            oRng.Value2 = calltypestr;

            oRng = oSheet.get_Range("F3", "F5");
            oRng.Merge(Missing.Value);
            oRng = oSheet.get_Range("F2", "F12");
            oRng.Value2 = calltypestr;
            oSheet.get_Range("F3", "F3").Value2 = "STD";
            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRng = oSheet.get_Range("G3", "G5");
            oRng.Merge(Missing.Value);
            oRng = oSheet.get_Range("H3", "H5");
            oRng.Merge(Missing.Value);
            oRng = oSheet.get_Range("D13", "E13");
            oRng.Merge(Missing.Value);
            oRng.Formula = "Total Call Cost";
            oRng.Font.Bold = true;

            oRng = oSheet.get_Range("G2", "G12");
            oRng.Formula = "=C2";
            oSheet.get_Range("G13", "G13").Formula = "=sum(G2:G12)";
            oRng = oSheet.get_Range("H2", "H12");
            oRng.Formula = "=G2/$G$13";

            oRng = oSheet.get_Range("A1", "H1");
            oRng.EntireColumn.AutoFit();
            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

            oRng = oSheet.get_Range("H2:H12", Missing.Value);
            if (oSheet.get_Range("G13", "G13").Value2.ToString() == "0") MessageBox.Show("Can't Show Pie Chart for " + ServiceStr + "  Because the record is empty");
            else
            {
                oChart = (Excel._Chart)oWB.Charts.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                oChart.ChartWizard(oRng, Excel.XlChartType.xl3DPie, Missing.Value, Excel.XlRowCol.xlColumns, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                oChart.Name = ServiceStr + "Chart";
                //oChart.ChartTitle = "Chart for " + ServiceStr;
                //oSeries = (Excel.Series)oChart.SeriesCollection(1);
                //oSeries.Name = ServiceStr + "Chart";

            }

            //oSeries.XValues=oSheet.get_Range("F2","F12"); 
            //oChart.ChartTitle.Text = ServiceStr + " Call Types Status";

        }
  
     
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbbxmonthsel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MISmain_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSummary.Text == "ChargeClass Wise")
            {
                
            }

           
        }

        private void dateTimePickerend_ValueChanged(object sender, EventArgs e)
        {
           forform1.stat_datetimeend = DateTime.Parse(dateTimePickerend.Text);
        }

        private void paneluser_Paint(object sender, PaintEventArgs e)
        {            
        }

        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excelToolStripMenuItem.Checked = (!gridViewToolStripMenuItem.Checked);
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridViewToolStripMenuItem.Checked = (!excelToolStripMenuItem.Checked);
        }

        private void txtbxcardno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void menustripmain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
    }
}