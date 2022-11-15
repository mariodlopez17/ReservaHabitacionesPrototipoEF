﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloProduccion;

namespace CapaControladorProduccion
{
    public class ControladorP
    {
        Sentencias sn = new Sentencias();
        // LLenar una tabla CAPA CONTROLADOR


        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
