using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using introducao.Models;

namespace introducao.Services
{
    public interface IRepositorioPaises
    {
        List<Pais> ObterPaises();
    }
}
