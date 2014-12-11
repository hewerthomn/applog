using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLog.Helpers;

namespace AppLog.Models.Validators
{
    public class ProjectValidator
    {
        public static void Create(ModelStateDictionary ModelState, Project project)
        {
            if (String.IsNullOrEmpty(project.Name))
            {
                ModelState.AddModelError("Name", "The name is required");
            }

            if (!String.IsNullOrEmpty(project.URL) && !ValidatorHelper.IsUrlValid(project.URL))
            {
                ModelState.AddModelError("URL", "The URL is invalid");
            }
        }
    }
}