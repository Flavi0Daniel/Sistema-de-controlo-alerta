using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

/*
 * 
 * Departamento de Estudo Paneamento e Análise
 * 
 */

namespace SistemaControloAlerta.Models
{
    public class DepaModel
    {
        // Fields
        int id;
        string assunto;
        string conteudo_despacho;
        string area_afectada; 
        string numero_de_oficio; 
        DateTime data_orientacao;
        DateTime prazo;
        string obs;

        // properties - Validations
        [DisplayName("Nº")]
        public int Id { get => id; set => id = value; }
        
        [DisplayName("Assunto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Assunto { get => assunto; set => assunto = value; }
        
        [DisplayName("Conteúdo do despacho")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Conteudo_despacho { get => conteudo_despacho; set => conteudo_despacho = value; }
        
        [DisplayName("Área afectada")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Area_afectada { get => area_afectada; set => area_afectada = value; }
        
        [DisplayName("Of.Interno Nº")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Numero_de_oficio { get => numero_de_oficio; set => numero_de_oficio = value; }
        
        [DisplayName("Data")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Data_orientacao { get => data_orientacao; set => data_orientacao = value; }
        
        [DisplayName("Prazo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public DateTime Prazo { get => prazo; set => prazo = value; }
        
        [DisplayName("OBS")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Obs { get => obs; set => obs = value; }
    }
}
