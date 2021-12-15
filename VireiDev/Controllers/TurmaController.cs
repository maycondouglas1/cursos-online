using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VireiDev.Context;
using VireiDev.Models;

namespace VireiDev.Controllers
{
    public class TurmaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Turma
        public ActionResult Index()
        {
            return View(db.Turmas.ToList());
        }

        // GET: Turma/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurmaModels turmaModels = db.Turmas.Find(id);
            if (turmaModels == null)
            {
                return HttpNotFound();
            }
            return View(turmaModels);
        }

        // GET: Turma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turma/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTurma,DescricaoTurma,QtdDeAlunos,IsActive,Turno,IdCurso")] TurmaModels turmaModels)
        {
            if (ModelState.IsValid)
            {
                db.Turmas.Add(turmaModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(turmaModels);
        }

        // GET: Turma/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurmaModels turmaModels = db.Turmas.Find(id);
            if (turmaModels == null)
            {
                return HttpNotFound();
            }
            return View(turmaModels);
        }

        // POST: Turma/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTurma,DescricaoTurma,QtdDeAlunos,IsActive,Turno,IdCurso")] TurmaModels turmaModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(turmaModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(turmaModels);
        }

        // GET: Turma/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TurmaModels turmaModels = db.Turmas.Find(id);
            if (turmaModels == null)
            {
                return HttpNotFound();
            }
            return View(turmaModels);
        }

        // POST: Turma/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TurmaModels turmaModels = db.Turmas.Find(id);
            db.Turmas.Remove(turmaModels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
