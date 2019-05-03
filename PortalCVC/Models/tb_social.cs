using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCVC.Models
{
    public class tb_social
    {
        [Key]
        public int Id { get; set; }
        public int EmpresaFK { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Pinterest { get; set; }
        public string Linkedin { get; set; }

    }
}
