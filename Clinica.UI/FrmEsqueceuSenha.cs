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
    public partial class FrmEsqueceuSenha : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FrmEsqueceuSenha()
        {
            InitializeComponent();

            // Configuração do MaterialSkin.2 para manter o padrão visual
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900, Primary.Blue500,
                Accent.LightBlue200, TextShade.WHITE
            );
        }

        private void FrmEsqueceuSenha_Load(object sender, EventArgs e)
        {
            // Método necessário para o designer do Visual Studio não dar erro
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            // Nota: Confirma se a tua caixa de texto de senha se chama txtSenha ou outro nome no teu designer. 
            // Se for txtSenha, mantém assim:
            string novaSenha = txtSenhaNova.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UsuarioDAL usuarioDal = new UsuarioDAL();
                bool atualizado = usuarioDal.AtualizarSenha(email, novaSenha);

                if (atualizado)
                {
                    MessageBox.Show("Senha redefinida com sucesso! Já pode fazer login com a nova senha.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Fecha a janela de recuperação e regressa ao login
                }
                else
                {
                    MessageBox.Show("E-mail não encontrado na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao redefinir a senha: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); // Apenas fecha esta janela e volta ao formulário de login
        }
    }
}