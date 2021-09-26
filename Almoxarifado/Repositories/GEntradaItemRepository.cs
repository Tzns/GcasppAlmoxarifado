using Almoxarifado.Data;
using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GEntradaItemRepository : GenericRepository<GEntradaItem>, IGEntradaItemRepository
    {
        public GEntradaItemRepository(DataContext context) : base(context)
        {
        }
    }
}
