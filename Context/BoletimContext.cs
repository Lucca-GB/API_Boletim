﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIboletim.Context
{
    public class BoletimContext
    {
        SqlConnection con = new SqlConnection();
        
        public BoletimContext()
        {
            con.ConnectionString = @"Data Source=DESKTOP-FJ84MNG\SQLEXPRESS;Initial Catalog=boletim;User ID=sa;Password=sa132";
            
        }

        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}