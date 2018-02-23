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
      Contact newContact = new Contact (Request.Form["new-contact"]);
      newContact.save();
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
