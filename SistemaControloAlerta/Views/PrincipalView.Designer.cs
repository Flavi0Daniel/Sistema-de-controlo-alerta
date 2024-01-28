namespace SistemaControloAlerta.Forms
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
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnAlterarSenha = new FontAwesome.Sharp.IconButton();
            this.BtnNotificaoes = new FontAwesome.Sharp.IconButton();
            this.BtnAdicionar = new FontAwesome.Sharp.IconButton();
            this.BtnListar = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnHome = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelTitlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnSair = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new Guna.UI.WinForms.GunaLabel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.LblDesktop = new Guna.UI.WinForms.GunaLabel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.PanelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.PanelMenu.Controls.Add(this.BtnAlterarSenha);
            this.PanelMenu.Controls.Add(this.BtnNotificaoes);
            this.PanelMenu.Controls.Add(this.BtnAdicionar);
            this.PanelMenu.Controls.Add(this.BtnListar);
            this.PanelMenu.Controls.Add(this.guna2Panel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(3, 3);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.ShadowDecoration.Parent = this.PanelMenu;
            this.PanelMenu.Size = new System.Drawing.Size(220, 794);
            this.PanelMenu.TabIndex = 0;
            // 
            // BtnAlterarSenha
            // 
            this.BtnAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnAlterarSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlterarSenha.FlatAppearance.BorderSize = 0;
            this.BtnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnAlterarSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.BtnAlterarSenha.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAlterarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlterarSenha.IconSize = 32;
            this.BtnAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterarSenha.Location = new System.Drawing.Point(0, 320);
            this.BtnAlterarSenha.Name = "BtnAlterarSenha";
            this.BtnAlterarSenha.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAlterarSenha.Size = new System.Drawing.Size(220, 60);
            this.BtnAlterarSenha.TabIndex = 5;
            this.BtnAlterarSenha.Text = "Alterar senha";
            this.BtnAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlterarSenha.UseVisualStyleBackColor = false;
            this.BtnAlterarSenha.Click += new System.EventHandler(this.BtnAlterarSenha_Click);
            // 
            // BtnNotificaoes
            // 
            this.BtnNotificaoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnNotificaoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnNotificaoes.FlatAppearance.BorderSize = 0;
            this.BtnNotificaoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNotificaoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNotificaoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnNotificaoes.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.BtnNotificaoes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnNotificaoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNotificaoes.IconSize = 32;
            this.BtnNotificaoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotificaoes.Location = new System.Drawing.Point(0, 260);
            this.BtnNotificaoes.Name = "BtnNotificaoes";
            this.BtnNotificaoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnNotificaoes.Size = new System.Drawing.Size(220, 60);
            this.BtnNotificaoes.TabIndex = 3;
            this.BtnNotificaoes.Text = "Notificações";
            this.BtnNotificaoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNotificaoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNotificaoes.UseVisualStyleBackColor = false;
            this.BtnNotificaoes.Click += new System.EventHandler(this.BtnNotificacoes_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnAdicionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdicionar.FlatAppearance.BorderSize = 0;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnAdicionar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAdicionar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdicionar.IconSize = 32;
            this.BtnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.Location = new System.Drawing.Point(0, 200);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnAdicionar.Size = new System.Drawing.Size(220, 60);
            this.BtnAdicionar.TabIndex = 2;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.BtnListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnListar.FlatAppearance.BorderSize = 0;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnListar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnListar.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnListar.IconSize = 32;
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(0, 140);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnListar.Size = new System.Drawing.Size(220, 60);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.BtnHome);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(220, 140);
            this.guna2Panel1.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnHome.Image = global::SistemaControloAlerta.Properties.Resources.WhatsApp_Image_2024_01_04_at_18_18_51;
            this.BtnHome.Location = new System.Drawing.Point(54, 12);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.ShadowDecoration.Parent = this.BtnHome;
            this.BtnHome.Size = new System.Drawing.Size(113, 107);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // PanelTitlebar
            // 
            this.PanelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.PanelTitlebar.Controls.Add(this.BtnMinimizar);
            this.PanelTitlebar.Controls.Add(this.BtnMaximizar);
            this.PanelTitlebar.Controls.Add(this.BtnSair);
            this.PanelTitlebar.Controls.Add(this.lblTitleChildForm);
            this.PanelTitlebar.Controls.Add(this.iconCurrentChildForm);
            this.PanelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitlebar.Location = new System.Drawing.Point(223, 3);
            this.PanelTitlebar.Name = "PanelTitlebar";
            this.PanelTitlebar.ShadowDecoration.Parent = this.PanelTitlebar;
            this.PanelTitlebar.Size = new System.Drawing.Size(1015, 75);
            this.PanelTitlebar.TabIndex = 1;
            this.PanelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitlebar_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 16;
            this.BtnMinimizar.Location = new System.Drawing.Point(858, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(32, 16);
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximizar.IconSize = 16;
            this.BtnMaximizar.Location = new System.Drawing.Point(916, 12);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(32, 16);
            this.BtnMaximizar.TabIndex = 4;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnSair.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSair.IconSize = 16;
            this.BtnSair.Location = new System.Drawing.Point(971, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(32, 16);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(80, 24);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(58, 23);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(42, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // LblDesktop
            // 
            this.LblDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDesktop.AutoSize = true;
            this.LblDesktop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.LblDesktop.Location = new System.Drawing.Point(199, 330);
            this.LblDesktop.Name = "LblDesktop";
            this.LblDesktop.Size = new System.Drawing.Size(619, 31);
            this.LblDesktop.TabIndex = 2;
            this.LblDesktop.Text = "DEPARTAMENTO DE ESTUDO PLANEAMENTO E ANÁLISE";
            this.LblDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.panelDesktop.Controls.Add(this.LblDesktop);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(223, 78);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.ShadowDecoration.Parent = this.panelDesktop;
            this.panelDesktop.Size = new System.Drawing.Size(1015, 719);
            this.panelDesktop.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1241, 800);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.PanelTitlebar);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.PanelTitlebar.ResumeLayout(false);
            this.PanelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton BtnListar;
        private FontAwesome.Sharp.IconButton BtnNotificaoes;
        private FontAwesome.Sharp.IconButton BtnAdicionar;
        private Guna.UI2.WinForms.Guna2PictureBox BtnHome;
        private Guna.UI2.WinForms.Guna2Panel PanelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Guna.UI.WinForms.GunaLabel lblTitleChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private Guna.UI.WinForms.GunaLabel LblDesktop;
        private FontAwesome.Sharp.IconButton BtnAlterarSenha;
        private FontAwesome.Sharp.IconButton BtnSair;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
    }
}