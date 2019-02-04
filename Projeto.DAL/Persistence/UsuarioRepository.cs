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
    public class UsuarioRepository
    {
        //método para gravar um Usuario na base de dados..
        public void Inserir(Usuario u)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(u).State = EntityState.Added;//inserindo..
                Con.SaveChanges();//executando..
            }
        }

        //método para atualizar um Usuario na base de dados..
        public void Udpate(Usuario u)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(u).State = EntityState.Modified;
                Con.SaveChanges();
            }
        }

        //método para Excluir um Usuario na base de dados..
        public void Excluir(Usuario u)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(u).State = EntityState.Deleted;//Deletando...
                Con.SaveChanges();//executando..
            }
        }

        //método para listar todos os usuarios...
        public List<Usuario> ListarTodos()
        {
            using (Conexao Con = new Conexao())
            {
                //Retornar todos os Usuarios em order by Nome
                return Con.Usuario.OrderBy(c => c.Nome).ToList();
            }
        }

        //método para retornar 1 Usuario pelo id..
        public Usuario ObterPorId(int IdUsuario)
        {
            using (Conexao Con = new Conexao())
            {
                return Con.Usuario.Where(u => u.idUsuario == IdUsuario).FirstOrDefault();
                //retorna o 1º Usuario encontrado
                //ou retorna null se nenhum cliente for encontrado..
            }
        }

        public Usuario ObterPorLoginSenha(string email, string senha)
        {
            using (Conexao Con = new Conexao())
            {
                return Con.Usuario
                    .Where(u => u.Email.Equals(email) && u.Senha.Equals(senha))
                    .FirstOrDefault();
            }
        }

        public bool LoginExistente(string email)
        {
            using (Conexao Con = new Conexao())
            {
                return Con.Usuario
                    .Where(u => u.Email.Equals(email))
                    .Count() > 0;
            }
        }
    }
}
