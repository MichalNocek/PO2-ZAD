using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{

    public interface IContact
    {
        string Name { get; set; }
        string Email { get; set; }
        double Id { get; set; }
    }


    internal class Contact : IContact
    {
       
        public string Name { get; set; }
        public string Email { get; set; }
        public double Id { get; set; }

   
        public Contact(string name, string email, double id)
        {
            Name = name;
            Email = email;
            Id = id;
        }
    }
}