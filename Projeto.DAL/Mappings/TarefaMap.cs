using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.DAL.Mappings
{
    public class TarefaMap : EntityTypeConfiguration<Tarefa>
    {
        public TarefaMap()
        {
            ToTable("Tarefa");

            HasKey(u => u.IdTarefa);

            Property(u => u.IdTarefa).HasColumnName("IdTarefa");

            Property(u => u.Titulo).HasColumnName("Titulo").HasMaxLength(50);

            Property(u => u.Status).HasColumnName("Status").HasMaxLength(20);
        }
    }
}
