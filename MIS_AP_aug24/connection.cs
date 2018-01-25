using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MIS
{
    public partial class connection : Form
    {
        public connection()
        {
            constring.hostname = null;
            constring.portno = null;
            constring.username = null;
            constring.password = null;
            constring.database = null;
            InitializeComponent();
        }
        #region windows event handlers
        private void txtBxHostname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxPortNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBxUsename_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxdatabase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void connection_Load(object sender, EventArgs e)
        {

        }
        
        private void btnok_Click(object sender, EventArgs e)
        {
            constring.hostname = txtBxHostname.Text;
            constring.portno = txtBxPortNo.Text;
            constring.username = txtBxUsename.Text;
            constring.password = txtBxPassword.Text;
            constring.database = txtBxdatabase.Text;
            constring.connect = true;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            constring.connect = false;
            this.Close();

        }
        #endregion
    }
}