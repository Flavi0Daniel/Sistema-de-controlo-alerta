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

namespace SistemaControloAlerta.Forms
{
    public partial class FrmAdicionar : Form, IDepaAddView
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
        // private string searchValue;
        private bool isSuccessful;
        private bool isEdit;

        public FrmAdicionar()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Edit button
            BtnSalvar.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    // Do something

                }
                MessageBox.Show(Message);
            };
            
            // Cancel button
            BtnCancelar.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public void SetDEPAListBindingSource(BindingSource depaList)
        {
            // throw new NotImplementedException();
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
        public bool IsEdit { get => isEdit; set => IsEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => Message = value; }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
    }
}
