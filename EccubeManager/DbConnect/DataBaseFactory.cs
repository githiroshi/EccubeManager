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
            var conectionString = "Server={0};Port={1};Database={2};UserId={3};Password={4};";

            switch (dbName)
            {
                case "Postgres":
                    var PostgreSqlConnection = string.Format(conectionString,
                                                Properties.Settings.Default.PostgresServer
                                                , Properties.Settings.Default.PostgresPort
                                                , Properties.Settings.Default.PostgresDatabase
                                                , Properties.Settings.Default.PostgresUserId
                                                , Properties.Settings.Default.PostgresPassword);

                    return new NpgsqlConnection(PostgreSqlConnection);

                case "MySQL":
                    var MySQLConnection = string.Format(conectionString,
                                                Properties.Settings.Default.MysqlServer
                                                , Properties.Settings.Default.MysqlPort
                                                , Properties.Settings.Default.MysqlDatabase
                                                , Properties.Settings.Default.MysqlUserId
                                                , Properties.Settings.Default.MysqlPassword);

                    return new MySqlConnection(MySQLConnection);

                    //Debug
                case "HerokuPostgres":
                    var HerokuPostgreSqlConnection = string.Format("User ID={0};Password={1};Host={2};Port={3};Database={4};Pooling=true;Use SSL Stream=True;SSL Mode=Require;TrustServerCertificate=True;",
                                                Properties.Settings.Default.PostgresUserId
                                                , Properties.Settings.Default.PostgresPassword
                                                , Properties.Settings.Default.PostgresServer
                                                , Properties.Settings.Default.PostgresPort
                                                , Properties.Settings.Default.PostgresDatabase);

                    return new NpgsqlConnection(HerokuPostgreSqlConnection);
            }
            return null;

    
        }
    }
}
