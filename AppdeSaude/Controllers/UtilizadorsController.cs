using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppdeSaude.Models;

namespace AppdeSaude.Controllers
{
    public class UtilizadorsController : Controller
    {
        private AppSaudeEntities2 db = new AppSaudeEntities2();

        // GET: Utilizadors
        public ActionResult Index()
        {
        
            var utilizador = db.utilizador.Include(u => u.localidade);
            return View(utilizador.ToList());
        }

        // GET: Utilizadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            utilizador utilizador = db.utilizador.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            return View(utilizador);
        }

        // GET: Utilizadors/Create
        public ActionResult Create()
        {            
            ViewBag.localidade_localidade_id = new SelectList(db.localidade, "localidade_id", "Cidade");
            return View();
        }

        // POST: Utilizadors/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nome,Contacto,Nrutente,Datadenascimento,Genero,Altura,Peso,Email,Password,CreatedAt,localidade_localidade_id")] utilizador utilizador)
        {

            string sql = "SELECT top 1 id FROM utilizador order by id desc";
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0JHBC91\\SQLEXPRESS;Initial Catalog=AppSaude;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            conn.Open();

            SqlCommand command = new SqlCommand(sql, conn);
            int lastid = (int)command.ExecuteScalar();
         
            if (ModelState.IsValid)
            {
                utilizador.id = lastid + 1;
                utilizador.CreatedAt = DateTime.Now;
                db.utilizador.Add(utilizador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.localidade_localidade_id = new SelectList(db.localidade, "localidade_id", "Cidade", utilizador.localidade_localidade_id);
            return View(utilizador);
        }

        // GET: Utilizadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            utilizador utilizador = db.utilizador.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            ViewBag.localidade_localidade_id = new SelectList(db.localidade, "localidade_id", "Cidade", utilizador.localidade_localidade_id);
            return View(utilizador);
        }

        // POST: Utilizadors/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nome,Contacto,Nrutente,Datadenascimento,Genero,Altura,Peso,Email,Password,CreatedAt,localidade_localidade_id")] utilizador utilizador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(utilizador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.localidade_localidade_id = new SelectList(db.localidade, "localidade_id", "Cidade", utilizador.localidade_localidade_id);
            return View(utilizador);
        }

        // GET: Utilizadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            utilizador utilizador = db.utilizador.Find(id);
            if (utilizador == null)
            {
                return HttpNotFound();
            }
            return View(utilizador);
        }

        // POST: Utilizadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            utilizador utilizador = db.utilizador.Find(id);
            db.utilizador.Remove(utilizador);
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
