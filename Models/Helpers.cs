using Microsoft.IdentityModel.Protocols;
using NLog.Internal; // NEED THIS to connect to RDS on AWS
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FagElGamousExcavation.Models
{
    public class Helpers
    {
        public static string GetRDSConnectionString()
        {
            var appConfig = ConfigurationManager.AppSettings;

            string dbname = appConfig["INDI"]; // Insert name of RDS database

            //if (string.IsNullOrEmpty(dbname)) return null;

            string username = appConfig["samo"];
            string password = appConfig["unbreakablepassword"];
            string hostname = appConfig["aahsz48oa2tcb2.ch5ywl5a3rrn.us-east-1.rds.amazonaws.com"];
            string port = appConfig["1433"];

            //return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";

            //return "Data Source=aahsz48oa2tcb2.ch5ywl5a3rrn.us-east-1.rds.amazonaws.com;Initial Catalog=INDI; User ID=samo;Password=unbreakablepassword;";

            return "Data Source=aa1t11rvlul533q.ch5ywl5a3rrn.us-east-1.rds.amazonaws.com; Initial Catalog=INDI; User ID=samo;Password=unbreakablepassword;";


            // THE SCAFFOLDING CODE:
            //dotnet ef dbcontext scaffold "Data Source=aa1t11rvlul533q.ch5ywl5a3rrn.us-east-1.rds.amazonaws.com; Initial Catalog=INDI; User ID=samo;Password=unbreakablepassword;" Microsoft.EntityFrameworkCore.Sqlserver -o Models

        }
    }
}
