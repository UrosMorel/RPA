﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VajaMVC.Models;

namespace VajaMVC.Controllers
{
    public class StudentController : Controller
    {
            List<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve", Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill", Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                };
        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }
        public ActionResult Edit(int id)
        {
            var študent = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(študent);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                //posodobi podatke
                return RedirectToAction("Index");
            }
            return View(std);
        }
    }
}