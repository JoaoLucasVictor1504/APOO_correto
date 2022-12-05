using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Trabalhos;


namespace Modelo.Pessoas
{
    public class Veterinario : Usuario
    {
        public string Crmv { get; set; }
        public IList<Consulta> Consultas { get; set; }
    }
}
