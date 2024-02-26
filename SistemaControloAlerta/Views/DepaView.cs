using FontAwesome.Sharp;
using SistemaControloAlerta._Repositories;
using SistemaControloAlerta.Presenters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaControloAlerta.Views
{
    public partial class DepaView : Form, IDepaView
    {

        // Atributes
        private IconButton currentBtn;
        private System.Windows.Forms.Panel leftBorderBtn;

        // Atributes
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private DepaPresenter depaPresenter;

        // Properties
        public string DepaId { get => txtNumero.Text; set => txtNumero.Text = value; }
        public string Assunto { get => RtbAssunto.Text; set => RtbAssunto.Text = value; }
        public string Conteudo_despacho { get => RtbCounteudoDespacho.Text; set => RtbCounteudoDespacho.Text = value; }
        public string Area_afectada { get => TxtAreAfetada.Text; set => TxtAreAfetada.Text = value; }
        public string Numero_de_oficio { get => TxtNInterno.Text; set => TxtNInterno.Text = value; }
        public DateTime Data_orientacao { get => DtpDataOrientacao.Value; set => DtpDataOrientacao.Value = value; }
        public DateTime Prazo { get => DtpDataPrazo.Value; set => DtpDataPrazo.Value = value; }
        public string Obs { get => cmbObs.SelectedItem.ToString(); set => cmbObs.SelectedIndex = cmbObs.FindStringExact(value); }
        public string SearchValue { get => TxtSearch.Text; set => TxtSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        public string SenhaAtual { get => txtSenhaActual.Text; set => txtSenhaActual.Text = value; }

        public string SenhaNova { get => txtNovaSenha.Text; set => txtNovaSenha.Text = value; }

        // Events
        public event EventHandler DepaSearchEvent;
        public event EventHandler DepaAddNewEvent;
        public event EventHandler DepaEditEvent;
        public event EventHandler DepaDeleteEvent;
        public event EventHandler DepaSaveEvent;
        public event EventHandler DepaCancelEvent;

        public event EventHandler UsuarioSaveEvent;
        public event EventHandler UsuarioCancelEvent;

        public event EventHandler OnCmbNotificationSelectionChangeCommittedEvent;

        //Others
        private const int milisecondsInHour = 3600000;
        private const int secondsInMinute = 60000;
        private const int hour = 1;
        private bool isHide = false;

        private NamedPipeServerStream _pipeServer;

        public DepaView()
        {
            InitializeComponent();

            depaPresenter = new DepaPresenter(this);

            AssociateAndRaiseViewEvents();

            // Left Panel
            leftBorderBtn = new System.Windows.Forms.Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = this.MaximizeBox = this.MinimizeBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void NamedPipeServerCreateServer()
        {
            var ps = new PipeSecurity();
            var sid = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            var everyone = sid.Translate(typeof(NTAccount));
            ps.SetAccessRule(new PipeAccessRule(everyone, PipeAccessRights.ReadWrite, AccessControlType.Allow));

            // Create pipe and start the async connection wait
            _pipeServer = new NamedPipeServerStream(
                "DEPAPIPE",
                PipeDirection.In,
                1,
                PipeTransmissionMode.Message,
                PipeOptions.Asynchronous,
                4028,
                4028,
                ps);

            // Begin async wait for connections
            _pipeServer.BeginWaitForConnection(OnPipeConnected, null);
            
        }

        private void OnPipeConnected(IAsyncResult ar)
        {
            try
            {
                _pipeServer.EndWaitForConnection(ar);

                using (StreamReader reader = new StreamReader(_pipeServer))
                {
                    string command = reader.ReadLine();
                    if (command == "ActivateWindow")
                    {

                        /// InvokeRequired indica se a chamada para Show() precisa ser feita na thread principal.
                        /// Se InvokeRequired for true, a chamada para Show() é feita na thread principal usando Invoke().
                        /// Se InvokeRequired for false, a chamada para Show() pode ser feita diretamente, pois já está na thread principal.

                        if (InvokeRequired)
                        {
                            Invoke((MethodInvoker)delegate { ntfIconClicked(); });
                        }
                        else
                        {
                            ntfIconClicked();
                        }

                    }
                }

                _pipeServer.Dispose();
                NamedPipeServerCreateServer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search button
            BtnPesquisar.Click += (s, e) =>
            {
                DepaSearchEvent?.Invoke(this, EventArgs.Empty);
            };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DepaSearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };


            // Save button
            btnSalvar.Click += delegate
            {
                DepaSaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    // Do something

                }
                MessageBox.Show(Message);
            };

            btnAlterar.Click += delegate
            {
                UsuarioSaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    // Do something
                }
                MessageBox.Show(Message);
            };


            // Cancel button
            btnCancelar.Click += delegate
            {
                DepaCancelEvent?.Invoke(this, EventArgs.Empty);
                openTab(0);
                Reset();

            };

            btnCancelar2.Click += delegate
            {
                UsuarioCancelEvent?.Invoke(this, EventArgs.Empty);
                openTab(0);
                Reset();

            };

            cmbNotificacoes.SelectionChangeCommitted += OnCmbNotificationSelectionChangeCommittedEvent;

        }

        // DEPA Methods
        public void SetDEPAListBindingSource(BindingSource depaList)
        {
            DgvDEPA.DataSource = depaList;
        }

        public void OnCountAlerts(Func<int> alerts, Func<int> time, SynchronizationContext sctx, System.Timers.Timer alertTimer)
        {
            sctx = SynchronizationContext.Current;

            int currentTime = time.Invoke();

            // Alerts
            alertTimer = new System.Timers.Timer(currentTime * milisecondsInHour);

            alertTimer.Elapsed += new ElapsedEventHandler((object sender, ElapsedEventArgs e) =>
            {

                if (currentTime != time.Invoke()) { 
                    currentTime = time.Invoke();
                    alertTimer.Interval = currentTime * milisecondsInHour;
                    alertTimer.Stop();
                    alertTimer.Start();
                }

                if (alerts.Invoke() > 0)
                {
                    // Schedule UI update code on the main UI thread
                    SynchronizationContext.SetSynchronizationContext(sctx);
                    sctx.Post((Object state) =>
                    {
                        // Your code that interacts with UI elements
                        Alert("Há vencimentos!", Form_Alert.enmType.Warning);
                    }, null);
                }
            }); // handler - what to do when time elaps

            alertTimer.Start();
        }

        public void OnCmbNotificationSavedItem(Func<int> time) {
            // init combobox

            Dictionary<string, int> comboSource = new Dictionary<string, int>();

            for (int i = 1; i <= 24; i++)
            {
                comboSource.Add(i + " Hora", i);
            }

            cmbNotificacoes.DataSource = new BindingSource(comboSource, null);

            cmbNotificacoes.DisplayMember = "Key";
            cmbNotificacoes.ValueMember = "Value";

            int savedValue = comboSource.FirstOrDefault(x => x.Value == time.Invoke()).Value;

            cmbNotificacoes.SelectedValue = savedValue;
        }

        public void OnClose()
        {
            // Do Something
        }

        private void DgvDEPA_Resize(object sender, EventArgs e)
        {
            DgvDEPA.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.5F, FontStyle.Bold);
            DgvDEPA.RowHeadersDefaultCellStyle.Font = new Font("Tahoma", 8.5F, FontStyle.Bold);
            DgvDEPA.RowsDefaultCellStyle.Font = new Font("Tahoma", 8.5F, FontStyle.Regular);
        }

        private void DgvDEPA_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                System.Windows.Forms.ContextMenu m = new System.Windows.Forms.ContextMenu();
                m.MenuItems.Add(new System.Windows.Forms.MenuItem("Editar"));
                m.MenuItems.Add(new System.Windows.Forms.MenuItem("Eliminar"));

                m.MenuItems[0].Click += EditarMenuItem_Click;
                m.MenuItems[1].Click += EliminarMenuItem_Click;

                int currentMouseOverRow = DgvDEPA.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    if (DgvDEPA.CurrentCell.RowIndex == currentMouseOverRow)
                    {
                        m.Show(DgvDEPA, new Point(e.X, e.Y));
                    };
                }
            }
        }

        private void EliminarMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que quer eliminar o item selecionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DepaDeleteEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void EditarMenuItem_Click(object sender, EventArgs e)
        {

            if (ValidarAutorizacao()) {
                DepaEditEvent?.Invoke(this, EventArgs.Empty);
                openTab(2);
            }
        }

        private bool ValidarAutorizacao() {

            string Resultado = FrmEntrar.InputBoxDialog();

            /* pegar a senha. */

            string password = depaPresenter.getAdminPassword();

            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */

            if (Resultado != ""){

                Resultado = Resultado.TrimStart();

                /* Verifica se a senha confere. */

                if (Resultado != password){
                    MessageBox.Show("Senha Incorreta.");
                }
                else{
                    MessageBox.Show("Senha válida.");
                    return true;
                }
            }
            return false;
        }


        // Resize borderless form
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Transparent, Top());
            e.Graphics.FillRectangle(Brushes.Transparent, Left());
            e.Graphics.FillRectangle(Brushes.Transparent, Right());
            e.Graphics.FillRectangle(Brushes.Transparent, Bottom());
        }

        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84)
            {
                var mp = this.PointToClient(Cursor.Position);

                if (TopLeft().Contains(mp))
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight().Contains(mp))
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft().Contains(mp))
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight().Contains(mp))
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (Top().Contains(mp))
                    m.Result = (IntPtr)HTTOP;
                else if (Left().Contains(mp))
                    m.Result = (IntPtr)HTLEFT;
                else if (Right().Contains(mp))
                    m.Result = (IntPtr)HTRIGHT;
                else if (Bottom().Contains(mp))
                    m.Result = (IntPtr)HTBOTTOM;
            }
        }

        private Random rng = new Random();
        public Color randomColour()
        {
            return Color.FromArgb(255, rng.Next(255), rng.Next(255), rng.Next(255));
        }

        const int ImaginaryBorderSize = 2;

        public new Rectangle Top()
        {
            return new Rectangle(0, 0, this.ClientSize.Width, ImaginaryBorderSize);
        }

        public new Rectangle Left()
        {
            return new Rectangle(0, 0, ImaginaryBorderSize, this.ClientSize.Height);
        }

        public new Rectangle Bottom()
        {
            return new Rectangle(0, this.ClientSize.Height - ImaginaryBorderSize, this.ClientSize.Width, ImaginaryBorderSize);
        }

        public new Rectangle Right()
        {
            return new Rectangle(this.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, this.ClientSize.Height);
        }

        public Rectangle TopLeft()
        {
            return new Rectangle(0, 0, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        public Rectangle TopRight()
        {
            return new Rectangle(this.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        public Rectangle BottomLeft()
        {
            return new Rectangle(0, this.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        public Rectangle BottomRight()
        {
            return new Rectangle(this.ClientSize.Width - ImaginaryBorderSize, this.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize);
        }

        //Structs
        public struct RGBColors
        {
            public static Color darkBlue = Color.FromArgb(4, 0, 128);
            public static Color yellow = Color.FromArgb(255, 255, 0);
            public static Color darkBlue2 = Color.FromArgb(0, 95, 182);
        }

        //Methods
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.darkBlue2;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.darkBlue;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void openTab(int index)
        {
            tcOpcoes.SelectedIndex = index;
            TabPage tb = (TabPage)tcOpcoes.GetControl(index);
            lblTitleChildForm.Text = tb.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.yellow;
            lblTitleChildForm.Text = "Home";
        }

        private void DepaView_Load(object sender, EventArgs e)
        {

            // Center text
            int h, w;

            h = (panelDesktop.Height - LblDesktop.Height) / 2;
            w = (panelDesktop.Width - LblDesktop.Width) / 2;

            LblDesktop.Top = h;
            LblDesktop.Left = w;

            //PIPE

            NamedPipeServerCreateServer();

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            openTab(1);
            ActivateButton(sender, RGBColors.yellow);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            openTab(2);
            ActivateButton(sender, RGBColors.yellow);
            depaPresenter.DepaCleanViewFields();
        }

        private void BtnNotificacoes_Click(object sender, EventArgs e)
        {
            openTab(4);
            ActivateButton(sender, RGBColors.yellow);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            openTab(0);
            Reset();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            // Sair icon tray

            System.Windows.Forms.ContextMenu contextMenu1 = new System.Windows.Forms.ContextMenu();
            System.Windows.Forms.MenuItem menuItem1 = new System.Windows.Forms.MenuItem();

            // Initialize contextMenu1
            contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { menuItem1 });

            // Initialize menuItem1
            menuItem1.Index = 0;
            menuItem1.Text = "Sair";
            menuItem1.Click += new System.EventHandler(this.menuItem1_Click);

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            ntfIcon.ContextMenu = contextMenu1;

            // Esconder no icon stray
            Hide();
            ntfIcon.Visible = true;
            ntfIcon.ShowBalloonTip(1500);

            isHide = true;

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            // ActivateButton(sender, RGBColors.yellow);
            this.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void ntfIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ntfIconClicked();
        }

        public void ntfIconClicked()
        {
            Show();
            this.TopMost = true;
            Activate();
            this.TopMost = false;
            WindowState = FormWindowState.Normal;
            ntfIcon.Visible = false;
            isHide = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvDEPA_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in DgvDEPA.Rows)
            {

                if (row.Cells[9].Value.ToString() == "CUMPRIDA")
                {
                    row.Cells[9].Style.BackColor = Color.LightGreen;
                }
                else if (row.Cells[9].Value.ToString() == "NÃO CUMPRIDA")
                {
                    row.Cells[9].Style.BackColor = Color.IndianRed;
                }

                if (row.Cells[8].Value.ToString() == "VENCEU")
                {
                    row.Cells[8].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells[8].Style.BackColor = Color.Orange;
                }
            }
        }

        private void DepaView_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnAlterarSenhaAdm_Click(object sender, EventArgs e)
        {
            openTab(3);
            ActivateButton(sender, RGBColors.yellow);
        }

        private void cmbNotificacoes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
