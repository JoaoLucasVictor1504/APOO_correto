using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelo.Trabalhos;
using Modelo.Seres_Vivos;
using Modelo.Pessoas;
using Persistencia.DAL;

namespace APOO.Servico
{
    public class VeterinarioServico
    {
        private VeterinarioDAL veterinarioDAL = new VeterinarioDAL();
        public IQueryable<Veterinario> ObterVeterinariosClassificadosPorNome()
        {
            return veterinarioDAL.ObterVeterinariosClassificadosPorNome();
        }
        public Veterinario ObterVeterinarioPorId(long id)
        {
            return veterinarioDAL.ObterVeterinarioPorId(id);
        }
        public void GravarVeterinario(Veterinario veterinario)
        {
            veterinarioDAL.GravarVeterinario(veterinario);
        }
        public Veterinario EliminarVeterinarioPorId(long id)
        {
            Veterinario veterinario = veterinarioDAL.ObterVeterinarioPorId(id);
            veterinarioDAL.EliminarVeterinarioPorId(id);
            return veterinario;
        }
    }
}