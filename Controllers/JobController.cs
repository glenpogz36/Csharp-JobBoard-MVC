using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class JobController : Controller
    {

        //  [HttpGet("/contact")]
        // public ActionResult Index()
        // {
        //     List<Contact> allContacts= Contact.GetAll();
        //     return View(allContacts);
        // }

        // [HttpGet("/contact/new")]
        // public ActionResult JobForm()
        // {
        //     return View();
        // }
        // [HttpPost("/contact")]
        // public ActionResult CreateForm(string name, string email, string phoneNumber)
        // {
        //     Contact myContact = new Contact(name, email, phoneNumber);
        //     myContact.Save();
        //     return RedirectToAction("Index");
        // }

        [HttpGet("/jobs")]
        public ActionResult Index()
        {
            List<Job> allJobs = Job.GetAll();
            return View(allJobs);
        }


        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/jobs")]
        public ActionResult CreateForm(string position, string description, string salary, string contact)
        {
            Job myJob = new Job(position, description, salary, contact);
            myJob.Save();
            return RedirectToAction("Index");
        }
    }
}