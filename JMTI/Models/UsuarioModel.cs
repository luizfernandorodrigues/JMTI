using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JMTI.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            var retorno = false;
            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = "Data Source=LUIZFERNANDO\\SQLEXPRESS;Initial Catalog=web;User Id=sa;Password=mygod&1000";
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format("SELECT COUNT(*) FROM USUARIO WHERE LOGIN='{0}'" +
                        " AND SENHA = '{1}'", login, senha);
                    retorno = ((int)comando.ExecuteScalar() > 0);
                }
            }

            return retorno;
        }
    }
}