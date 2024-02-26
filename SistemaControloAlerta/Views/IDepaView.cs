using System;
using System.Threading;
using System.Windows.Forms;

namespace SistemaControloAlerta.Views
{
    public interface IDepaView
    {
        // properties - Fields;

        string DepaId { get; set; }
        string Assunto { get; set; }
        string Conteudo_despacho { get; set; }
        string Area_afectada { get; set; }
        string Numero_de_oficio { get; set; }
        DateTime Data_orientacao { get; set; }
        DateTime Prazo { get; set; }
        string Obs { get; set; }

        string SenhaAtual { get; set; }

        string SenhaNova { get; set; }

        string SearchValue { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }

        string Message { get; set; }

        // Events
        event EventHandler DepaSearchEvent;
        event EventHandler DepaEditEvent;
        event EventHandler DepaDeleteEvent;
        event EventHandler DepaAddNewEvent;
        event EventHandler DepaCancelEvent;
        event EventHandler DepaSaveEvent;

        event EventHandler UsuarioCancelEvent;
        event EventHandler UsuarioSaveEvent;

        event EventHandler OnCmbNotificationSelectionChangeCommittedEvent;

        //Methods
        void SetDEPAListBindingSource(BindingSource depaList);

        void OnCmbNotificationSavedItem(Func<int> time);

        void OnCountAlerts(Func<int> alerts, Func<int> time, SynchronizationContext synchronizationContext, System.Timers.Timer timer);

        void OnClose();
    }
}
