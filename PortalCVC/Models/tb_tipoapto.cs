using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCVC.Models
{
    public class tb_tipoapto
    {
        [Key]
        public int Id { get; set; }
        public int EmpreendimentoFK { get; set; }
        public int QtdQuartos { get; set; }
        public int QtdSuite { get; set; }
        public int QtdVaga { get; set; }
        public double MetragemInicial { get; set; }
        public double MetragemFinal { get; set; }
        public string Descricao { get; set; }
        public int TipoAptoFK { get; set; }
    }
}
