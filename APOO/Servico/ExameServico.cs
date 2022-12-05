using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Trabalhos;
using Persistencia.DAL;

namespace APOO.Servico
{
    public class ExameServico
    {
        private ExameDAL exameDAL = new ExameDAL();
        public IQueryable<Exame> ObterExamesClassificadosPorDesc()
        {
            return exameDAL.ObterExamesClassificadosPorDesc();
        }
        public Exame ObterExamePorId(int id)
        {
            return exameDAL.ObterExamePorId(id);
        }
        public void GravarExame(Exame exame)
        {
            exameDAL.GravarExame(exame);
        }
        public Exame EliminarExamePorId(int id)
        {
            Exame exame = exameDAL.ObterExamePorId(id);
            exameDAL.EliminarExamePorId(id);
            return exame;
        }
    }
}