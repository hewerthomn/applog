using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLog.Models;
using AppLog.Models.Repository;
using AppLog.Models.Validators;

namespace AppLog.Controllers
{
    public class ProjectsController : Controller
    {
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            ProjectValidator.Create(ModelState, project);

            if (ModelState.IsValid)
            {
                try
                {
                    ProjectRepository.Create(project);

                    this.success("Project created!");

                    return RedirectToAction("Display", new { id = project.Id });
                }
                catch (Exception ex)
                {
                    this.exception("Ops... An error ocurred when try to create a project.", ex);
                }
            }

            return View(project);
        }
    }
}