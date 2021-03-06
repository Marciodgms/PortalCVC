﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalCVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<tb_empreendimento> tb_empreendimento { get; set; }
        public DbSet<tb_empresa> tb_empresa { get; set; }
        public DbSet<tb_arquivo> tb_arquivo { get; set; }
        public DbSet<tb_tipoarquivo> tb_tipoarquivo { get; set; }
    }
}
