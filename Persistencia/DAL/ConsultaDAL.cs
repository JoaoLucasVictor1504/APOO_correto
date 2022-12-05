
using Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Modelo.Trabalhos;


namespace Persistencia.DAL
{
    public class ConsultaDAL
    {
        private EFContext context = new EFContext();
        public IQueryable<Consulta> ObterConsultasClassificadasPorData()
        {
            return context.Consultas.Include(c => c.Exames).
            OrderBy(n => n.data_hora);
        }
        public Consulta ObterConsultaPorId(int id)
        {
            return context.Consultas.Where(p => p.Id == id).Include(c => c.Exames).First();
        }
        public void GravarConsulta(Consulta consulta)
        {
            if (consulta.data_hora == null)
            {
                context.Consultas.Add(consulta);
            }
            else
            {
                context.Entry(consulta).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public Consulta EliminarConsultaPorId(int id)
        {
            Consulta consulta = ObterConsultaPorId(id);
            context.Consultas.Remove(consulta);
            context.SaveChanges();
            return consulta;
        }
    }
}
