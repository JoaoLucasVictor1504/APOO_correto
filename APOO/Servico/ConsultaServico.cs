using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Trabalhos;
using Persistencia.DAL;

namespace APOO.Servico
{
    public class ConsultaServico
    {
        private ConsultaDAL consultaDAL = new ConsultaDAL();
        public IQueryable<Consulta> ObterConsultasClassificadasPorData()
        {
            return consultaDAL.ObterConsultasClassificadasPorData();
        }
        public Consulta ObterConsultaPorId(int id)
        {
            return consultaDAL.ObterConsultaPorId(id);
        }
        public void GravarProduto(Consulta consulta)
        {
            consultaDAL.GravarConsulta(consulta);
        }
        public Consulta EliminarConsultaPorId(int id)
        {
            return consultaDAL.EliminarConsultaPorId(id);
        }
    }
}