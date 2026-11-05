using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Clinica.DTO;
using BCrypt.Net; // Importante para usar o BCrypt

namespace Clinica.DAL
{
    public class UsuarioDAL
    {
        // Método para validar o login com BCrypt
        public UsuarioDTO ValidarLogin(string email, string senhaDigitada)
        {
            UsuarioDTO usuario = null;
            string senhaHashDoBanco = string.Empty;

            using (var conexao = ConexaoBD.ObterConexao())
            {
                // Buscamos os dados e o SenhaHash correspondente ao e-mail
                string query = "SELECT \"Id\", \"Nome\", \"Email\", \"SenhaHash\", \"Perfil\" FROM \"Usuarios\" WHERE \"Email\" = @email";

                using (var cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new UsuarioDTO
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                Perfil = reader.GetString(4) // Índice 4 corresponde ao Perfil
                            };
                            senhaHashDoBanco = reader.GetString(3); // Índice 3 corresponde ao SenhaHash
                        }
                    }
                }
            }

            // Se encontrou o utilizador, validamos a senha digitada contra o hash do banco
            if (usuario != null && !string.IsNullOrEmpty(senhaHashDoBanco))
            {
                bool senhaValida = BCrypt.Net.BCrypt.Verify(senhaDigitada, senhaHashDoBanco);

                if (senhaValida)
                {
                    return usuario; // Login bem-sucedido!
                }
            }

            return null; // Credenciais inválidas
        }

        // Método para cadastrar um novo utilizador encriptando a senha
        public bool CadastrarUsuario(UsuarioDTO usuario, string senhaPura)
        {
            // Gera o Hash seguro da senha antes de salvar no Supabase
            string senhaHash = BCrypt.Net.BCrypt.HashPassword(senhaPura);

            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "INSERT INTO \"Usuarios\" (\"Nome\", \"Email\", \"SenhaHash\", \"Perfil\") VALUES (@nome, @email, @senhaHash, @perfil)";

                using (var cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                    cmd.Parameters.AddWithValue("@email", usuario.Email);
                    cmd.Parameters.AddWithValue("@senhaHash", senhaHash); // Salvamos o Hash e não a senha pura!
                    cmd.Parameters.AddWithValue("@perfil", usuario.Perfil ?? "Atendente");

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
        }

        // Método para atualizar a senha de um utilizador (Esqueci a senha)
        public bool AtualizarSenha(string email, string novaSenhaPura)
        {
            // Gera o novo hash seguro com BCrypt para a nova senha
            string novoSenhaHash = BCrypt.Net.BCrypt.HashPassword(novaSenhaPura);

            using (var conexao = ConexaoBD.ObterConexao())
            {
                string query = "UPDATE \"Usuarios\" SET \"SenhaHash\" = @senhaHash WHERE \"Email\" = @email";

                using (var cmd = new NpgsqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@senhaHash", novoSenhaHash);
                    cmd.Parameters.AddWithValue("@email", email);

                    int linhasAfetadas = cmd.ExecuteNonQuery();
                    // Retorna verdadeiro se encontrou o e-mail e atualizou com sucesso
                    return linhasAfetadas > 0;
                }
            }
        }
    }
}