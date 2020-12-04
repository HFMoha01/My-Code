using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS_420_Project.Models;
using CIS_420_Project.Areas.Admin.ViewModels;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CIS_420_Project.Areas.Admin.Controllers
{
    public class Management : Controller
    {
        private ORI_WEB_NEWContext _db;
        private readonly ILogger<Management> _logger;

        public Management(ORI_WEB_NEWContext context, ILogger<Management> logger)
        {
            _logger = logger;
            _db = context;
        }

        [Area("Admin")]
        public IActionResult Main()
        {
            return View(VarSetup());
        }

        [Area("Admin")]
        public IActionResult CreateArticle()
        {
            return View("Main", VarSetup());
        }

        [Area("Admin")]
        [HttpPost]
        public IActionResult CreateUser([Bind("FirstName, LastName, EmailAddress, Organization, WebsiteUrl, PhoneNumber, UserTypeId, UserId")] Users tblUsers)
        {
            tblUsers.UserId = new Random().Next(1,9999999).ToString();
            if (!ModelState.IsValid) //Runs if invalid values are attempted ot be passed
            {
                ViewBag.ConfirmationNotice = "Error Adding User";
                return View("Main", VarSetup());
            }
            else //Runs if everything is correct
            {
                try
                {
                    tblUsers.UserTypeId = (from t in _db.UserType
                                           where t.UserTypeDesc == tblUsers.UserTypeId
                                           select t.UserTypeId).FirstOrDefault();
                    _db.Users.Add(tblUsers);
                    _db.SaveChanges();
                    ViewBag.ConfirmationNotice = "Successfully Added User";
                }
                catch(Exception e)
                {
                    _logger.LogError(e, "Error on the Admin Management Controller when adding new user to DB");
                    ViewBag.ConfirmationNotice = "Error Saving User to Database! Blame Hasan";
                }
            }
            return View("Main", VarSetup());
        }


        private ManagementViewModel VarSetup()
        {
            var viewModel = new ManagementViewModel()
            {
                userCollection = _db.Users.ToArray(),
                articleCollection = _db.Articles.ToArray(),
                userTypes = (from t in _db.UserType
                             select t.UserTypeDesc).ToArray()
            };
            return viewModel;
        }

    }
}
