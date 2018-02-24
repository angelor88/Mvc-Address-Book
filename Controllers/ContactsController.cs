using Microsoft.AspNetCore.Mvc;
using MvcAddressBook.Models;
using System.Collections.Generic;

namespace MvcAddressBook.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/contacts")]
    public ActionResult Index()
    {
      List<Contact> allContacts = Contact.GetAll();
      return View(allContacts);
    }
    [HttpGet("contacts/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/contacts")]
    public ActionResult Create()
    {

      string newName = (Request.Form["new-contact"]);
      string newPhone = (Request.Form["new-contact-phone"]);
      string newAddress = (Request.Form["new-contact-address"]);
      Contact newContact = new Contact (newName, newPhone, newAddress);
      newContact.Save();
      List<Contact> allContacts = Contact.GetAll();
      return View ("Index", allContacts);
    }
    [HttpPost("/contacts/delete")]
    public ActionResult DeleteAll()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
