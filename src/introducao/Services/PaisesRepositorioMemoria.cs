using introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introducao.Services
{
    public class PaisesRepositorioMemoria : IRepositorioPaises
    {
        //List<string> paises = new List<string>() { "Brasil", "Uruguai", "China", "México", "Suiça" };
        //return paises;
        public List<Pais> ObterPaises()
        {
            List<Pais> paises = new List<Pais>() {
                new Pais("Chile"),
                new Pais("Guatemala"),
                new Pais("Argentina")
            };

            return paises;
        }

    }
}
