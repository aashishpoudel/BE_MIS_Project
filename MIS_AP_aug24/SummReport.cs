using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace MIS
{
    public partial class SummReport : Form
    {

        #region required excel object variables
        Excel.Application oXL;
        Excel._Workbook oWB;
        Excel._Worksheet oSheet;
        Excel._Chart oChart;
        Excel.Range oRng;
        Excel.Series oSeries;

        #endregion
        #region required database connectivity variables

        private System.Data.Odbc.OdbcConnection OdbcCon;
        private System.Data.Odbc.OdbcCommand OdbcCom;
        private System.Data.Odbc.OdbcDataReader OdbcDR;
        private string ConStr;
   
        #endregion

        
        string[] ServiceStr ={ "pcc", "pcl", "afs", "hcd", "uan" };
        
        public SummReport()
        {
            InitializeComponent();
        }

        private void btnCloseSummary_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SummReport_Load(object sender, EventArgs e)
        {
            ConStr = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=" + constring.hostname + "; PORT=" + constring.portno + "; DATABASE=" + constring.database + "; UID=" + constring.username + "; PWD=" + constring.password + ";OPTION=3";
            OdbcCon = new System.Data.Odbc.OdbcConnection(ConStr);
            OdbcCon.Open();
            
            radioButton2.Checked = true;
            
            #region region 01
           
            string CellSelectionStr;
            string QueryStr_PartI = "SELECT count(*), sum(CallCost), sum(Duration)";
            string QueryStr = "";
            string QueryStr_PartII = "";
            string QueryStr_PartIII = "";

            int No_of_Months;
            int MonthStart = forform1.stat_datetimestart.Month;
            int MonthEnd = forform1.stat_datetimeend.Month;
            string MonthString;
            string WhereConditionStr = "";
            if ((MonthEnd - MonthStart) < 0) No_of_Months = MonthEnd - MonthStart + 12 + 1;
            else No_of_Months = MonthEnd - MonthStart + 1;

            #endregion

            #region region 02

            for (int ChargeClassNo = 1; ChargeClassNo <= 11; ChargeClassNo++)
            {
                forChargeClass.TotalRec [ChargeClassNo - 1] = 0;
                forChargeClass.sumCallCost[ChargeClassNo - 1] = 0;
                forChargeClass.SumTotalDuration[ChargeClassNo - 1] = 0;

                WhereConditionStr = string.Concat(" ChargeClass = " + ChargeClassNo.ToString() + " and ");
                for (int n = 0; n <= 4; n++)  //No of Services  0 for pcc ,   .....   , 4 for uan
                {
                    if (forform1.stat_flagservices[n] == false) continue;
                    for (int MonthNo = MonthStart; MonthNo <= MonthEnd; MonthNo++)
                    {
                        #region for No of Months
                        if (MonthNo > 9) MonthString = MonthNo.ToString();
                        else MonthString = string.Concat("0", MonthNo.ToString());

                        QueryStr_PartII = " from " + ServiceStr[n] + MonthString + " where " + WhereConditionStr;

                        if (MonthStart == MonthEnd) QueryStr_PartIII = string.Concat("day(StopDateAndTime)>=" + forform1.stat_datetimestart.Day + " and day(StopDateAndTime)<=" + forform1.stat_datetimeend.Day);
                        else if (MonthNo == MonthStart) QueryStr_PartIII = string.Concat("day(StopDateAndTime)>=" + forform1.stat_datetimestart.Day);
                        else if (MonthNo != MonthEnd && MonthNo != MonthStart) QueryStr_PartIII = string.Concat("month(StopDateAndTime)=" + MonthNo.ToString());
                        else if (MonthNo == MonthEnd) QueryStr_PartIII = string.Concat("day(StopDateAndTime)<=" + forform1.stat_datetimeend.Day);

                        QueryStr = string.Concat(QueryStr_PartI, QueryStr_PartII, QueryStr_PartIII);
                        OdbcCom = new System.Data.Odbc.OdbcCommand(QueryStr, OdbcCon);
                        OdbcDR = OdbcCom.ExecuteReader();


                        while (OdbcDR.Read())  //rows
                        {
                            forChargeClass.TotalRec [ChargeClassNo - 1] += Int64.Parse(OdbcDR[0].ToString());
                            if (forChargeClass.TotalRec [ChargeClassNo - 1] == 0) break;

                            //MessageBox.Show(QueryStr+ "  "+ forChargeClass.TotalRec [ChargeClassNo - 1].ToString()    +"  forChargeClass.sumCallCost["+ChargeClassNo.ToString() +"- 1]"+" "+OdbcDR[1].ToString());
                            
                            if(Int64.Parse(OdbcDR[0].ToString())!=0) forChargeClass.sumCallCost[ChargeClassNo - 1] += Int64.Parse(OdbcDR[1].ToString()) / 10000;
                            if (Int64.Parse(OdbcDR[0].ToString()) != 0) forChargeClass.SumTotalDuration[ChargeClassNo - 1] += Int64.Parse(OdbcDR[2].ToString());
                        }
                        #endregion
                    }

                }

            }
            forChargeClass.TotalRec [11] = 0; forChargeClass.sumCallCost[11] = 0; forChargeClass.SumTotalDuration[11] = 0;

            for (int ChargeClassNo = 1; ChargeClassNo <= 11; ChargeClassNo++)
            {
                forChargeClass.TotalRec [11] += forChargeClass.TotalRec [ChargeClassNo - 1];
                forChargeClass.sumCallCost[11] += forChargeClass.sumCallCost[ChargeClassNo - 1];
                forChargeClass.SumTotalDuration[11] += forChargeClass.SumTotalDuration[ChargeClassNo - 1];
            }
            #endregion

            txtBxCC.Text = "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
                if(txtBxCC.Text!="11") txtBxCC.Text = Int16.Parse(txtBxCC.Text) + 1 + ""; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                if (txtBxCC.Text != "1") txtBxCC.Text = Int16.Parse(txtBxCC.Text) - 1 + ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)   txtBxCC.Text = "11"; 
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)   txtBxCC.Text = "1"; 
        }

        private void txtBxCC_TextChanged(object sender, EventArgs e)
        {
            if (txtBxCC.Text != "")
            {
                txtTotRec.Text = forChargeClass.TotalRec [Int16.Parse(txtBxCC.Text) - 1].ToString();
                txtTotCost.Text = forChargeClass.sumCallCost[Int16.Parse(txtBxCC.Text) - 1].ToString();
                txtTotDuration.Text = forChargeClass.SumTotalDuration[Int16.Parse(txtBxCC.Text) - 1].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region For Excel Part
            
            
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            oSheet = (Excel._Worksheet)oWB.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            string[] titleCCSummary ={ "Charge Class", "Total Call", "Total Cost", "Total Duration" };
            oSheet.get_Range("A4", "D4").Value2 = titleCCSummary;
            oRng=oSheet.get_Range("A1", "D2");
            oRng.Merge(Missing.Value);
            
            string Formula = "Charge Class Summary from "+forform1.stat_datetimestart.Date.ToString("yyyy-MM-dd")+" to "+forform1.stat_datetimeend.Date.ToString("yyyy-MM-dd") +" From ";
            for (int ServicesIndex = 0; ServicesIndex <= 4; ServicesIndex++)
            {
                if(forform1.stat_flagservices[ServicesIndex]) Formula = string.Concat(Formula, ServiceStr[ServicesIndex],", ");
            }

            Formula = Formula.Remove(Formula.Length - 2);
            oRng.Formula = Formula;
            oRng.Font.Bold = true;
            oRng.VerticalAlignment = Excel.XlVAlign.xlVAlignDistributed;
            oRng.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            
            oRng = oSheet.get_Range("A1", "D1");
            oRng.EntireColumn.AutoFit();                        
            oRng.EntireColumn.HorizontalAlignment=Excel.XlHAlign.xlHAlignCenter;
            string CellSelectionStr;
            for (int ChargeClassIndex = 1; ChargeClassIndex <= 11; ChargeClassIndex++)
            {
                CellSelectionStr = string.Concat("A", ChargeClassIndex + 4);
                oSheet.get_Range(CellSelectionStr, CellSelectionStr).Value2 = ChargeClassIndex.ToString();
                CellSelectionStr = string.Concat("B", ChargeClassIndex + 4);
                oSheet.get_Range(CellSelectionStr, CellSelectionStr).Value2 = forChargeClass.TotalRec [ChargeClassIndex-1].ToString();
                CellSelectionStr = string.Concat("C", ChargeClassIndex + 4);
                oSheet.get_Range(CellSelectionStr, CellSelectionStr).Value2 = forChargeClass.sumCallCost[ChargeClassIndex-1].ToString();
                CellSelectionStr = string.Concat("D", ChargeClassIndex + 4);
                oSheet.get_Range(CellSelectionStr, CellSelectionStr).Value2 = forChargeClass.SumTotalDuration[ChargeClassIndex-1].ToString();
            }

            oRng = oSheet.get_Range("C5:C15", Missing.Value);
            oChart = (Excel._Chart)oWB.Charts.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oChart.ChartWizard(oRng, Excel.XlChartType.xl3DPie, Missing.Value, Excel.XlRowCol.xlColumns, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            oChart.Name = "ChargeClass Chart(Cost)";

            #endregion
        }
              
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnMoveFirst.Enabled = false;
                txtBxCC.Enabled = false;
                txtBxCC.Text = "";

                txtTotRec.Text = forChargeClass.TotalRec [11].ToString();
                txtTotCost.Text = forChargeClass.sumCallCost[11].ToString();
                txtTotDuration.Text = forChargeClass.SumTotalDuration[11].ToString();
                

            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                btnMoveFirst.Enabled = true;
                txtBxCC.Enabled = true;
                txtBxCC.Text = "1";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGridView_Click(object sender, EventArgs e)
        {

            RecordViewForm MyChargeClassForm = new RecordViewForm();
            DataTable MyDataTable = new DataTable("ChargeClassTable");
            DataRow dr;
            

            MyDataTable.Columns.Add(new DataColumn("ChargeClass", typeof(Int16)));
            MyDataTable.Columns.Add(new DataColumn("Total_Calls", typeof(Int32)));
            MyDataTable.Columns.Add(new DataColumn("Total_Cost", typeof(Int64)));
            MyDataTable.Columns.Add(new DataColumn("Total_Duration", typeof(Int64)));
          
            for (int ChargeClassIndex = 1; ChargeClassIndex <= 11; ChargeClassIndex++)
            {
                dr = MyDataTable.NewRow();
                dr[0] = ChargeClassIndex;
                dr[1] = forChargeClass.TotalRec[ChargeClassIndex - 1];
                dr[2] = forChargeClass.sumCallCost[ChargeClassIndex - 1];
                dr[3] = forChargeClass.SumTotalDuration[ChargeClassIndex - 1];

                MyDataTable.Rows.Add(dr);
            }
            DataView MyView = new DataView(MyDataTable);
            MyView = MyDataTable.DefaultView;
            MyView.AllowEdit = false;
            MyDataTable.TableName = "ChargeClassTable";
            DataGridTableStyle MyGridStyle = new DataGridTableStyle();
            MyGridStyle.AlternatingBackColor = System.Drawing.Color.AliceBlue;
            MyGridStyle.GridLineColor = System.Drawing.Color.MediumSlateBlue; 
            MyGridStyle.ReadOnly = true;

            MyChargeClassForm.DataGridRecords.TableStyles.Add(MyGridStyle);
            MyChargeClassForm.DataGridRecords.SetDataBinding(MyView, "");
            MyChargeClassForm.Text = "Charge Class";
            MyChargeClassForm.Show();
                
                 
            /*
                    public static void WriteView(DataView myView)
                    {
                        foreach (DataRowView myDRV in myView)
                        {
                            for (int i = 0; i < myView.Table.Columns.Count; i++)
                            Console.Write(myDRV[i] + "\t");
                            Console.WriteLine();
                        }
                    }
            */
             
        }
             
    }
}
