

namespace CWR.DataService.DBConnection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Configuration;
    /// <summary>
    /// Connection class
    /// </summary>
    public static class ConnectionInfo
    {
        /// <summary>
        /// Gets connection string
        /// </summary>
        /// <returns>connection string</returns>
        public static string GetConnectionString
        {
            get
            {
                string connectionString = string.Empty;
                connectionString = ConfigurationManager.ConnectionStrings["CWR_Connection"].ConnectionString;
                return connectionString;
            }
        }
    }
}
