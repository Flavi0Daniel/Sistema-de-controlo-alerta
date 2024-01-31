using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Views
{
    public interface IDepaAddView
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

        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }

        string Message { get; set; }

        // Events
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
    }
}
