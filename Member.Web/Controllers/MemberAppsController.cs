using Member.Core;
using System;
using System.Net;
using System.Web.Mvc;
using Member.Infra;



namespace Member.Web.Controllers
{
    public class MemberAppsController : Controller
    {

        private MemberAppRepository db = new MemberAppRepository();


        // GET: MemberApps
        public ActionResult Index()
        {
            int a = 1;
            int b = 2;

            int n=1;
            string abc ='Alpit';
            string abc ='Alpit111';

            string la = 'lata';
            string la = 'lata111';
            string la = 'lata is mad';
            string la = 'lata is beautifull';
            return View(db.GetMembers());
        }


        // GET: MemberApps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MemberApp memberApp = db.FindById(Convert.ToInt32(id));

            if (memberApp == null)
            {
                return HttpNotFound();
            }
            return View(memberApp);
        }

        // GET: MemberApps/Create
        public ActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] MemberApp memberApp)
        {
            if (ModelState.IsValid)
            {

                db.Add(memberApp);

                return RedirectToAction("Index");
            }

            return View(memberApp);
        }

        // GET: MemberApps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            MemberApp memberApp = db.FindById(Convert.ToInt32(id));

            if (memberApp == null)
            {
                return HttpNotFound();
            }
            return View(memberApp);
        }

        // POST: MemberApps/Edit
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Phone,MaritalStatus,State,City")] MemberApp memberApp)
        {
            if (ModelState.IsValid)
            {
                 db.Edit(memberApp);

                return RedirectToAction("Index");
            }
            return View(memberApp);
        }

        // GET: MemberApps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
       

            MemberApp memberApp = db.FindById(Convert.ToInt32(id));

            if (memberApp == null)
            {
                return HttpNotFound();
            }
            return View(memberApp);
        }

        // POST: MemberApps/Delete

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Remove(id);

            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               
            }
            base.Dispose(disposing);
        }
    }
}
