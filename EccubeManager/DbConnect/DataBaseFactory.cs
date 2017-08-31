using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccubeManager
{
    class DataBaseFactory
    {
        public IDbConnection DbFactory(string dbName)
        {
            switch (dbName)
            {
                case "Postgres":
                    var PostgreSqlConnection = string.Format("Server={0};Port={1};Database={2};UserId={3};Password={4};",
                                                Properties.Settings.Default.PostgresServer
                                                , Properties.Settings.Default.PostgresPort
                                                , Properties.Settings.Default.PostgresDatabase
                                                , Properties.Settings.Default.PostgresUserId
                                                , Properties.Settings.Default.PostgresPassword);

                    return  new NpgsqlConnection(PostgreSqlConnection);

                case "MySQL":
                    var MySQLConnection = string.Format("Server={0};Port={1};Database={2};UserId={3};Password={4};",
                                                Properties.Settings.Default.MysqlServer
                                                , Properties.Settings.Default.MysqlPort
                                                , Properties.Settings.Default.MysqlDatabase
                                                , Properties.Settings.Default.MysqlUserId
                                                , Properties.Settings.Default.MysqlPassword);

                    return new MySqlConnection(MySQLConnection);
            }
            return new NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostgreSqlConnection"].ConnectionString);

        }
    }
}
