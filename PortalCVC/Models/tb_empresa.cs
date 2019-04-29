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
        public string Nome { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
        public string Telefone { get; set; }
        public string Descricao { get; set; }

    }
}
