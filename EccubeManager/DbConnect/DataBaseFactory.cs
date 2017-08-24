﻿using Npgsql;
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
                    return  new NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostgreSqlConnection"].ConnectionString);
                case "MySQL":
                    return null;
            }
            return new NpgsqlConnection(ConfigurationManager.ConnectionStrings["PostgreSqlConnection"].ConnectionString);

        }
    }
}