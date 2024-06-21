using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Commun
{
    class Connection
    {
        static public String CSage()
        {
            // Get the application configuration file.
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            // Get the conectionStrings section.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;

            System.Configuration.ConnectionStringSettings cs = csSection.ConnectionStrings["VpTranferConnectionString"];

            return cs.ConnectionString;
        }

        static public String CString()
        {
            // Get the application configuration file.
           
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);


            // Get the conectionStrings section.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;

            System.Configuration.ConnectionStringSettings cs = csSection.ConnectionStrings["GrpDiffConnectionString"];
            

            
            return cs.ConnectionString;
        }

        /*static public String ReportUser()
        {
            // Get the application configuration file.
            System.Configuration.Configuration config =
                    ConfigurationManager.OpenExeConfiguration(
                    ConfigurationUserLevel.None);

            // Get the conectionStrings section.
            ConnectionStringsSection csSection =
                config.ConnectionStrings;

            System.Configuration.ConnectionStringSettings cs = csSection.ConnectionStrings["SageConnectionString"];

            return cs.ConnectionString;
        }*/
        
    }
}
