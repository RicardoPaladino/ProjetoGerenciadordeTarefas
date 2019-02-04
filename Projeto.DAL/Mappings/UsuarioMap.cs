using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.DAL.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(u => u.idUsuario);

            Property(u => u.idUsuario).HasColumnName("IdUsuario");

            Property(u => u.Nome).HasColumnName("Nome").HasMaxLength(50);

            Property(u => u.Email).HasColumnName("Email").HasMaxLength(100);

            Property(u => u.Permisao).HasColumnName("Permisao").HasMaxLength(25);

            Property(u => u.Senha).HasColumnName("Senha").HasMaxLength(50);
        }
    }
}
