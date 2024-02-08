using SistemaControloAlerta.Forms;
using SistemaControloAlerta.Models;
using SistemaControloAlerta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SistemaControloAlerta.Presenters
{
    class DepaPresenter
    {
        // Fields
        private IDepaView view;
        private IDepaRepository repository;
        private BindingSource depaBindingSource;
        private IEnumerable<DepaModel> depaList;

        private static System.Timers.Timer alertTimer;
        private SynchronizationContext sctx;

        // Constructor
        public DepaPresenter(IDepaView view, IDepaRepository repository)
        {
            depaBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            // Subscribe event handler methods to view events
            this.view.SearchEvent += SearchDepa;
            this.view.AddNewEvent += AddNewDepa;
            this.view.EditEvent += LoadSelectedDepaToEdit;
            this.view.DeleteEvent += DeleteSelectedDepa;
            this.view.SaveEvent += SaveDepa;
            this.view.CancelEvent += CancelAction;

            // Set depas bindind source
            this.view.SetDEPAListBindingSource(depaBindingSource);

            this.view.OnCountAlerts(CountAlerts, sctx, alertTimer);

            // Load depa list view
            LoadAllDepaList();
        }

        // Methods
        private void LoadAllDepaList()
        {
            this.depaList = repository.GetAll();
            depaBindingSource.DataSource = depaList;
        }

        private int CountAlerts() { 
            return repository.CountAlerts();
        }

        private void SearchDepa(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (!emptyValue)
            {
                depaList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                depaList = repository.GetAll();
            }
            depaBindingSource.DataSource = depaList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveDepa(object sender, EventArgs e)
        {
            var model = new DepaModel();

            model.Id = Convert.ToInt32(view.Id);
            model.Assunto = view.Assunto;
            model.Conteudo_despacho = view.Conteudo_despacho;
            model.Area_afectada = view.Area_afectada;
            model.Numero_de_oficio = view.Numero_de_oficio;
            model.Data_orientacao = view.Data_orientacao;
            model.Prazo = view.Prazo;
            model.Obs = view.Obs;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                { //Edit model
                    repository.Edit(model);
                    view.Message = "Dados editado com sucesso!";
                }
                else
                { // Add new model
                    repository.Add(model);
                    view.Message = "Dados adicionados com sucesso!";
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            view.IsSuccessful = true;
            LoadAllDepaList();
            CleanViewFields();
        }

        public void CleanViewFields()
        {
            view.Id = "";
            view.Assunto = "";
            view.Conteudo_despacho = "";
            view.Area_afectada = "";
            view.Numero_de_oficio = "";
            view.Data_orientacao = DateTime.Now;
            view.Prazo = DateTime.Now;
            view.Obs = "";
        }

        private void DeleteSelectedDepa(object sender, EventArgs e)
        {
            try
            {
                var depa = (DepaModel)depaBindingSource.Current;
                repository.Delete(depa.Id);
                view.IsSuccessful = true;
                view.Message = "Dados eliminado com sucesso!";
                LoadAllDepaList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Ocorreu um erro, não é possível deletar!";
            }
        }
            private void LoadSelectedDepaToEdit(object sender, EventArgs e)
        {
            var depa = (DepaModel)depaBindingSource.Current;
            view.Id = depa.Id.ToString();
            view.Assunto = depa.Assunto;
            view.Conteudo_despacho = depa.Conteudo_despacho;
            view.Area_afectada = depa.Area_afectada;
            view.Numero_de_oficio = depa.Numero_de_oficio;
            view.Data_orientacao = depa.Data_orientacao;
            view.Prazo = depa.Prazo;
            view.Obs = depa.Obs;
            view.IsEdit = true;
        }

        private void AddNewDepa(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
