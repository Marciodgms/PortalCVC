using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCVC.Models
{
    public class tb_empreendimento
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Empresa")]
        [Required(ErrorMessage = "É preciso informar a empresa.")]
        public int EmpresaFK { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "É preciso informar o nome do empreendimento.")]
        public string Nome { get; set; }
        [Display(Name = "Metragem Inicial")]
        public double MetragemInicial { get; set; }
        [Display(Name = "Metragem Final")]
        public double MetragemFinal { get; set; }
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Endereço não foi preenchido.")]
        public string Endereco { get; set; }
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "CEP não foi preenchido.")]
        public string CEP { get; set; }
        [Display(Name = "Numero")]
        public string Numero { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Obra finalizada?")]
        public bool Terminado { get; set; }
        [Display(Name = "Ativa no APP?")]
        public bool Ativo { get; set; }

        //[NotMapped]
        //public virtual tb_empresa Empresa;
    }
}
