using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Entidades
{
    class Conect
    {
        SqlConnection cnt = new SqlConnection();
        public Conect()
        {
            cnt.ConnectionString = @"Data Source=DESKTOP-N7J66TC\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True";
        }

        public SqlConnection Conectar()
        {
            if(cnt.State == System.Data.ConnectionState.Closed)
            {
                cnt.Open();
            }
            return cnt;
        }

        public void Desconectar()
        {
            if (cnt.State == System.Data.ConnectionState.Open)
            {
                cnt.Close();
            }
        }
    }
}
