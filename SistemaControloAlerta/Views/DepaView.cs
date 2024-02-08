using FontAwesome.Sharp;
using SistemaControloAlerta._Repositories;
using SistemaControloAlerta.Presenters;
using SistemaControloAlerta.Views;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace SistemaControloAlerta.Forms
{
    public partial class DepaView : Form, IDepaView
    {

        // Atributes
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        // Atributes
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        private DepaPresenter depaPresenter;
        String conn = Properties.Settings.Default.DBConnectionString;

        // Properties
        public string Id { get => txtNumero.Text; set => txtNumero.Text = value; }
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

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Others
        private const int seconds = 1000;
        private bool isHide = false;

        public DepaView()
        {
            InitializeComponent();

            depaPresenter = new DepaPresenter(this, new DepaRepository(conn));

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

        private void AssociateAndRaiseViewEvents()
        {
            // Search button
            BtnPesquisar.Click += (s, e) =>
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };


            // Save button
            btnSalvar.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    // Do something

                }
                MessageBox.Show(Message);
            };


            // Cancel button
            btnCancelar.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                openTab(0);
                Reset();

            };

        }

        // DEPA Methods
        public void SetDEPAListBindingSource(BindingSource depaList)
        {
            DgvDEPA.DataSource = depaList;
        }

        public void OnCountAlerts(Func<int> alerts, SynchronizationContext sctx, System.Timers.Timer alertTimer)
        {
            sctx = SynchronizationContext.Current;

            // Alerts
            alertTimer = new System.Timers.Timer(10 * seconds); // interval in milliseconds (here - 10 seconds)

            alertTimer.Elapsed += new ElapsedEventHandler((object sender, ElapsedEventArgs e) =>
            {
                if (alerts.Invoke() > 0 && isHide)
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
                DeleteEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void EditarMenuItem_Click(object sender, EventArgs e)
        {
            EditEvent?.Invoke(this, EventArgs.Empty);
            openTab(2);
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
            public static Color color0 = Color.FromArgb(0, 133, 238);
            public static Color color1 = Color.FromArgb(255, 255, 0);
            public static Color color2 = Color.FromArgb(25, 145, 239);
        }

        //Methods
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.color2;
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
                currentBtn.BackColor = RGBColors.color0;
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
            iconCurrentChildForm.IconColor = RGBColors.color1;
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

        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            openTab(1);
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            openTab(2);
            ActivateButton(sender, RGBColors.color1);
            depaPresenter.CleanViewFields();
        }

        private void BtnAlterarSenha_Click(object sender, EventArgs e)
        {
            openTab(1);
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnNotificacoes_Click(object sender, EventArgs e)
        {
            // openTab(4);
            // ActivateButton(sender, RGBColors.color1);
            Alert("Há vencimentos!", Form_Alert.enmType.Warning);

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
            ActivateButton(sender, RGBColors.color1);
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

        public void ntfIconClicked() { 
            Show();
            BringToFront();
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
    }
}
