using System;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using twinkeltje.Models;

namespace twinkeltje.Controllers
{
    public class ContactController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(ContactViewModel vm)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress("twinkeltjecontact@jensvde.be");//Email which you are getting 
                    //from contact us page 
                    msz.To.Add("twinkeltjecontact@jensvde.be");//Where mail will be sent 
                    msz.Subject = "Vraag van " + vm.Name;
                    msz.Body = "Naam: " + vm.Name + "\nReply naar " + vm.Email + "\n\nBericht:\n" + vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "send.one.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                        ("twinkeltjecontact@jensvde.be", "6ha9^DeKY8KuBq7J");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Bedankt voor uw bericht!";
                }
                catch(Exception ex )
                {
                    ModelState.Clear();
                    ViewBag.Message = $"Onze excuses, er is een fout opgetreden: {ex.Message}";
                }              
            }
          
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}