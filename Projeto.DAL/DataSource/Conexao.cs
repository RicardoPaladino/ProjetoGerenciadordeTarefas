using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //connectionstring..
using System.Data.Entity; //entityframework
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Entities; //entidades
using Projeto.DAL.Mappings; //mapeamento

namespace Projeto.DAL.DataSource
{
    public class Conexao : DbContext
    {
       public Conexao() : base(ConfigurationManager.ConnectionStrings["CONEXAO"].ConnectionString)
       {
       }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //classes de mapeamento..
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new TarefaMap());
        }

        //declarar um DbSet para cada entidade..
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
    }
}
