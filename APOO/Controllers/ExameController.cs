using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Modelo.Pessoas;
using Modelo.Seres_Vivos;
using Persistencia.Context;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Web.Services.Description;
using APOO.Servico;
using Modelo.Trabalhos;


namespace APOO.Controllers
{
    public class ExameController : Controller
    {
        private ExameServico exameServico = new ExameServico();
        private ActionResult ObterVisaoExamePorId(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(
                HttpStatusCode.BadRequest);
            }
            Exame exame = exameServico.ObterExamePorId((int)id);
            if (exame == null)
            {
                return HttpNotFound();
            }
            return View(exame);
        }

        private ActionResult GravarExame(Exame exame)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    exameServico.GravarExame(exame);
                    return RedirectToAction("Index");
                }
                return View(exame);
            }
            catch
            {
                return View(exame);
            }
        }
        // GET: Exames
        public ActionResult Index()
        {
            return View(exameServico.ObterExamesClassificadosPorDesc());
        }
        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Exame exame)
        {
            return GravarExame(exame);
        }
        // GET: Edit
        public ActionResult Edit(int? id)
        {
            return ObterVisaoExamePorId(id);
        }
        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Exame exame)
        {
            return GravarExame(exame);
        }

        // GET: Delete
        public ActionResult Delete(int? id)
        {
            return ObterVisaoExamePorId(id);
        }
        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Exame exame = exameServico.EliminarExamePorId(id);
                TempData["Message"] = "Exame " + exame.Descricao.ToUpper() + " foi removido";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}