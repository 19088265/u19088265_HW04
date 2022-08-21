using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19088265_HW04.Models;

namespace u19088265_HW04.Controllers
{
    public class ProgramController : Controller
    {
        // GET: Program
        public ActionResult Index()
        {
            List<Program> programs = new List<Program>();
            
            Program programList = new Program();
            programList.programID = 1;
            programList.programName = "Reading class";
            programList.programType = "Learning programme";
            programList.duration = "Weekly";
            programList.facilitator = "Mpho Maleho";
            programList.studentGroup = 2;
            programs.Add(programList);

            programList = new Program();
            programList.programID = 4;
            programList.programName = "Mathematics";
            programList.programType = "Learning programme";
            programList.duration = "Weekly";
            programList.facilitator = "Dineo Jones";
            programList.studentGroup = 3;
            programs.Add(programList);

            programList = new Program();
            programList.programID = 2;
            programList.programName = "Colouring";
            programList.programType = "Learning programme";
            programList.duration = "Daily";
            programList.facilitator = "Kabelo Phiri";
            programList.studentGroup = 1;
            programs.Add(programList);

            programList = new Program();
            programList.programID = 5;
            programList.programName = "Singing";
            programList.programType = "Fun activities";
            programList.duration = "Weekly";
            programList.facilitator = "Samukelo Phiri";
            programList.studentGroup = 1;
            programs.Add(programList);

            programList = new Program();
            programList.programID = 6;
            programList.programName = "Spelling Bee";
            programList.programType = "Learning programme";
            programList.duration = "Fortnightly";
            programList.facilitator = "Mpho Maleho";
            programList.studentGroup = 2;
            programs.Add(programList);

            programList = new Program();
            programList.programID = 7;
            programList.programName = "Career Expo";
            programList.programType = "Informacials session";
            programList.duration = "Monthly";
            programList.facilitator = "Jonathan Richards";
            programList.studentGroup = 3;
            programs.Add(programList);

            return View(programs);
        }

        // GET: Program/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Program/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Program/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Program/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Program/Edit/5
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

        // GET: Program/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Program/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
