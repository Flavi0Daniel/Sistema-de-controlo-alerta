using SistemaControloAlerta._Repositories;
using SistemaControloAlerta.Models;
using SistemaControloAlerta.Presenters;
using SistemaControloAlerta.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace SistemaControloAlerta.Forms
{
    public partial class FrmListar : Form, IDepaListView
    {
        private string message;
        private int id;
        private string assunto;
        private string conteudo_despacho;
        private string area_afectada;
        private string numero_de_oficio;
        private DateTime data_orientacao;
        private DateTime prazo;
        private String obs;
        private string searchValue;
        private bool isSuccessful;
        private bool isEdit;

        public FrmListar()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search button
            BtnPesquisar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }

        // Fields
        public int Id { get => id; set => id = value; }
        public string Assunto { get => assunto; set => assunto = value; }
        public string Conteudo_despacho { get => conteudo_despacho; set => conteudo_despacho = value; }
        public string Area_afectada { get => area_afectada; set => area_afectada = value; }
        public string Numero_de_oficio { get => numero_de_oficio; set => numero_de_oficio = value; }
        public DateTime Data_orientacao { get => data_orientacao; set => data_orientacao = value; }
        public DateTime Prazo { get => prazo; set => prazo = value; }
        public string Obs { get => obs; set => obs = value; }
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

        // Methods
        public void SetDEPAListBindingSource(BindingSource depaList)
        {
            DgvDEPA.DataSource = depaList;
        }

        public new void Close() {
            this.Close();
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
            var frmPrincipal = (FrmPrincipal) Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is FrmPrincipal && true);
            
            string connectionString = Properties.Settings.Default.DBConnectionString;
            IDepaEditView view = new FrmEditar();
            IDepaRepository repository = new DepaRepository(connectionString);
            new DepaPresenter(view, repository);
            // frmPrincipal.ActivateButton(sender, FrmPrincipal.RGBColors.color1);
            frmPrincipal.OpenChildForm((Form)view);
        }
    }
}
