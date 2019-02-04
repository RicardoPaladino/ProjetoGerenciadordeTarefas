using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //entityframework..
using Projeto.Entities; //entidades..
using Projeto.DAL.DataSource; //conexão..

namespace Projeto.DAL.Persistence
{
    public class TarefaRepository
    {
        //método para gravar um Item na base de dados..
        public void Insert(Tarefa t)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(t).State = EntityState.Added; //inserindo..
                Con.SaveChanges(); //executando..
            }
        }

        //método para atualizar um Item na base de dados..
        public void Update(Tarefa t)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(t).State = EntityState.Modified; //atualizando..
                Con.SaveChanges(); //executando..
            }
        }

        //método para Deletar um item na base de dados..
        public void Delete(Tarefa t)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(t).State = EntityState.Deleted; //Deletar..
                Con.SaveChanges(); //executando..
            }
        }

        //método para listar todos os itens...
        public List<Tarefa> FindAll()
        {
            using (Conexao Con = new Conexao())
            {
                //retornar todos os itens
                return Con.Tarefa.OrderBy(t => t.Titulo).ToList();
            }
        }

        //método para retornar 1 tarefa pelo id..
        public Tarefa ObterPorId(int IdTarefa)
        {
            using (Conexao Con = new Conexao())
            {
                return Con.Tarefa.Where(t => t.IdTarefa == IdTarefa).FirstOrDefault();
                //retorna o 1º Tarefas encontrado
                //ou retorna null se nenhum tarefa for encontrado..
            }
        }
    }
}
