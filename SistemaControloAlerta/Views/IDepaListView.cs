using System;
using System.Windows.Forms;

namespace SistemaControloAlerta.Views
{
    public interface IDepaListView
    {
        // properties - Fields;

        int Id { get; set; }
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

        //Methods
        void SetDEPAListBindingSource(BindingSource depaList);

        void Close();
    }
}
