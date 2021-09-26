using Almoxarifado.Data;
using Almoxarifado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almoxarifado.Repositories
{
    public class GSaidaItemRepository : GenericRepository<GSaidaItem>, IGSaidaItemRepository
    {
        public GSaidaItemRepository(DataContext context) : base(context)
        {
        }
    }
}
