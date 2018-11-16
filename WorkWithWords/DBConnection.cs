using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SqlClient;

namespace WorkWithWords
{
    class DBConnection
    {
        public string GetConnectionString()
        {
            var Prefix = "sqlite";
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ConfigurationManager
    .AppSettings[$"{Prefix}DatabaseLocation"],
                InitialCatalog = ConfigurationManager
    .AppSettings[$"{Prefix}DatabaseName"],
                IntegratedSecurity = true
            };
            return builder.ConnectionString;
        }
    }
}
