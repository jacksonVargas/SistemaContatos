using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaContatos.Data;
using SistemaContatos.Models;

namespace SistemaContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext; 
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if(contatoDB == null) throw new Exception("Houve um problema na atualização do contato");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Telefone = contato.Telefone;

            _bancoContext.contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;
        }
    }
}