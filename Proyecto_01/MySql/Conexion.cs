using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient ;
namespace Proyecto_01.MySql
{
    class Conexion
    {
        private MySqlConnection Conectarse = new MySqlConnection("Server=127.0.0.1;DataBase=frerama;Uid=root;pwd=toor");

        public MySqlConnection AbrirConexion()
        {
            if (Conectarse.State == ConnectionState.Open)
                Conectarse.Open();
            return Conectarse;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conectarse.State == ConnectionState.Open)
                Conectarse.Close();
            return Conectarse;
        }
    }
}
