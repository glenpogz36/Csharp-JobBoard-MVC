using System.Collections.Generic;
using System;

namespace JobBoard.Models
{
  public class Job
  {
    
    private string _position;
    private string _description;
    private string _salary;
    private string _contact;
  


    private static List<Job> _instances = new List<Job> {};

    public Job(string position, string description, string salary, string contact)
    {
      _position = position;
      _description = description;
      _salary = salary;
      _contact = contact;
     
    }

    public string GetPosition()
    {
      return _position;
    }

    public void SetPosition(string newPosition)
    {
      _position= newPosition;
    }

     public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

     public string GetSalary()
    {
      return _salary;
    }

    public void SetSalary(string newSalary)
    {
      _salary = newSalary;
    }

     public string GetContact()
    {
      return _contact;
    }

    public void SetContact(string newContact)
    {
      _contact = newContact;
    }


    public static List<Job> GetAll()
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
