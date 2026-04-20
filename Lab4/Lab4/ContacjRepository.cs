using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab4
{
    internal class ContactRepository
    {
        private readonly string _filePath;

        public ContactRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(List<IContact> contacts)
        {
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                foreach (var contact in contacts)
                {
                    writer.WriteLine($"{contact.Name},{contact.Email},{contact.Id}");
                }
            }
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();

            using (StreamReader reader = new StreamReader(_filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        Contact contact = new Contact(parts[0], parts[1], double.Parse(parts[2]));
                        contacts.Add(contact);
                    }
                }
            }
            return contacts;
        }
    }
}