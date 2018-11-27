using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phoneNumber;

    private static List<Contact> _contactInstances = new List<Contact> {};

    public Contact(string name, string email, string phoneNumber)
    {
        _name = name;
        _email = email;
        _phoneNumber = phoneNumber;
    }
    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name= newName;
    }

     public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }

     public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    
     public static List<Contact> GetAll()
    {
      return _contactInstances;
    }
    public void Save()
    {
      _contactInstances.Add(this);
    }
    

    public static void ClearAll()
    {
      _contactInstances.Clear();
    }


    }
}