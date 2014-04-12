using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevPioneers.Models;

namespace DevPioneers.Controllers
{
    public class QuestionsController : Controller
    {
        //
        // GET: /Questions/

        public ActionResult Index()
        {
            //Read all questions
            DevPEntities dbContext = new DevPEntities();
            List<QUESTION> model = new List<QUESTION>();
            model = dbContext.QUESTIONS.ToList();
            return View(model);
        }

        //
        // GET: /Questions/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Questions/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Questions/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //Populate Question Object
                var question = new QUESTION();
                question.QuestionTitle = collection["QuestionTitle"].ToString();
                question.QuestionBody = collection["QuestionBody"].ToString();
                //Change to Current User's UserID
                question.AskedBy = 1;// Convert.ToInt32(collection.GetValue("AskedBy"));
                question.Attachment = null;
                question.Snapshot = null;

                //Insert into DB
                using (DevPEntities dbContext = new DevPEntities())
                {
                    dbContext.QUESTIONS.Add(question);
                    dbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        //
        // GET: /Questions/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Questions/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Questions/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Questions/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                QUESTION question = null;
                using (DevPEntities dbContext = new DevPEntities())
                {
                    question = dbContext.QUESTIONS.FirstOrDefault(p => p.Id == id);

                    dbContext.QUESTIONS.Remove(question);
                    dbContext.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
