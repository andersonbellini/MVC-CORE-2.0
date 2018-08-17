using introducao.Data;
using introducao.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao.Services
{
    public class PaisRepositorioEF : IRepositorioPaises
    {

        public ApplicationDbContext DbContext { get; }
        public PaisRepositorioEF(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Pais> ObterPaises()
        {
            return DbContext.Paises.ToList();
        }
    }
}
