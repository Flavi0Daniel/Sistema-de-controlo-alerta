using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControloAlerta.Forms
{
    public partial class FrmPrincipal : Form
    {
        
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public FrmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PanelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = this.MaximizeBox = this.MinimizeBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
        private struct RGBColors
        {
            public static Color color0 = Color.FromArgb(0, 133, 238);
            public static Color color1 = Color.FromArgb(255, 255, 0);
            public static Color color2 = Color.FromArgb(25, 145, 239);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
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

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = RGBColors.color1;
            lblTitleChildForm.Text = "Home";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            // Center text
            int h, w;

            h = (panelDesktop.Height - LblDesktop.Height) / 2;
            w = (panelDesktop.Width -LblDesktop.Width) / 2;

            LblDesktop.Top = h;
            LblDesktop.Left = w;


        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmListar());
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmAdicionar());
        }

        private void BtnAlterarSenha_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmAlterarSenha());
        }

        private void BtnNotificacoes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new FrmNotificacoes());
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null) {
                currentChildForm.Close();
            }

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

        public void VoltarTelaLogin() {

            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is FrmEntrar);
            if (formToShow != null)
            {
                formToShow.Show();
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            VoltarTelaLogin();
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
    }
}
