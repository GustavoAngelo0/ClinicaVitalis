namespace Clinica
{
    partial class FrmEsqueceuSenha
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
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSenhaNova = new MaterialSkin.Controls.MaterialTextBox();
            this.btnRedefinir = new MaterialSkin.Controls.MaterialButton();
            this.btnVoltar = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(164, 228);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(480, 50);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.AnimateReadOnly = false;
            this.txtSenhaNova.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaNova.Depth = 0;
            this.txtSenhaNova.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenhaNova.LeadingIcon = null;
            this.txtSenhaNova.Location = new System.Drawing.Point(164, 315);
            this.txtSenhaNova.MaxLength = 50;
            this.txtSenhaNova.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenhaNova.Multiline = false;
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.Size = new System.Drawing.Size(480, 50);
            this.txtSenhaNova.TabIndex = 1;
            this.txtSenhaNova.Text = "";
            this.txtSenhaNova.TrailingIcon = null;
            // 
            // btnRedefinir
            // 
            this.btnRedefinir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRedefinir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRedefinir.Depth = 0;
            this.btnRedefinir.HighEmphasis = true;
            this.btnRedefinir.Icon = null;
            this.btnRedefinir.Location = new System.Drawing.Point(229, 391);
            this.btnRedefinir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRedefinir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRedefinir.Name = "btnRedefinir";
            this.btnRedefinir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRedefinir.Size = new System.Drawing.Size(93, 36);
            this.btnRedefinir.TabIndex = 2;
            this.btnRedefinir.Text = "Redefinir";
            this.btnRedefinir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRedefinir.UseAccentColor = false;
            this.btnRedefinir.UseVisualStyleBackColor = true;
            this.btnRedefinir.Click += new System.EventHandler(this.btnRedefinir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVoltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVoltar.Depth = 0;
            this.btnVoltar.HighEmphasis = true;
            this.btnVoltar.Icon = null;
            this.btnVoltar.Location = new System.Drawing.Point(468, 391);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVoltar.Size = new System.Drawing.Size(77, 36);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar ";
            this.btnVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVoltar.UseAccentColor = false;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Clinica.UI.Properties.Resources.Logo_Vitalis_de_Gestão_Médica;
            this.pictureBox1.Location = new System.Drawing.Point(164, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(164, 206);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "E-mail:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(164, 293);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Senha:";
            // 
            // FrmEsqueceuSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRedefinir);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.txtEmail);
            this.Name = "FrmEsqueceuSenha";
            this.Text = "Redefinir a Senha";
            this.Load += new System.EventHandler(this.FrmEsqueceuSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtSenhaNova;
        private MaterialSkin.Controls.MaterialButton btnRedefinir;
        private MaterialSkin.Controls.MaterialButton btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}