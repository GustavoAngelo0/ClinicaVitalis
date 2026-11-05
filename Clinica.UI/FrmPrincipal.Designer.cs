namespace Clinica.UI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeletar2 = new MaterialSkin.Controls.MaterialButton();
            this.btnEditar3 = new MaterialSkin.Controls.MaterialButton();
            this.btnNovo2 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colNome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.btnDeletar = new MaterialSkin.Controls.MaterialButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 148);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(788, 296);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeletar2);
            this.tabPage2.Controls.Add(this.btnEditar3);
            this.tabPage2.Controls.Add(this.btnNovo2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeletar2
            // 
            this.btnDeletar2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletar2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletar2.Depth = 0;
            this.btnDeletar2.HighEmphasis = true;
            this.btnDeletar2.Icon = null;
            this.btnDeletar2.Location = new System.Drawing.Point(243, 23);
            this.btnDeletar2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar2.Name = "btnDeletar2";
            this.btnDeletar2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletar2.Size = new System.Drawing.Size(80, 36);
            this.btnDeletar2.TabIndex = 3;
            this.btnDeletar2.Text = "Excluir";
            this.btnDeletar2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletar2.UseAccentColor = false;
            this.btnDeletar2.UseVisualStyleBackColor = true;
            this.btnDeletar2.Click += new System.EventHandler(this.btnDeletar2_Click);
            // 
            // btnEditar3
            // 
            this.btnEditar3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar3.Depth = 0;
            this.btnEditar3.HighEmphasis = true;
            this.btnEditar3.Icon = null;
            this.btnEditar3.Location = new System.Drawing.Point(122, 23);
            this.btnEditar3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar3.Name = "btnEditar3";
            this.btnEditar3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar3.Size = new System.Drawing.Size(71, 36);
            this.btnEditar3.TabIndex = 2;
            this.btnEditar3.Text = "Editar";
            this.btnEditar3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar3.UseAccentColor = false;
            this.btnEditar3.UseVisualStyleBackColor = true;
            this.btnEditar3.Click += new System.EventHandler(this.btnEditar3_Click);
            // 
            // btnNovo2
            // 
            this.btnNovo2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNovo2.Depth = 0;
            this.btnNovo2.HighEmphasis = true;
            this.btnNovo2.Icon = null;
            this.btnNovo2.Location = new System.Drawing.Point(18, 23);
            this.btnNovo2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo2.Name = "btnNovo2";
            this.btnNovo2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNovo2.Size = new System.Drawing.Size(64, 36);
            this.btnNovo2.TabIndex = 1;
            this.btnNovo2.Text = "Novo";
            this.btnNovo2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNovo2.UseAccentColor = false;
            this.btnNovo2.UseVisualStyleBackColor = true;
            this.btnNovo2.Click += new System.EventHandler(this.btnNovo2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome2,
            this.colCpf,
            this.colTelefone,
            this.colData,
            this.colEndereco});
            this.dataGridView2.Location = new System.Drawing.Point(18, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(744, 179);
            this.dataGridView2.TabIndex = 0;
            // 
            // colNome2
            // 
            this.colNome2.HeaderText = "Nome";
            this.colNome2.MinimumWidth = 6;
            this.colNome2.Name = "colNome2";
            this.colNome2.Width = 125;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.MinimumWidth = 6;
            this.colCpf.Name = "colCpf";
            this.colCpf.Width = 125;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.MinimumWidth = 6;
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.Width = 125;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data Nasc.";
            this.colData.MinimumWidth = 6;
            this.colData.Name = "colData";
            this.colData.Width = 125;
            // 
            // colEndereco
            // 
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.MinimumWidth = 6;
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.Width = 125;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(10, 94);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(784, 48);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId1,
            this.colNome1,
            this.colEmail1,
            this.colCargo1});
            this.dataGridView1.Location = new System.Drawing.Point(17, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 189);
            this.dataGridView1.TabIndex = 3;
            // 
            // colCargo
            // 
            this.colCargo.HeaderText = "Cargo";
            this.colCargo.MinimumWidth = 6;
            this.colCargo.Name = "colCargo";
            this.colCargo.Width = 125;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 125;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.Width = 125;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.Width = 125;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovoUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNovoUsuario.Depth = 0;
            this.btnNovoUsuario.HighEmphasis = true;
            this.btnNovoUsuario.Icon = null;
            this.btnNovoUsuario.Location = new System.Drawing.Point(17, 18);
            this.btnNovoUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNovoUsuario.Size = new System.Drawing.Size(64, 36);
            this.btnNovoUsuario.TabIndex = 4;
            this.btnNovoUsuario.Text = "Novo";
            this.btnNovoUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNovoUsuario.UseAccentColor = false;
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(121, 18);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEditar.Size = new System.Drawing.Size(71, 36);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletar.Depth = 0;
            this.btnDeletar.HighEmphasis = true;
            this.btnDeletar.Icon = null;
            this.btnDeletar.Location = new System.Drawing.Point(232, 18);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletar.Size = new System.Drawing.Size(80, 36);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletar.UseAccentColor = false;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeletar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnNovoUsuario);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // colId1
            // 
            this.colId1.HeaderText = "Id";
            this.colId1.MinimumWidth = 6;
            this.colId1.Name = "colId1";
            this.colId1.Width = 125;
            // 
            // colNome1
            // 
            this.colNome1.HeaderText = "Nome";
            this.colNome1.MinimumWidth = 6;
            this.colNome1.Name = "colNome1";
            this.colNome1.Width = 125;
            // 
            // colEmail1
            // 
            this.colEmail1.HeaderText = "E-mail";
            this.colEmail1.MinimumWidth = 6;
            this.colEmail1.Name = "colEmail1";
            this.colEmail1.Width = 125;
            // 
            // colCargo1
            // 
            this.colCargo1.HeaderText = "Cargo";
            this.colCargo1.MinimumWidth = 6;
            this.colCargo1.Name = "colCargo1";
            this.colCargo1.Width = 125;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "FrmPrincipal";
            this.Text = "Vitalis";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialButton btnEditar3;
        private MaterialSkin.Controls.MaterialButton btnNovo2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialButton btnDeletar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton btnDeletar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnNovoUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargo1;
    }
}