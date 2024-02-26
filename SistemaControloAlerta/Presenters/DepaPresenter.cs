using SistemaControloAlerta._Repositories;
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
        private IDepaRepository depaRepository;
        private IusuarioRepository usuarioRepository;
        private BindingSource depaBindingSource;
        private IEnumerable<DepaModel> depaList;

        private static System.Timers.Timer alertTimer;
        private SynchronizationContext sctx;

        // Constructor
        public DepaPresenter(IDepaView view)
        {

            String conn = Properties.Settings.Default.DBConnectionString;

            depaBindingSource = new BindingSource();

            this.view = view;
            this.depaRepository = new DepaRepository(conn);
            this.usuarioRepository = new UsuarioRepository(conn);
            // Subscribe event handler methods to view events
            this.view.DepaSearchEvent += DepaSearchDepa;
            this.view.DepaAddNewEvent += DepaAddNewDepa;
            this.view.DepaEditEvent += DepaLoadSelectedToEdit;
            this.view.DepaDeleteEvent += DepaDeleteSelected;
            this.view.DepaSaveEvent += DepaSave;
            this.view.DepaCancelEvent += DepaCancelAction;

            this.view.UsuarioSaveEvent += UsuarioSave;
            this.view.UsuarioCancelEvent += UsuarioCancelAction;

            this.view.OnCmbNotificationSelectionChangeCommittedEvent += OnCmbNotificationSelectionChangeCommitted;

            // Set depas bindind source
            this.view.SetDEPAListBindingSource(depaBindingSource);

            this.view.OnCmbNotificationSavedItem(GetNotificationTime);

            this.view.OnCountAlerts(CountAlerts,GetNotificationTime, sctx, alertTimer);

            // Load depa list view
            LoadAllDepaList();
        }

        // Methods
        private void LoadAllDepaList()
        {
            this.depaList = depaRepository.GetAll();
            depaBindingSource.DataSource = depaList;
        }

        private int CountAlerts() { 
            return depaRepository.CountAlerts();
        }

        private int GetNotificationTime() { 
            return depaRepository.getNotificationTime();
        }

        private void DepaSearchDepa(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (!emptyValue)
            {
                depaList = depaRepository.GetByValue(this.view.SearchValue);
            }
            else
            {
                depaList = depaRepository.GetAll();
            }
            depaBindingSource.DataSource = depaList;
        }

        private void UsuarioCancelAction(object sender, EventArgs e)
        {
            UsuarioCleanViewFields();
        }

        private void UsuarioSave(object sender, EventArgs e)
        {
            var model = new UsuarioModel();

            model.Id = 1;
            model.NivelDeAcesso = 1;
            model.Senha = view.SenhaNova;

            UsuarioModel adm = usuarioRepository.GetById(1);

            try
            {
                if (view.SenhaAtual != adm.Senha) {
                    throw new Exception("Por favor digite a senha atual, essa está errada!");
                }

                new Common.ModelDataValidation().Validate(model);
                
                //Edit model
                usuarioRepository.Edit(model);
                view.Message = "Dados editado com sucesso!";
               
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
            view.IsSuccessful = true;
            UsuarioCleanViewFields();
        }

        private void DepaCancelAction(object sender, EventArgs e)
        {
            DepaCleanViewFields();
        }

        private void DepaSave(object sender, EventArgs e)
        {
            var model = new DepaModel();

            model.Id = Convert.ToInt32(view.DepaId);
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
                    depaRepository.Edit(model);
                    view.Message = "Dados editado com sucesso!";
                }
                else
                { // Add new model
                    depaRepository.Add(model);
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
            DepaCleanViewFields();
        }

        private void OnCmbNotificationSelectionChangeCommitted(object sender, EventArgs e)
        {
            // Salvar a hora selecionada para avisar sobre os vencimentos!

            ComboBox cmb = sender as ComboBox;

            string key = ((KeyValuePair<string, int>)cmb.SelectedItem).Key;
            int value = ((KeyValuePair<string, int>)cmb.SelectedItem).Value;

            depaRepository.setNotificationTime(value);

        }

        public void DepaCleanViewFields()
        {
            view.DepaId = "";
            view.Assunto = "";
            view.Conteudo_despacho = "";
            view.Area_afectada = "";
            view.Numero_de_oficio = "";
            view.Data_orientacao = DateTime.Now;
            view.Prazo = DateTime.Now;
            view.Obs = "";
        }

        public void UsuarioCleanViewFields()
        {
            view.SenhaAtual = "";
            view.SenhaNova = "";
        }

        private void DepaDeleteSelected(object sender, EventArgs e)
        {
            try
            {
                var depa = (DepaModel)depaBindingSource.Current;
                depaRepository.Delete(depa.Id);
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
            private void DepaLoadSelectedToEdit(object sender, EventArgs e)
        {
            var depa = (DepaModel)depaBindingSource.Current;
            view.DepaId = depa.Id.ToString();
            view.Assunto = depa.Assunto;
            view.Conteudo_despacho = depa.Conteudo_despacho;
            view.Area_afectada = depa.Area_afectada;
            view.Numero_de_oficio = depa.Numero_de_oficio;
            view.Data_orientacao = depa.Data_orientacao;
            view.Prazo = depa.Prazo;
            view.Obs = depa.Obs;
            view.IsEdit = true;
        }

        private void DepaAddNewDepa(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        public string getAdminPassword() {
            return usuarioRepository.GetById(1).Senha;
        }
    }
}
