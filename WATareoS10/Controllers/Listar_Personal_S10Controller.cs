using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WATareoS10.Models;

namespace WATareoS10.Controllers
{
    public class Listar_Personal_S10Controller : ApiController
    {
        private ModelS10 db = new ModelS10();

        // GET: api/Listar_Personal_S10
        public IQueryable<Listar_Personal_S10> GetListar_Personal_S10(string proyecto, string tareador, Guid planilla, bool activo)
        {
            return db.Listar_Personal_S10.Where(p => p.CodProyecto == proyecto && p.CodIdentificador == tareador && p.NroEsquemaPlanilla == planilla && p.Activo == activo);
        }

        // GET: api/Listar_Personal_S10/5
        [ResponseType(typeof(Listar_Personal_S10))]
        public IHttpActionResult GetListar_Personal_S10(string id)
        {
            Listar_Personal_S10 listar_Personal_S10 = db.Listar_Personal_S10.Find(id);
            if (listar_Personal_S10 == null)
            {
                return NotFound();
            }

            return Ok(listar_Personal_S10);
        }

        // PUT: api/Listar_Personal_S10/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutListar_Personal_S10(string id, Listar_Personal_S10 listar_Personal_S10)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != listar_Personal_S10.CodObrero)
            {
                return BadRequest();
            }

            db.Entry(listar_Personal_S10).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Listar_Personal_S10Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Listar_Personal_S10
        [ResponseType(typeof(Listar_Personal_S10))]
        public IHttpActionResult PostListar_Personal_S10(Listar_Personal_S10 listar_Personal_S10)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Listar_Personal_S10.Add(listar_Personal_S10);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Listar_Personal_S10Exists(listar_Personal_S10.CodObrero))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = listar_Personal_S10.CodObrero }, listar_Personal_S10);
        }

        // DELETE: api/Listar_Personal_S10/5
        [ResponseType(typeof(Listar_Personal_S10))]
        public IHttpActionResult DeleteListar_Personal_S10(string id)
        {
            Listar_Personal_S10 listar_Personal_S10 = db.Listar_Personal_S10.Find(id);
            if (listar_Personal_S10 == null)
            {
                return NotFound();
            }

            db.Listar_Personal_S10.Remove(listar_Personal_S10);
            db.SaveChanges();

            return Ok(listar_Personal_S10);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Listar_Personal_S10Exists(string id)
        {
            return db.Listar_Personal_S10.Count(e => e.CodObrero == id) > 0;
        }
    }
}