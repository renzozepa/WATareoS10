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
    public class MARCACION_PERSONALController : ApiController
    {
        private ModelS10 db = new ModelS10();

        // GET: api/MARCACION_PERSONAL
        public IQueryable<MARCACION_PERSONAL> GetMARCACION_PERSONAL()
        {
            return db.MARCACION_PERSONAL;
        }

        // GET: api/MARCACION_PERSONAL/5
        [ResponseType(typeof(MARCACION_PERSONAL))]
        public IHttpActionResult GetMARCACION_PERSONAL(int id)
        {
            MARCACION_PERSONAL mARCACION_PERSONAL = db.MARCACION_PERSONAL.Find(id);
            if (mARCACION_PERSONAL == null)
            {
                return NotFound();
            }

            return Ok(mARCACION_PERSONAL);
        }

        // PUT: api/MARCACION_PERSONAL/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMARCACION_PERSONAL(int id, MARCACION_PERSONAL mARCACION_PERSONAL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mARCACION_PERSONAL.ID)
            {
                return BadRequest();
            }

            db.Entry(mARCACION_PERSONAL).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MARCACION_PERSONALExists(id))
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

        // POST: api/MARCACION_PERSONAL
        [ResponseType(typeof(MARCACION_PERSONAL))]
        public IHttpActionResult PostMARCACION_PERSONAL(MARCACION_PERSONAL mARCACION_PERSONAL)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MARCACION_PERSONAL.Add(mARCACION_PERSONAL);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = mARCACION_PERSONAL.ID }, mARCACION_PERSONAL);
        }

        // DELETE: api/MARCACION_PERSONAL/5
        [ResponseType(typeof(MARCACION_PERSONAL))]
        public IHttpActionResult DeleteMARCACION_PERSONAL(int id)
        {
            MARCACION_PERSONAL mARCACION_PERSONAL = db.MARCACION_PERSONAL.Find(id);
            if (mARCACION_PERSONAL == null)
            {
                return NotFound();
            }

            db.MARCACION_PERSONAL.Remove(mARCACION_PERSONAL);
            db.SaveChanges();

            return Ok(mARCACION_PERSONAL);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MARCACION_PERSONALExists(int id)
        {
            return db.MARCACION_PERSONAL.Count(e => e.ID == id) > 0;
        }
    }
}