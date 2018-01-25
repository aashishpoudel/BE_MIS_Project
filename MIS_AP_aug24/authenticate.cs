using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MIS
{
    public partial class authenticate : Form
    {
        private System.Data.Odbc.OdbcConnection AuthCon;
        private System.Data.Odbc.OdbcCommand AuthCom;
        private System.Data.Odbc.OdbcDataReader AuthRead;
        private string ConStr;
        private bool initialset = false;
       
        public authenticate()
       {
           
            InitializeComponent();
            ConStr = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=localhost; PORT=3306; DATABASE=authenticate; UID=auth; PWD=;OPTION=3";
            AuthCon = new System.Data.Odbc.OdbcConnection(ConStr);
            try
            {
                if (AuthCon.State == ConnectionState.Closed)
                {
                    AuthCon.Open();
                }
                //MessageBox.Show("Connection Opened");
                
            }
            catch (System.Data.Odbc.OdbcException Ex)
            {
                
                MessageBox.Show("Could not access the database.\r\nPlease make sure you completed the fields with the correct information and try again.\r\n\r\nMore details:\r\n" + Ex.Message, "Database connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            #region if password not set

            AuthCom = new System.Data.Odbc.OdbcCommand("SELECT passwd FROM mis_pass", AuthCon);
            AuthRead = AuthCom.ExecuteReader();
            string chkpass;
            string[] name ={ "admin", "guest" };
            int term=0;
            while(AuthRead.Read())
            {
                chkpass = (string)AuthRead[0];
                if (chkpass == "")
                {
                    MessageBox.Show(" Please set the password for "+ name[term]);
                    txtbxusername.Text = name[term];
                    txtbxusername.ReadOnly=true;
                    initialset = true;
                    break;
                }
                if (++term > 1)
                    break;

            }
            #endregion


        }
        #region windows form event handlers 
        private void authenticate_Load(object sender, EventArgs e)
        {   
                

        }

        private void btnauthquit_Click(object sender, EventArgs e)
        {  
            validity.cancelled = true;
            AuthCon.Close();
            this.Close();

        }

        private void btnok_Click(object sender, EventArgs e)
        {

            if (initialset == true)
            {
                string newpass = txtbxpassword.Text;
                newpass = EncodePass(newpass, newpass.Length);
                //MessageBox.Show(newpass);
                AuthCom = new System.Data.Odbc.OdbcCommand("UPDATE mis_pass SET passwd='" + newpass + "' WHERE username='" + txtbxusername.Text + "'", AuthCon);
                AuthCom.ExecuteNonQuery();
                MessageBox.Show(" New password updated. please restart application");
                validity.cancelled = true;
                AuthCon.Close();
                this.Close();
            }

            else if (initialset == false)
            {
                if (txtbxusername.Text == "")
                    MessageBox.Show(" Please Specify Username ");
                else if (AuthCon.State == ConnectionState.Open)
                {
                    string passwd = "";
                    AuthCom = new System.Data.Odbc.OdbcCommand("SELECT passwd FROM mis_pass WHERE username='" + txtbxusername.Text + "'", AuthCon);
                    AuthRead = AuthCom.ExecuteReader();
                    while (AuthRead.Read())
                    {
                        passwd = (String)AuthRead[0];
                    }
                    //MessageBox.Show(passwd);
                    if (passwd.CompareTo("") == 0)
                        MessageBox.Show(" Username invalid ");
                    else if (passwd.CompareTo("") != 0)
                    {
                        passwd = DecodePass(passwd, passwd.Length);
                        //MessageBox.Show(passwd);
                        if (passwd.CompareTo(txtbxpassword.Text) == 0)
                        {
                            validity.authenticated = true;
                            if (txtbxusername.Text == "admin")
                                validity.uservalue = true;
                            else
                                validity.uservalue = false;
                        }

                        else
                            validity.authenticated = false;
                        AuthCon.Close();
                        this.Close();
                    }
                }
            }
        }
        #endregion

        private void tablogin_Click(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnok;
            this.CancelButton = this.btnauthquit;

        }

        private void tabchngpass_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelnp_Click(object sender, EventArgs e)
        {
            txtBxconfirm.Text = txtBxnewpass.Text = txtBxnewuser.Text = txtBxoldpass.Text = "";
            
        }

        private void btnOKnp_Click(object sender, EventArgs e)
        {
            if (txtBxnewuser.Text == "")
                MessageBox.Show(" Username not specified ");

            else if (txtBxnewuser.Text != "")
            {
                if (AuthCon.State == ConnectionState.Open)
                {
                    AuthCom = new System.Data.Odbc.OdbcCommand("SELECT username FROM mis_pass", AuthCon);
                    AuthRead = AuthCom.ExecuteReader();
                    string usrnm = "";
                    bool usrchek = false;//indicate that user does not exist

                    while (AuthRead.Read())
                    {
                        usrnm = (string)AuthRead[0];
                        if (usrnm.CompareTo(txtBxnewuser.Text) == 0)
                        {
                            usrchek = true;   // user exists
                            break;
                        }
                    }
                    if (usrchek == false)
                    {
                        MessageBox.Show(" Username name does not exist. Please re-check ");
                    }

                    else if (usrchek == true)
                    {
                        AuthCom = new System.Data.Odbc.OdbcCommand("SELECT passwd FROM mis_pass WHERE username='" + txtBxnewuser.Text+"'", AuthCon);
                        AuthRead = AuthCom.ExecuteReader();
                        string passwd = "";
                        bool passchek = false;//indicate that password is invalid
                        while (AuthRead.Read())
                        {
                            passwd = (string)AuthRead[0];
                            passwd = DecodePass(passwd, passwd.Length);

                            if (passwd.CompareTo(txtBxoldpass.Text) == 0)
                            {
                                passchek = true;   // password valid
                                break;
                            }
                            else if (passwd.CompareTo(txtBxoldpass.Text) != 0)
                                MessageBox.Show(" Invalid Password ");
                        }
                        if (passchek == true)
                        {
                            if (txtBxnewpass.Text.CompareTo(txtBxconfirm.Text) != 0)
                            {
                                MessageBox.Show("The Passwords do not match. Please Retype");
                                txtBxconfirm.Text = txtBxnewpass.Text = "";
                            }
                            else if (txtBxnewpass.Text.CompareTo(txtBxconfirm.Text) == 0)
                            {
                                string newpass = txtBxconfirm.Text;
                                newpass = EncodePass(newpass, newpass.Length);
                                AuthCom = new System.Data.Odbc.OdbcCommand("UPDATE mis_pass SET passwd='" + newpass + "' WHERE username='" + txtBxnewuser.Text+"'", AuthCon);
                                AuthCom.ExecuteNonQuery();
                                MessageBox.Show(" Password changed successfully ");
                            }
                        }
                        else if (passchek == false)
                            MessageBox.Show(" Invalid Password ");

                    }
                }
            }
            else if (AuthCon.State == ConnectionState.Closed)
                MessageBox.Show(" Connection closed ");
        }
        #region password encryption and decryption
        private string EncodePass(string input,int len)
        {   
            int a = 'a';
            char[] ps = input.ToCharArray();
            string output = "";
            for (int i = 0; i < len; ++i)
            {
                ps[i] = (char)(ps[i] + a);
                output = output + ps[i].ToString();
                //a += i;
            }
            //MessageBox.Show(output);
            return output;
        }
        private string DecodePass(string input,int len)
        {

            int a = 'a';
            char[] ps = input.ToCharArray();
            string output = "";
            for (int i = 0; i < len; ++i)
            {
                ps[i] = (char)(ps[i] - a);
                output = output + ps[i].ToString();
                //a += i;
            }
            //MessageBox.Show(output);
            return output;
        }
#endregion


    }
}