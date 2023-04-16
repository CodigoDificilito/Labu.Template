using Application.Interfaces.Commands;
using Application.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCase
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaCommand _command;
        //private readonly ICategoriaQuery _query;

        public CategoriaService(ICategoriaCommand command /* , ICategoriaQuery query  */)
        {
            _command = command;
            //_query = query
        }

        public Task<Categoria> CreateCategoria()
        {
            throw new NotImplementedException();
        }
    }
}
