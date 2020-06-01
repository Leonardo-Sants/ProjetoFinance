using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Entidades
{
    class Comandos
    {
        SqlCommand cmd = new SqlCommand();
        Conect cnx = new Conect();
        public string msg;

        public Comandos ()
        {
           
        }
        public Comandos(string atv, decimal gain, DateTime dt, decimal ls)
        {
            cmd.CommandText = "Insert into Operacao (Ativo, Gain, Dat, Loss) Values (@Ativo, @Gain, @Dat, @Loss)";

            cmd.Parameters.AddWithValue ("@Ativo",atv);
            cmd.Parameters.AddWithValue ("@Gain", gain);
            cmd.Parameters.AddWithValue ("@Dat", dt);
            cmd.Parameters.AddWithValue("@Loss", ls);


            try
            {
                cmd.Connection = cnx.Conectar();
                cmd.ExecuteNonQuery();
                cnx.Desconectar();
                this.msg = ("Enviado com sucesso!!!");

            }
            catch(SqlException)
            {
                this.msg = ("Erro de conexão com o banco de dados");
            }
        }
    }
}
