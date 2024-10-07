﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private OleDbConnection CN = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|App.accdb");

        public OleDbConnection AbrirConexion()
        {
            if(CN.State == ConnectionState.Open)
            {
                CN.Close();
            }
            CN.Open();

            return CN;
        }

        public OleDbConnection CerrarConexion() 
        {
            CN.Close();
            return CN;
        }

    }
}