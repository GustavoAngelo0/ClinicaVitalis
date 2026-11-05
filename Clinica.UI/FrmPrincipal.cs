using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Clinica.UI
{
    public partial class FrmPrincipal : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        // Credenciais do Supabase
        private readonly string supabaseUrl = "https://nnddtoqeeqdkqvtfcgtk.supabase.co";
        private readonly string supabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im5uZGR0b3FlZXFka3F2dGZjZ3RrIiwicm9sZSI6ImFub24iLCJpYXQiOjE3OTI2MjkxMTIsImV4cCI6MjEwODIwNTExMn0.wYCpbaquOSCebb3RGa7hBE88ZXgC_3PaC8yqxwsU6V0";

        public FrmPrincipal()
        {
            InitializeComponent();

            // Configuração obrigatória do tema MaterialSkin.2
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900, Primary.Blue500,
                Accent.LightBlue200, TextShade.WHITE
            );
        }

        private async void FrmPrincipal_Load(object sender, EventArgs e)
        {
            await CarregarDadosDashboardAsync();
            await CarregarPacientesAsync();
        }

        // ==========================================
        // MÓDULO DE UTILIZADORES
        // ==========================================

        private async Task CarregarDadosDashboardAsync()
        {
            try
            {
                dataGridView1.Rows.Clear();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);

                    HttpResponseMessage response = await client.GetAsync("/rest/v1/Usuarios?select=*");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        JArray usuarios = JArray.Parse(jsonResult);

                        foreach (var usuario in usuarios)
                        {
                            dataGridView1.Rows.Add(
                                usuario["Id"]?.ToString(),
                                usuario["Nome"]?.ToString(),
                                usuario["Email"]?.ToString(),
                                usuario["Perfil"]?.ToString()
                            );
                        }
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao comunicar com o Supabase: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de conexão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SalvarNovoUsuarioAsync(string nome, string email, string senhaHash, string perfil)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                    client.DefaultRequestHeaders.Add("Prefer", "return=representation");

                    var novoUsuario = new
                    {
                        Nome = nome,
                        Email = email,
                        SenhaHash = senhaHash,
                        Perfil = perfil
                    };

                    string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(novoUsuario);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("/rest/v1/Usuarios", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Utilizador cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarDadosDashboardAsync();
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao cadastrar no Supabase: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar utilizador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AtualizarUsuarioAsync(string id, string nome, string email, string perfil)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                    client.DefaultRequestHeaders.Add("Prefer", "return=representation");

                    var dadosAtualizados = new
                    {
                        Nome = nome,
                        Email = email,
                        Perfil = perfil
                    };

                    string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(dadosAtualizados);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"/rest/v1/Usuarios?Id=eq.{id}")
                    {
                        Content = content
                    };

                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Utilizador atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarDadosDashboardAsync();
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao atualizar no Supabase: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar utilizador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeletarUsuarioAsync(string id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);

                    HttpResponseMessage response = await client.DeleteAsync($"/rest/v1/Usuarios?Id=eq.{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Utilizador eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarDadosDashboardAsync();
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao eliminar no Supabase: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar utilizador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do novo utilizador:", "Novo Utilizador", "");
            if (string.IsNullOrWhiteSpace(nome)) return;

            string email = Microsoft.VisualBasic.Interaction.InputBox("Digite o e-mail:", "Novo Utilizador", "");
            if (string.IsNullOrWhiteSpace(email)) return;

            string senha = Microsoft.VisualBasic.Interaction.InputBox("Digite a palavra-passe:", "Novo Utilizador", "");
            if (string.IsNullOrWhiteSpace(senha)) return;

            string perfil = Microsoft.VisualBasic.Interaction.InputBox("Digite o perfil (Ex: Admin, Medico, Recepcao):", "Novo Utilizador", "Recepcao");
            if (string.IsNullOrWhiteSpace(perfil)) return;

            await SalvarNovoUsuarioAsync(nome, email, senha, perfil);
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridView1.SelectedRows[0];

                string id = linha.Cells[0].Value?.ToString();
                string nomeAtual = linha.Cells[1].Value?.ToString();
                string emailAtual = linha.Cells[2].Value?.ToString();
                string perfilAtual = linha.Cells[3].Value?.ToString();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Selecione um utilizador válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string novoNome = Microsoft.VisualBasic.Interaction.InputBox("Editar Nome:", "Atualizar Utilizador", nomeAtual);
                if (string.IsNullOrWhiteSpace(novoNome)) return;

                string novoEmail = Microsoft.VisualBasic.Interaction.InputBox("Editar E-mail:", "Atualizar Utilizador", emailAtual);
                if (string.IsNullOrWhiteSpace(novoEmail)) return;

                string novoPerfil = Microsoft.VisualBasic.Interaction.InputBox("Editar Perfil:", "Atualizar Utilizador", perfilAtual);
                if (string.IsNullOrWhiteSpace(novoPerfil)) return;

                await AtualizarUsuarioAsync(id, novoNome, novoEmail, novoPerfil);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridView1.SelectedRows[0];
                string id = linha.Cells[0].Value?.ToString();
                string nome = linha.Cells[1].Value?.ToString();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Selecione um utilizador válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacao = MessageBox.Show(
                    $"Tem a certeza de que deseja eliminar o utilizador '{nome}'?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao == DialogResult.Yes)
                {
                    await DeletarUsuarioAsync(id);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // MÓDULO DE PACIENTES
        // ==========================================

        private async Task CarregarPacientesAsync()
        {
            try
            {
                dataGridView2.Rows.Clear();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);

                    HttpResponseMessage response = await client.GetAsync("/rest/v1/Pacientes?select=*");

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResult = await response.Content.ReadAsStringAsync();
                        JArray pacientes = JArray.Parse(jsonResult);

                        foreach (var paciente in pacientes)
                        {
                            dataGridView2.Rows.Add(
                                paciente["Id"]?.ToString(),
                                paciente["Nome"]?.ToString(),
                                paciente["Cpf"]?.ToString(),
                                paciente["Telefone"]?.ToString(),
                                paciente["DataNascimento"]?.ToString()
                            );
                        }
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao carregar pacientes: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de conexão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SalvarNovoPacienteAsync(string nome, string cpf, string telefone, string data)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                    client.DefaultRequestHeaders.Add("Prefer", "return=representation");

                    var novoPaciente = new
                    {
                        Nome = nome,
                        Cpf = cpf,
                        Telefone = telefone,
                        DataNascimento = data
                    };

                    string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(novoPaciente);
                    var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("/rest/v1/Pacientes", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Paciente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarPacientesAsync();
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao cadastrar paciente: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AtualizarPacienteAsync(string id, string nome, string cpf, string telefone, string data)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);
                    client.DefaultRequestHeaders.Add("Prefer", "return=representation");

                    var dadosAtualizados = new
                    {
                        Nome = nome,
                        Cpf = cpf,
                        Telefone = telefone,
                        DataNascimento = data
                    };

                    string jsonBody = Newtonsoft.Json.JsonConvert.SerializeObject(dadosAtualizados);
                    var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"/rest/v1/Pacientes?Id=eq.{id}")
                    {
                        Content = content
                    };

                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Paciente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarPacientesAsync();
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao atualizar paciente: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeletarPacienteAsync(string id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(supabaseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Add("apikey", supabaseKey);
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", supabaseKey);

                    HttpResponseMessage response = await client.DeleteAsync($"/rest/v1/Pacientes?Id=eq.{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Paciente eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CarregarPacientesAsync();
                    }
                    else
                    {
                        string erroDetalhe = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Erro ao eliminar paciente: {erroDetalhe}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar paciente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnNovo2_Click(object sender, EventArgs e)
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome do paciente:", "Novo Paciente", "");
            if (string.IsNullOrWhiteSpace(nome)) return;

            string cpf = Microsoft.VisualBasic.Interaction.InputBox("Digite o CPF:", "Novo Paciente", "");
            if (string.IsNullOrWhiteSpace(cpf)) return;

            string telefone = Microsoft.VisualBasic.Interaction.InputBox("Digite o telefone:", "Novo Paciente", "");
            if (string.IsNullOrWhiteSpace(telefone)) return;

            string data = Microsoft.VisualBasic.Interaction.InputBox("Digite a data de nascimento (AAAA-MM-DD):", "Novo Paciente", "");
            if (string.IsNullOrWhiteSpace(data)) return;

            await SalvarNovoPacienteAsync(nome, cpf, telefone, data);
        }

        private async void btnEditar3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridView2.SelectedRows[0];

                string id = linha.Cells[0].Value?.ToString();
                string nomeAtual = linha.Cells[1].Value?.ToString();
                string cpfAtual = linha.Cells[2].Value?.ToString();
                string telAtual = linha.Cells[3].Value?.ToString();
                string dataAtual = linha.Cells[4].Value?.ToString();

                if (string.IsNullOrEmpty(id)) return;

                string novoNome = Microsoft.VisualBasic.Interaction.InputBox("Editar Nome:", "Atualizar Paciente", nomeAtual);
                if (string.IsNullOrWhiteSpace(novoNome)) return;

                string novoCpf = Microsoft.VisualBasic.Interaction.InputBox("Editar CPF:", "Atualizar Paciente", cpfAtual);
                if (string.IsNullOrWhiteSpace(novoCpf)) return;

                string novoTel = Microsoft.VisualBasic.Interaction.InputBox("Editar Telefone:", "Atualizar Paciente", telAtual);
                if (string.IsNullOrWhiteSpace(novoTel)) return;

                string novaData = Microsoft.VisualBasic.Interaction.InputBox("Editar Data (AAAA-MM-DD):", "Atualizar Paciente", dataAtual);
                if (string.IsNullOrWhiteSpace(novaData)) return;

                await AtualizarPacienteAsync(id, novoNome, novoCpf, novoTel, novaData);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnDeletar2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = dataGridView2.SelectedRows[0];
                string id = linha.Cells[0].Value?.ToString();
                string nome = linha.Cells[1].Value?.ToString();

                if (string.IsNullOrEmpty(id)) return;

                DialogResult confirmacao = MessageBox.Show(
                    $"Tem a certeza de que deseja eliminar o paciente '{nome}'?",
                    "Confirmar Exclusão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao == DialogResult.Yes)
                {
                    await DeletarPacienteAsync(id);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha na tabela para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e) { }
        private void materialTabSelector1_Click(object sender, EventArgs e) { }
    }
}