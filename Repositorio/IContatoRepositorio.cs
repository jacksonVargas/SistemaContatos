using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaContatos.Models;

namespace SistemaContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos(); 
    
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);
    }
}