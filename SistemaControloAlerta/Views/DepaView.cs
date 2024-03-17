using FontAwesome.Sharp;
using SistemaControloAlerta._Repositories;
using SistemaControloAlerta.Presenters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
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
        private const int milisecondsInMinute = 60000;
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
            alertTimer = new System.Timers.Timer(currentTime * milisecondsInMinute);

            alertTimer.Elapsed += new ElapsedEventHandler((object sender, ElapsedEventArgs e) =>
            {

                if (currentTime != time.Invoke())
                {
                    currentTime = time.Invoke();
                    alertTimer.Interval = currentTime * milisecondsInMinute;
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
                        Alert("Alerta de grau de cumprimento!", Form_Alert.enmType.Warning);
                    }, null);
                }
            }); // handler - what to do when time elaps

            alertTimer.Start();
        }

        public void OnCmbNotificationSavedItem(Func<int> time)
        {
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
                if (ValidarAutorizacao())
                {
                    DepaDeleteEvent?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void EditarMenuItem_Click(object sender, EventArgs e)
        {

            if (ValidarAutorizacao())
            {
                DepaEditEvent?.Invoke(this, EventArgs.Empty);
                openTab(2);
            }
        }

        private bool ValidarAutorizacao()
        {

            string resultado = EntrarView.InputBoxDialog();

            /* pegar a senha. */

            string password = depaPresenter.getAdminPassword();

            /* verifica se o resultado é uma string vazia o que indica que foi cancelado. */

            if (resultado != "")
            {

                if (!string.IsNullOrEmpty(resultado))
                {
                    resultado = resultado.TrimStart();
                }

                /* Verifica se a senha confere. */

                if (resultado != password)
                {
                    MessageBox.Show("Senha Incorreta.");
                }
                else
                {
                    MessageBox.Show("Senha válida.");
                    return true;
                }
            }
            return false;
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
                    row.Cells[9].Style.BackColor = Color.OrangeRed;
                }

                if (row.Cells[8].Value.ToString() == "VENCEU")
                {
                    row.Cells[8].Style.BackColor = Color.Red;
                }
                else if (row.Cells[8].Value.ToString() == "VENCEU HOJE")
                {
                    row.Cells[8].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[8].Style.BackColor = Color.LightGreen;
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


        // Abrir file explorer numa localização especifica
        // https://www.codeproject.com/Questions/852563/How-to-open-file-explorer-at-given-location-in-csh
        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);

            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }

        }

        // Extra exportar datagridview para excel
        // https://www.c-sharpcorner.com/UploadFile/hrojasara/export-datagridview-to-excel-in-C-Sharp/

        private void ExportDataGridViewToExcel()
        {
            string excelFilePath = System.IO.Path.Combine(Application.UserAppDataPath, "depa.xlsx");

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = false;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            // worksheet = workbook.Sheets["Folha1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from DEPA software";
            // storing header part in Excel  
            for (int i = 1; i < DgvDEPA.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DgvDEPA.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < DgvDEPA.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DgvDEPA.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DgvDEPA.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  

            try
            {
                if (System.IO.File.Exists(excelFilePath))
                {
                    System.IO.File.Delete(excelFilePath);
                }
                workbook.SaveAs(excelFilePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            catch (Exception ex)
            {
                // Handle deletion or saving errors gracefully
                MessageBox.Show(ex.Message);
            }

            // disposes

            try
            {
                Marshal.ReleaseComObject(worksheet);
                workbook.Close();
                Marshal.ReleaseComObject(workbook);
                app.Quit();
                Marshal.FinalReleaseComObject(app);
            }
            catch (Exception) { }
            app = null;

            // open saved folder
            OpenFolder(Application.UserAppDataPath);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel();
        }
    }
}
