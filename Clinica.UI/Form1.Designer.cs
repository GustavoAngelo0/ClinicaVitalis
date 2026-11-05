namespace Clinica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.material_button1 = new MaterialSkin.Controls.MaterialButton();
            this.lklSenha = new System.Windows.Forms.LinkLabel();
            this.lklConta = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(229, 216);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(304, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(229, 303);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(304, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // material_button1
            // 
            this.material_button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.material_button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.material_button1.Depth = 0;
            this.material_button1.HighEmphasis = true;
            this.material_button1.Icon = null;
            this.material_button1.Location = new System.Drawing.Point(333, 395);
            this.material_button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.material_button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.material_button1.Name = "material_button1";
            this.material_button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.material_button1.Size = new System.Drawing.Size(77, 36);
            this.material_button1.TabIndex = 3;
            this.material_button1.Text = "Entrar";
            this.material_button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.material_button1.UseAccentColor = false;
            this.material_button1.UseVisualStyleBackColor = true;
            this.material_button1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // lklSenha
            // 
            this.lklSenha.AutoSize = true;
            this.lklSenha.Location = new System.Drawing.Point(152, 365);
            this.lklSenha.Name = "lklSenha";
            this.lklSenha.Size = new System.Drawing.Size(126, 16);
            this.lklSenha.TabIndex = 5;
            this.lklSenha.TabStop = true;
            this.lklSenha.Text = "Esqueceu a senha?";
            this.lklSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSenha_LinkClicked);
            // 
            // lklConta
            // 
            this.lklConta.AutoSize = true;
            this.lklConta.Location = new System.Drawing.Point(443, 365);
            this.lklConta.Name = "lklConta";
            this.lklConta.Size = new System.Drawing.Size(161, 16);
            this.lklConta.TabIndex = 6;
            this.lklConta.TabStop = true;
            this.lklConta.Text = "Não tem conta? Criar uma";
            this.lklConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklConta_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "e-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lklConta);
            this.Controls.Add(this.lklSenha);
            this.Controls.Add(this.material_button1);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton material_button1;
        private System.Windows.Forms.LinkLabel lklSenha;
        private System.Windows.Forms.LinkLabel lklConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

