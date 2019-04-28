using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } = new IDataConnection();

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql) //no need for comparsion if boolean
            {
                //TODO - Set up the  SQL connector properly 
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                //TODO - Create the text connection
                TextConnection text = new TextConnection();
                Connection = text;
            }
        }

        public static string CnnValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
