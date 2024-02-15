using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Models
{
    public class NiveisAcesso
    {
        // Fields
        int id;
        string nivel_acesso;

        // properties - Validations
        [DisplayName("Nº")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Nível de acesso")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NivelDeAcesso { get => nivel_acesso; set => nivel_acesso = value; }
    }
}
