using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Seres_Vivos
{
    public class Especie
    {
        public int EspecieId { get; set; }
        public string Nome { get; set; }
        public IList<Pet> Pets { get; set; }
    }
}