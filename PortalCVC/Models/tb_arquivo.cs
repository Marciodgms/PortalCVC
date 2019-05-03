using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
namespace PortalCVC.Models
{
    public class tb_arquivo
    {
        [Key]
        public int Id { get; set; }
        public int TipoArquivoFK { get; set; }
        public int EmpreendimentoFK { get; set; }
        public string Nome { get; set; }
        public string SRC { get; set; }
        public string FileName { get; set; }

        [NotMapped]
        public List<IFormFile> files { get; set; }

    }
}
