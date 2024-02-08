﻿namespace SistemaControloAlerta.Forms
{
    partial class DepaView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepaView));
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnAlterarSenhaAdm = new FontAwesome.Sharp.IconButton();
            this.BtnAlterarSenha = new FontAwesome.Sharp.IconButton();
            this.BtnAdicionar = new FontAwesome.Sharp.IconButton();
            this.BtnListar = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnHome = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelTitlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnFechar = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new Guna.UI.WinForms.GunaLabel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.tcOpcoes = new System.Windows.Forms.TabControl();
            this.tbHome = new System.Windows.Forms.TabPage();
            this.LblDesktop = new Guna.UI.WinForms.GunaLabel();
            this.tpListar = new System.Windows.Forms.TabPage();
            this.DgvDEPA = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnPesquisar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdicionarEditar = new System.Windows.Forms.TabPage();
            this.cmbObs = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RtbAssunto = new System.Windows.Forms.RichTextBox();
            this.RtbCounteudoDespacho = new System.Windows.Forms.RichTextBox();
            this.TxtNInterno = new System.Windows.Forms.TextBox();
            this.TxtAreAfetada = new System.Windows.Forms.TextBox();
            this.DtpDataPrazo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpDataOrientacao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNotificacoes = new System.Windows.Forms.TabPage();
            this.tbAlterarSenha = new System.Windows.Forms.TabPage();
            this.tbAlterarSenhaAdm = new System.Windows.Forms.TabPage();
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnCancelar = new ePOSOne.btnProduct.Button_WOC();
            this.btnSalvar = new ePOSOne.btnProduct.Button_WOC();
            this.PanelMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.PanelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.tcOpcoes.SuspendLayout();
            this.tbHome.SuspendLayout();
            this.tpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDEPA)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbAdicionarEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.PanelMenu.Controls.Add(this.btnSair);
            this.PanelMenu.Controls.Add(this.btnAlterarSenhaAdm);
            this.PanelMenu.Controls.Add(this.BtnAlterarSenha);
            this.PanelMenu.Controls.Add(this.BtnAdicionar);
            this.PanelMenu.Controls.Add(this.BtnListar);
            this.PanelMenu.Controls.Add(this.guna2Panel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(3, 3);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.ShadowDecoration.Parent = this.PanelMenu;
            this.PanelMenu.Size = new System.Drawing.Size(220, 954);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnSair.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 32;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 380);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 60);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterarSenhaAdm
            // 
            this.btnAlterarSenhaAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnAlterarSenhaAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlterarSenhaAdm.FlatAppearance.BorderSize = 0;
            this.btnAlterarSenhaAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenhaAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenhaAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.btnAlterarSenhaAdm.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnAlterarSenhaAdm.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAlterarSenhaAdm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlterarSenhaAdm.IconSize = 32;
            this.btnAlterarSenhaAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenhaAdm.Location = new System.Drawing.Point(0, 320);
            this.btnAlterarSenhaAdm.Name = "btnAlterarSenhaAdm";
            this.btnAlterarSenhaAdm.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAlterarSenhaAdm.Size = new System.Drawing.Size(220, 60);
            this.btnAlterarSenhaAdm.TabIndex = 6;
            this.btnAlterarSenhaAdm.Text = "Alterar senha adm";
            this.btnAlterarSenhaAdm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenhaAdm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarSenhaAdm.UseVisualStyleBackColor = false;
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
            this.BtnAlterarSenha.Location = new System.Drawing.Point(0, 260);
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
            this.PanelTitlebar.Controls.Add(this.BtnFechar);
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
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnFechar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.BtnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFechar.IconSize = 16;
            this.BtnFechar.Location = new System.Drawing.Point(971, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(32, 16);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
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
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.panelDesktop.Controls.Add(this.tcOpcoes);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(223, 78);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.ShadowDecoration.Parent = this.panelDesktop;
            this.panelDesktop.Size = new System.Drawing.Size(1015, 879);
            this.panelDesktop.TabIndex = 2;
            // 
            // tcOpcoes
            // 
            this.tcOpcoes.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcOpcoes.Controls.Add(this.tbHome);
            this.tcOpcoes.Controls.Add(this.tpListar);
            this.tcOpcoes.Controls.Add(this.tbAdicionarEditar);
            this.tcOpcoes.Controls.Add(this.tbNotificacoes);
            this.tcOpcoes.Controls.Add(this.tbAlterarSenha);
            this.tcOpcoes.Controls.Add(this.tbAlterarSenhaAdm);
            this.tcOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcOpcoes.ItemSize = new System.Drawing.Size(0, 1);
            this.tcOpcoes.Location = new System.Drawing.Point(0, 0);
            this.tcOpcoes.Name = "tcOpcoes";
            this.tcOpcoes.SelectedIndex = 0;
            this.tcOpcoes.Size = new System.Drawing.Size(1015, 879);
            this.tcOpcoes.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOpcoes.TabIndex = 3;
            // 
            // tbHome
            // 
            this.tbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.tbHome.Controls.Add(this.LblDesktop);
            this.tbHome.Location = new System.Drawing.Point(4, 5);
            this.tbHome.Name = "tbHome";
            this.tbHome.Size = new System.Drawing.Size(1007, 870);
            this.tbHome.TabIndex = 6;
            this.tbHome.Text = "Home";
            // 
            // LblDesktop
            // 
            this.LblDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDesktop.AutoSize = true;
            this.LblDesktop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.LblDesktop.Location = new System.Drawing.Point(194, 395);
            this.LblDesktop.Name = "LblDesktop";
            this.LblDesktop.Size = new System.Drawing.Size(619, 31);
            this.LblDesktop.TabIndex = 3;
            this.LblDesktop.Text = "DEPARTAMENTO DE ESTUDO PLANEAMENTO E ANÁLISE";
            this.LblDesktop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpListar
            // 
            this.tpListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.tpListar.Controls.Add(this.DgvDEPA);
            this.tpListar.Controls.Add(this.panel2);
            this.tpListar.Location = new System.Drawing.Point(4, 5);
            this.tpListar.Name = "tpListar";
            this.tpListar.Padding = new System.Windows.Forms.Padding(3);
            this.tpListar.Size = new System.Drawing.Size(1007, 870);
            this.tpListar.TabIndex = 0;
            this.tpListar.Text = "Listar";
            // 
            // DgvDEPA
            // 
            this.DgvDEPA.AllowUserToAddRows = false;
            this.DgvDEPA.AllowUserToDeleteRows = false;
            this.DgvDEPA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDEPA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDEPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDEPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDEPA.Location = new System.Drawing.Point(3, 105);
            this.DgvDEPA.Name = "DgvDEPA";
            this.DgvDEPA.ReadOnly = true;
            this.DgvDEPA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvDEPA.RowTemplate.Height = 24;
            this.DgvDEPA.Size = new System.Drawing.Size(1001, 762);
            this.DgvDEPA.TabIndex = 6;
            this.DgvDEPA.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvDEPA_DataBindingComplete);
            this.DgvDEPA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvDEPA_MouseClick);
            this.DgvDEPA.Resize += new System.EventHandler(this.DgvDEPA_Resize);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnPesquisar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 102);
            this.panel2.TabIndex = 7;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BtnPesquisar.IconColor = System.Drawing.Color.Black;
            this.BtnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPesquisar.IconSize = 32;
            this.BtnPesquisar.Location = new System.Drawing.Point(715, 23);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(69, 60);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 102);
            this.panel1.TabIndex = 4;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Location = new System.Drawing.Point(63, 42);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(633, 22);
            this.TxtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // tbAdicionarEditar
            // 
            this.tbAdicionarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.tbAdicionarEditar.Controls.Add(this.cmbObs);
            this.tbAdicionarEditar.Controls.Add(this.txtNumero);
            this.tbAdicionarEditar.Controls.Add(this.label6);
            this.tbAdicionarEditar.Controls.Add(this.RtbAssunto);
            this.tbAdicionarEditar.Controls.Add(this.RtbCounteudoDespacho);
            this.tbAdicionarEditar.Controls.Add(this.TxtNInterno);
            this.tbAdicionarEditar.Controls.Add(this.TxtAreAfetada);
            this.tbAdicionarEditar.Controls.Add(this.DtpDataPrazo);
            this.tbAdicionarEditar.Controls.Add(this.label8);
            this.tbAdicionarEditar.Controls.Add(this.DtpDataOrientacao);
            this.tbAdicionarEditar.Controls.Add(this.label7);
            this.tbAdicionarEditar.Controls.Add(this.txtObs);
            this.tbAdicionarEditar.Controls.Add(this.label5);
            this.tbAdicionarEditar.Controls.Add(this.label4);
            this.tbAdicionarEditar.Controls.Add(this.label3);
            this.tbAdicionarEditar.Controls.Add(this.label2);
            this.tbAdicionarEditar.Controls.Add(this.btnCancelar);
            this.tbAdicionarEditar.Controls.Add(this.btnSalvar);
            this.tbAdicionarEditar.Location = new System.Drawing.Point(4, 5);
            this.tbAdicionarEditar.Name = "tbAdicionarEditar";
            this.tbAdicionarEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdicionarEditar.Size = new System.Drawing.Size(1007, 870);
            this.tbAdicionarEditar.TabIndex = 1;
            this.tbAdicionarEditar.Text = "Adicionar";
            // 
            // cmbObs
            // 
            this.cmbObs.FormattingEnabled = true;
            this.cmbObs.Items.AddRange(new object[] {
            "NÃO CUMPRIDA",
            "CUMPRIDA"});
            this.cmbObs.Location = new System.Drawing.Point(82, 727);
            this.cmbObs.Name = "cmbObs";
            this.cmbObs.Size = new System.Drawing.Size(568, 24);
            this.cmbObs.TabIndex = 41;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(80, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(568, 22);
            this.txtNumero.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label6.Location = new System.Drawing.Point(77, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "NÚMERO";
            // 
            // RtbAssunto
            // 
            this.RtbAssunto.Location = new System.Drawing.Point(80, 135);
            this.RtbAssunto.Name = "RtbAssunto";
            this.RtbAssunto.Size = new System.Drawing.Size(570, 56);
            this.RtbAssunto.TabIndex = 36;
            this.RtbAssunto.Text = "";
            // 
            // RtbCounteudoDespacho
            // 
            this.RtbCounteudoDespacho.Location = new System.Drawing.Point(81, 241);
            this.RtbCounteudoDespacho.Name = "RtbCounteudoDespacho";
            this.RtbCounteudoDespacho.Size = new System.Drawing.Size(569, 298);
            this.RtbCounteudoDespacho.TabIndex = 34;
            this.RtbCounteudoDespacho.Text = "";
            // 
            // TxtNInterno
            // 
            this.TxtNInterno.Location = new System.Drawing.Point(80, 660);
            this.TxtNInterno.Name = "TxtNInterno";
            this.TxtNInterno.Size = new System.Drawing.Size(570, 22);
            this.TxtNInterno.TabIndex = 24;
            // 
            // TxtAreAfetada
            // 
            this.TxtAreAfetada.Location = new System.Drawing.Point(82, 590);
            this.TxtAreAfetada.Name = "TxtAreAfetada";
            this.TxtAreAfetada.Size = new System.Drawing.Size(568, 22);
            this.TxtAreAfetada.TabIndex = 23;
            // 
            // DtpDataPrazo
            // 
            this.DtpDataPrazo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataPrazo.Location = new System.Drawing.Point(742, 216);
            this.DtpDataPrazo.Name = "DtpDataPrazo";
            this.DtpDataPrazo.Size = new System.Drawing.Size(141, 22);
            this.DtpDataPrazo.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label8.Location = new System.Drawing.Point(789, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "DATA";
            // 
            // DtpDataOrientacao
            // 
            this.DtpDataOrientacao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDataOrientacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataOrientacao.Location = new System.Drawing.Point(742, 135);
            this.DtpDataOrientacao.Name = "DtpDataOrientacao";
            this.DtpDataOrientacao.Size = new System.Drawing.Size(141, 22);
            this.DtpDataOrientacao.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label7.Location = new System.Drawing.Point(782, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "PRAZO";
            // 
            // txtObs
            // 
            this.txtObs.AutoSize = true;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.txtObs.Location = new System.Drawing.Point(77, 696);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(43, 18);
            this.txtObs.TabIndex = 29;
            this.txtObs.Text = "OBS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label5.Location = new System.Drawing.Point(79, 630);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "OF.INTERNO Nº";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label4.Location = new System.Drawing.Point(79, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "ÁREA AFECTADA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(79, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "CONTEÙDO DO DESPACHO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.label2.Location = new System.Drawing.Point(79, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "ASSUNTO";
            // 
            // tbNotificacoes
            // 
            this.tbNotificacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.tbNotificacoes.Location = new System.Drawing.Point(4, 5);
            this.tbNotificacoes.Name = "tbNotificacoes";
            this.tbNotificacoes.Size = new System.Drawing.Size(1007, 870);
            this.tbNotificacoes.TabIndex = 3;
            this.tbNotificacoes.Text = "Notificações";
            // 
            // tbAlterarSenha
            // 
            this.tbAlterarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.tbAlterarSenha.Location = new System.Drawing.Point(4, 5);
            this.tbAlterarSenha.Name = "tbAlterarSenha";
            this.tbAlterarSenha.Size = new System.Drawing.Size(1007, 870);
            this.tbAlterarSenha.TabIndex = 4;
            this.tbAlterarSenha.Text = "Alterar Senha";
            // 
            // tbAlterarSenhaAdm
            // 
            this.tbAlterarSenhaAdm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.tbAlterarSenhaAdm.Location = new System.Drawing.Point(4, 5);
            this.tbAlterarSenhaAdm.Name = "tbAlterarSenhaAdm";
            this.tbAlterarSenhaAdm.Size = new System.Drawing.Size(1007, 870);
            this.tbAlterarSenhaAdm.TabIndex = 5;
            this.tbAlterarSenhaAdm.Text = "Alterar Senha Administrador";
            // 
            // ntfIcon
            // 
            this.ntfIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfIcon.BalloonTipText = "Funcionando em segundo plano";
            this.ntfIcon.BalloonTipTitle = "DEPA";
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "DEPA";
            this.ntfIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfIcon_MouseDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderColor = System.Drawing.Color.Yellow;
            this.btnCancelar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(716, 382);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnCancelar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCancelar.Size = new System.Drawing.Size(187, 71);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BorderColor = System.Drawing.Color.Yellow;
            this.btnSalvar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(716, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnSalvar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnSalvar.Size = new System.Drawing.Size(187, 71);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextColor = System.Drawing.Color.White;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // DepaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1241, 960);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.PanelTitlebar);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepaView";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEPA";
            this.Load += new System.EventHandler(this.DepaView_Load);
            this.PanelMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.PanelTitlebar.ResumeLayout(false);
            this.PanelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.tcOpcoes.ResumeLayout(false);
            this.tbHome.ResumeLayout(false);
            this.tbHome.PerformLayout();
            this.tpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDEPA)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbAdicionarEditar.ResumeLayout(false);
            this.tbAdicionarEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton BtnListar;
        private FontAwesome.Sharp.IconButton BtnAdicionar;
        private Guna.UI2.WinForms.Guna2PictureBox BtnHome;
        private Guna.UI2.WinForms.Guna2Panel PanelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Guna.UI.WinForms.GunaLabel lblTitleChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private FontAwesome.Sharp.IconButton BtnAlterarSenha;
        private FontAwesome.Sharp.IconButton BtnFechar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton btnAlterarSenhaAdm;
        private System.Windows.Forms.TabControl tcOpcoes;
        private System.Windows.Forms.TabPage tbHome;
        private Guna.UI.WinForms.GunaLabel LblDesktop;
        private System.Windows.Forms.TabPage tpListar;
        private System.Windows.Forms.DataGridView DgvDEPA;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton BtnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbAdicionarEditar;
        private ePOSOne.btnProduct.Button_WOC btnCancelar;
        private System.Windows.Forms.RichTextBox RtbAssunto;
        private System.Windows.Forms.RichTextBox RtbCounteudoDespacho;
        private System.Windows.Forms.TextBox TxtNInterno;
        private System.Windows.Forms.TextBox TxtAreAfetada;
        private System.Windows.Forms.DateTimePicker DtpDataPrazo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpDataOrientacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtObs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC btnSalvar;
        private System.Windows.Forms.TabPage tbNotificacoes;
        private System.Windows.Forms.TabPage tbAlterarSenha;
        private System.Windows.Forms.TabPage tbAlterarSenhaAdm;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbObs;
        private System.Windows.Forms.NotifyIcon ntfIcon;
        private FontAwesome.Sharp.IconButton btnSair;
    }
}