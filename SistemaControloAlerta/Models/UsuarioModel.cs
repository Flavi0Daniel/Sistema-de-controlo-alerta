using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControloAlerta.Models
{
    public class UsuarioModel
    {

        // Fields
        int id;
        int nivel_acesso;
        string senha;

        // properties - Validations
        [DisplayName("Nº")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Nível de acesso")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public int NivelDeAcesso { get => nivel_acesso; set => nivel_acesso = value; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get => senha; set => senha = value; }

    }
}
