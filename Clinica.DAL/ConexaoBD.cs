using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Clinica.DAL
{
    public class ConexaoBD
    {
        private static readonly string stringConexao = "Host=aws-0-us-east-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.nnddtoqeeqdkqvtfcgtk;Password=Mat8106912039;SslMode=Require;Trust Server Certificate=true";

        public static NpgsqlConnection ObterConexao()
        {
            try
            {
                var conexao = new NpgsqlConnection(stringConexao);  
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar com o banco de dados no Supabase: " + ex.Message);
            }
        }
    }
}