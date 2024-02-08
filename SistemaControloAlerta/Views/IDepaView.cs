using System;
using System.Threading;
using System.Windows.Forms;

namespace SistemaControloAlerta.Views
{
    public interface IDepaView
    {
        // properties - Fields;

        string Id { get; set; }
        string Assunto { get; set; }
        string Conteudo_despacho { get; set; }
        string Area_afectada { get; set; }
        string Numero_de_oficio { get; set; }
        DateTime Data_orientacao { get; set; }
        DateTime Prazo { get; set; }
        string Obs { get; set; }

        string SearchValue { get; set; }

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }

        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler AddNewEvent;
        event EventHandler CancelEvent;
        event EventHandler SaveEvent;

        //Methods
        void SetDEPAListBindingSource(BindingSource depaList);

        void OnCountAlerts(Func<int> alerts, SynchronizationContext synchronizationContext, System.Timers.Timer timer);

        void OnClose();
    }
}
