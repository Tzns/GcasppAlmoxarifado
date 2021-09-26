using Almoxarifado.Models;
using System.Collections.Generic;

namespace Almoxarifado.Repositories
{
    public interface IGEntradaRepository : IGenericRepository<GEntrada>
    {
        IEnumerable<GEntrada> Search(string pesquisar);
    }
}