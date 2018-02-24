using System.Collections.Generic;
using System;

namespace MvcAddressBook.Models
{
  public class Contact
  {
    private string _name;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name)
    {
      _name = name;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
