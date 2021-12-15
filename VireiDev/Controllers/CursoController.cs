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
    public class CursoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Curso
        public ActionResult Index()
        {
            return View(db.Cursos.ToList());
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoModels cursoModels = db.Cursos.Find(id);
            if (cursoModels == null)
            {
                return HttpNotFound();
            }
            return View(cursoModels);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCurso,DescricaoCurso,NomeCurso")] CursoModels cursoModels)
        {
            if (ModelState.IsValid)
            {
                db.Cursos.Add(cursoModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cursoModels);
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoModels cursoModels = db.Cursos.Find(id);
            if (cursoModels == null)
            {
                return HttpNotFound();
            }
            return View(cursoModels);
        }

        // POST: Curso/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCurso,DescricaoCurso")] CursoModels cursoModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cursoModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cursoModels);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoModels cursoModels = db.Cursos.Find(id);
            if (cursoModels == null)
            {
                return HttpNotFound();
            }
            return View(cursoModels);
        }

        // POST: Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CursoModels cursoModels = db.Cursos.Find(id);
            db.Cursos.Remove(cursoModels);
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
