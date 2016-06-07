using projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;



namespace projekt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("kontakt.air.wrobel@outlook.com"));  // replace with valid value 
                message.From = new MailAddress("kontakt.air.wrobel@outlook.com");  // replace with valid value
                message.Subject = "Wiadomość od użytkownika strony AirWrobel";
                message.Body = string.Format(body, model.Name, model.EmailAdress, model.Text);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "kontakt.air.wrobel@outlook.com",  // replace with valid value
                        Password = "ProjektZespolowy2016"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    //smtp.UseDefaultCredentials = false;
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

        [HttpPost]
        public ActionResult SearchFlyAction(string MyRadioButton)
        {
            return null;
        }

        public ActionResult Employed()
        {
            return View();
        }
    }
}
