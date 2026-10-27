using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Clinica.DAL;
using Clinica.DTO;

namespace Clinica
{
    public partial class FrmCadastro : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FrmCadastro()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900, Primary.Blue500,
                Accent.LightBlue200, TextShade.WHITE
            );
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Ajusta os nomes das caixas conforme criaste no designer
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuarioDTO novoUsuario = new UsuarioDTO
                {
                    Nome = nome,
                    Email = email,
                    Perfil = "Admin" // Ou outro perfil que definires
                };

                UsuarioDAL usuarioDal = new UsuarioDAL();
                bool sucesso = usuarioDal.CadastrarUsuario(novoUsuario, senha);

                if (sucesso)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Fecha a tela de cadastro e volta ao login
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
