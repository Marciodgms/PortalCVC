using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCVC.Models
{
    public class tb_empresa
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Endereço não foi preenchido.")]
        public string Endereco { get; set; }
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "CEP não foi preenchido.")]
        public string CEP { get; set; }
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }
        [Display(Name = "Numero")]
        public string Numero { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
