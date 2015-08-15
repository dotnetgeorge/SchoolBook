using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using SchoolBook.Models;
using System.Threading.Tasks;

namespace SchoolBook.Controllers
{
    public class HomeController : Controller
    {
        SchoolBookDB db = new SchoolBookDB();

        public ActionResult Autocomplete(string term)
        {
            var schools = db.Schools
                            .Where(x => x.SchoolName.StartsWith(term))
                            .Take(10)
                            .Select(r => new {
                                label = r.SchoolName
                            });

            return Json(schools, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index(string searchTerm = null)
        {
            var schools = db.Schools
                            .Where(x => searchTerm == null || x.SchoolName.StartsWith(searchTerm))
                            .Take(10).ToList();

            if(Request.IsAjaxRequest())
            {
                return PartialView("_SearchSchoolsPartial", schools);
            }

            return View(schools);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("dotnetgeorge@gmail.com"));  // replace with valid value 
                message.From = new MailAddress(model.FromEmail.ToString());  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "user@outlook.com",  // replace with valid value
                        Password = "password"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }
    }
}