using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Proyectobasedatos
{
    class Connection
    {
        private MySqlConnection conn =
            new MySqlConnection("Server=localhost;Database=smis912820; Uid=root;" +
                "Pwd=usbw;SSL Mode=None");
        public MySqlCommand command;
        public MySqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //cerrar la conexion
        public MySqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
