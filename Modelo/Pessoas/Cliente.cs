using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Seres_Vivos;

namespace Modelo.Pessoas
{
    public class Cliente : Usuario
    {
        public string cpf { get; set; }
        public IList<Pet> Pets { get; set; }
    }
}
