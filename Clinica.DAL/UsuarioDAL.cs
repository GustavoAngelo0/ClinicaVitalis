using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Clinica.DTO;

namespace Clinica.DAL
{
    public class UsuarioDAL
    {
        // Método para validar o login no Supabase
        public UsuarioDTO ValidarLogin(string email, string senha)
        {
            UsuarioDTO usuario = null;

            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "SELECT \"Id\", \"Nome\", \"Email\", \"Perfil\" FROM \"Usuarios\" WHERE \"Email\" = @email AND \"SenhaHash\" = @senha";

                using (var cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new UsuarioDTO
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                Perfil = reader.GetString(3)
                            };
                        }
                    }
                }
            }

            return usuario;
        }

        // Método para cadastrar um novo utilizador na base de dados
        public bool CadastrarUsuario(UsuarioDTO usuario, string senha)
        {
            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "INSERT INTO \"Usuarios\" (\"Nome\", \"Email\", \"SenhaHash\", \"Perfil\") VALUES (@nome, @email, @senha, @perfil)";

                using (var cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cmd.Parameters.AddWithValue("@perfil", usuario.Perfil ?? "Atendente"); // Define um perfil padrão se vier vazio

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
        }
    }
}