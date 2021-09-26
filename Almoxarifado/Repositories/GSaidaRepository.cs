using Almoxarifado.Data;
using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GSaidaRepository : GenericRepository<GSaida>, IGSaidaRepository
    {
        public GSaidaRepository(DataContext context) : base(context)
        {
        }
    }
}
