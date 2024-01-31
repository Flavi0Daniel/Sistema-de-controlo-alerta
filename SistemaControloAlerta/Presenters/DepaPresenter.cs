using SistemaControloAlerta.Models;
using SistemaControloAlerta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControloAlerta.Presenters
{
    class DepaPresenter
    {
        // Fields
        private IDepaListView view1;
        private IDepaAddView view2;
        private IDepaEditView view3;
        private IDepaRepository repository;
        private BindingSource depaBindingSource;
        private IEnumerable<DepaModel> depaList;

        
        // Constructor
        public DepaPresenter(IDepaListView view, IDepaRepository repository) {
            depaBindingSource = new BindingSource();
            this.view1 = view;
            this.repository = repository;
            // Subscribe event handler methods to view events
            this.view1.SearchEvent += SearchDepa;
            this.view1.EditEvent += LoadSelectedDepaToEdit;
            this.view1.DeleteEvent += DeleteSelectedDepa;
            // Set depas bindind source
            this.view1.SetDEPAListBindingSource(depaBindingSource);
            // Load depa list view
            LoadAllDepaList();
        }

        public DepaPresenter(IDepaAddView view, IDepaRepository repository)
        {
            depaBindingSource = new BindingSource();
            this.view2 = view;
            this.repository = repository;
            // Subscribe event handler methods to view events
            this.view1.SearchEvent += SearchDepa;
            this.view1.EditEvent += LoadSelectedDepaToEdit;
            this.view1.DeleteEvent += DeleteSelectedDepa;
            // Set depas bindind source
            this.view1.SetDEPAListBindingSource(depaBindingSource);
            // Load depa list view
            LoadAllDepaList();
        }

        public DepaPresenter(IDepaListView view1, IDepaEditView view3, IDepaRepository repository)
        {
            depaBindingSource = new BindingSource();
            this.view1 = view1;
            this.view3 = view3;
            this.repository = repository;
            // Subscribe event handler methods to view events
            this.view1.SearchEvent += SearchDepa;
            this.view1.EditEvent += LoadSelectedDepaToEdit;
            this.view1.DeleteEvent += DeleteSelectedDepa;
            this.view3.SaveEvent += SaveDepa;
            this.view3.CancelEvent += CancelAction;
            // Set depas bindind source
            this.view1.SetDEPAListBindingSource(depaBindingSource);
            // Load depa list view
            LoadAllDepaList();
        }

        // Methods
        private void LoadAllDepaList()
        {
            this.depaList = repository.GetAll();
            depaBindingSource.DataSource = depaList;
        }

        private void SearchDepa(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view1.SearchValue);
            if (!emptyValue)
            {
                depaList = repository.GetByValue(this.view1.SearchValue);
            }
            else {
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

            if (this.view3 != null)
            {
                model.Id = Convert.ToInt32(view1.Id);
                model.Assunto = view1.Assunto;
                model.Conteudo_despacho = view1.Conteudo_despacho;
                model.Area_afectada = view1.Area_afectada;
                model.Numero_de_oficio = view1.Numero_de_oficio;
                model.Data_orientacao = view1.Data_orientacao;
                model.Prazo = view1.Prazo;
                model.Obs = view1.Obs;
            }
            else {
                model.Id = Convert.ToInt32(view3.Id);
                model.Assunto = view3.Assunto;
                model.Conteudo_despacho = view3.Conteudo_despacho;
                model.Area_afectada = view3.Area_afectada;
                model.Numero_de_oficio = view3.Numero_de_oficio;
                model.Data_orientacao = view3.Data_orientacao;
                model.Prazo = view3.Prazo;
                model.Obs = view3.Obs;
            }

            try {
                new Common.ModelDataValidation().Validate(model);
                if (view1.IsEdit) { //Edit model
                    repository.Edit(model);
                    view1.Message = "Dados editado com sucesso!";
                    this.view3.Close();
                    this.view1.Close();
                } else { // Add new model
                    repository.Add(model);
                    view1.Message = "Dados adicionados com sucesso!";
                }
            }
            catch (Exception ex) { 
                view1.IsSuccessful = false;
                view1.Message = ex.Message;
            }
            view1.IsSuccessful = true;
            LoadAllDepaList();
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view1.Id = 0;
            view1.Assunto = "";
            view1.Conteudo_despacho = "";
            view1.Area_afectada = "";
            view1.Numero_de_oficio = "";
            view1.Data_orientacao = DateTime.Now;
            view1.Prazo = DateTime.Now;
            view1.Obs = "";
        }

        private void DeleteSelectedDepa(object sender, EventArgs e)
        {
            try
            {
                var depa = (DepaModel)depaBindingSource.Current;
                repository.Delete(depa.Id);
                view1.IsSuccessful = true;
                view1.Message = "Dados eliminado com sucesso!";
                LoadAllDepaList();
            }
            catch (Exception)
            {
                view1.IsSuccessful = false;
                view1.Message = "Ocorreu um erro, não é possível deletar!";
            }
        }

        private void LoadSelectedDepaToEdit(object sender, EventArgs e)
        {
            var depa = (DepaModel)depaBindingSource.Current;
            view1.Id = depa.Id;
            view1.Assunto = depa.Assunto;
            view1.Conteudo_despacho = depa.Conteudo_despacho;
            view1.Area_afectada = depa.Area_afectada;
            view1.Numero_de_oficio = depa.Numero_de_oficio;
            view1.Data_orientacao = depa.Data_orientacao;
            view1.Prazo = depa.Prazo;
            view1.Obs = depa.Obs;
            view1.IsEdit = true;
        }

        private void AddNewDepa(object sender, EventArgs e)
        {
            view1.IsEdit = false;
        }
    }
}
