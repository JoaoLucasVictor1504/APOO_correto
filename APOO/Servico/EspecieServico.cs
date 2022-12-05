using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Seres_Vivos;
using Persistencia.DAL;

namespace APOO.Servico
{
    public class EspecieServico
    {
        private EspecieDAL especieDAL = new EspecieDAL();
        public IQueryable<Especie> ObterEspeciesClassificadasPorNome()
        {
            return especieDAL.ObterEspeciesClassificadasPorNome();
        }
        public Especie ObterEspeciePorId(int id)
        {
            return especieDAL.ObterEspeciePorId(id);
        }
        public void GravarEspecie(Especie especie)
        {
            especieDAL.GravarEspecie(especie);
        }
        public Especie EliminarEspeciePorId(int id)
        {
            Especie especie = especieDAL.ObterEspeciePorId(id);
            especieDAL.EliminarEspeciePorId(id);
            return especie;
        }
    }
}