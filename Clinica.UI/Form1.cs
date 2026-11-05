using Clinica.DAL;
using Clinica.DTO;
using Clinica.UI;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();

            // Configuração visual do MaterialSkin.2
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Paleta de cores para área da saúde (Azul / LightBlue)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código de inicialização ao carregar a tela (se necessário)
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Captura o texto das caixas de e-mail e senha
            string email = materialTextBox1.Text.Trim();
            string senha = materialTextBox2.Text.Trim();

            // Validação de campos vazios
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Chama a DAL para consultar no Supabase
                UsuarioDAL usuarioDal = new UsuarioDAL();
                UsuarioDTO usuario = usuarioDal.ValidarLogin(email, senha);

                if (usuario != null)
                {
                    MessageBox.Show($"Bem-vindo ao Vitalis, {usuario.Nome}!\nPerfil: {usuario.Perfil}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abre a janela principal APENAS se o login for válido
                    FrmPrincipal principal = new FrmPrincipal();
                    this.Hide();            // Oculta a janela de login atual
                    principal.ShowDialog(); // Abre a janela principal do Vitalis
                    this.Close();
                }
                else
                {
                    MessageBox.Show("E-mail ou senha incorretos.", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lklConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog(); // Abre a janela de cadastro em modo modal
        }

        private void lklSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueceuSenha frmEsqueceu = new FrmEsqueceuSenha();
            frmEsqueceu.ShowDialog();
        }
    }
}