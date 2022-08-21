using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19088265_HW04.Models;

namespace u19088265_HW04.Controllers
{
    public class StudentController : Controller
    {

        //List<Student> students = new List<Student>() { 
       //new Student(){ StudentId = 145, StudentName = "Jim", Age = 20},
        //new Student(){ StudentId = 178, StudentName = "Etios", Age = 24},
        


        // GET: Student
        public ActionResult List()
        {
            OurDatabase DB = new OurDatabase();
            List<Student> Students;
            if (TempData["Datastore"] == null)
            {

                //Get the list of Customers from the DB
                Students = DB.Students;
                //And Store it in TempData
                TempData["Datastore"] = Students;
            }
            else
            {
                //Get already stored data from TempData
                Students = (List<Student>)TempData["Datastore"];
                //Ask TempData to keep the data till the next request
                TempData.Keep();
            }

            return View(Students);
        }

        
        public ActionResult Index()
        {
            OurDatabase DB = new OurDatabase();
            List<Student> Students;
            Students = DB.Students;

            return View(Students);
        }

        
        public ActionResult Create()
        {
            //Ask TempData to keep the data until the next request. Otherwise, Tempdata will discard it.
            TempData.Keep();

            //Empty Customer Object
            Student model = new Student();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Student m)
        {
            //parameter m is filled from the view using ModelBinder
            List<Student> Students;

            if (ModelState.IsValid)
            {
                //Get the Customres collection from TempData
                Students = (List<Student>)TempData["Datastore"];

                //Add the model received from the View to the collection
                Students.Add(m);

                //Ask TempData to keep the data till the next request
                TempData.Keep();

                //Go to List Action Method
                return RedirectToAction("List");
            }
            //Error Condition. Ask TempData to keep the data till the next request
            TempData.Keep();
            //Back to Create. Rectify errors and re Post
            return View(m);
        }

        public ActionResult Edit(int Id)
        {
            //here, get the student from the database in the real application

            //getting a student from collection for demo purpose
            //var std = Students.Where(s => s.StudentId == Id).FirstOrDefault();
            List<Student> Students;
            Students = (List<Student>)TempData["Datastore"];
            Student model = Students.FirstOrDefault(x => x.StudentId == Id);
            TempData.Keep();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Student m)
        {
            //update student in DB using EntityFramework in real-life application

            //update list by removing old student and adding updated student for demo purpose
            //return RedirectToAction("Index");

            List<Student> Students;

            if (ModelState.IsValid)
            {
                // Get the list of Customers from the datastore
                Students = (List<Student>)TempData["Datastore"];
                //Get the model being edited from the customer collection
                Student model = Students.FirstOrDefault(x => x.StudentId == m.StudentId);

                //Update the model
                model.StudentId = m.StudentId;
                model.StudentName = m.StudentName;
                model.StudentSurname = m.StudentSurname;
                model.Age = m.Age;
                model.Grade = m.Grade;
                model.School = m.School;
                model.Group = m.Group;
                //Tempdata to keep the data till the next request
                TempData.Keep();

                return RedirectToAction("Index");
            }

            TempData.Keep();
            return View(m);
        }

        public ActionResult Details(int id)
        {
            List<Student> Students;
            //Get Customer Collection

            Students = (List<Student>)TempData["Datastore"];
            //Get the customer with the selected id from the customers collection

            Student model = Students.FirstOrDefault(x => x.StudentId == id);

            TempData.Keep();

            //Send it to the view
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            List<Student> Students;

            //Get Customer Collection
            Students = (List<Student>)TempData["Datastore"];
            //Get the customer with the selected id from the customers collection
            Student model = Students.FirstOrDefault(x => x.StudentId == id);

            TempData.Keep();

            //Send it to the view
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Student m)
        {
            List<Student> Students;
            if (ModelState.IsValid)
            {
                // Get the list of Customers from the datastore
                Students = (List<Student>)TempData["Datastore"];
                //Get the model being edited from the customer collection
                Student model = Students.FirstOrDefault(x => x.StudentId == m.StudentId);

                //Remove the customer from the collection
                Students.Remove(model);

                //Tempdata to keep the data till the next request
                TempData.Keep();

                return RedirectToAction("Index");
            }
            TempData.Keep();
            return View(m);
        }
    }

}
