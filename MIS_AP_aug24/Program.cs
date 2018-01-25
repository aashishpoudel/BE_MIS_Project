using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MIS
{
    static public class validity
    {
        static public bool authenticated;
        static public bool cancelled;
        static public bool uservalue;
        
    }
    static public class constring
    {
        static public string hostname;
        static public string portno;
        static public string username;
        static public string password;
        static public string database;
        static public bool connect;
    }
    static public class forform1
    {
        static public DateTime stat_datetimestart = new DateTime();
        static public DateTime stat_datetimeend = new DateTime();
        static public bool[] stat_flagservices=new bool[5];
    }

    static public class forChargeClass
    {
        static public long[] TotalRec = new long[12];
        static public long[] sumCallCost = new long[12];
        static public long[] SumTotalDuration = new long[12];
        static public StatusStrip viewStatusStrip = new StatusStrip();
    }
  
    static class Program
    {
    
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MISmain());
        }
    }
}