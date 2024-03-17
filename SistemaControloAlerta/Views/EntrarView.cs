using SistemaControloAlerta._Repositories;
using SistemaControloAlerta.Presenters;
using SistemaControloAlerta.Views;
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

namespace SistemaControloAlerta
{
    public partial class EntrarView : Form
    {

        string resultado;

        public EntrarView()
        {
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            // this.ControlBox = this.MaximizeBox = this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            resultado = TxtSenha.Text;
            Close();
        }


        public static string InputBoxDialog()

        {

            EntrarView ib = new EntrarView();

            ib.ShowDialog();

            string s = ib.resultado;

            ib.Close();

            if (s == string.Empty)

                return "";

            else

                return s;

        }

        private void FrmEntrar_Load(object sender, EventArgs e)
        {
            CmbNivelAcesso.SelectedIndex = 0;
        }
    }
}
