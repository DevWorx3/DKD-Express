using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using DKD_Express.Resources;
namespace DKD_Express.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(string email, string subject, string message, string name)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MailMessage mm = new MailMessage("DevWorx3@gmail.com", email);
                    mm.Subject = subject;
                    mm.Body = message;
                    mm.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("DevWorx3@gmail.com", "Lee@940724");
                    smtp.Send(mm);
                }

                return Json(new { message = labels.EmailSent, valid = true }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}