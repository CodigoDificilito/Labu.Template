using Application.Interfaces.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Commands
{
    public class CategoriaCommand : ICategoriaCommand
    {
        //Insertar context

        public Task<Categoria> CreateCategoria()
        {
            throw new NotImplementedException();
        }
    }
}
