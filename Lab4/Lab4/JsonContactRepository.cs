using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    internal class JsonContactRepository
    {
        private readonly string _filePath;

        public JsonContactRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(List<IContact> contacts)
        {
            var options = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
            var listToSerialize = new List<Contact>();
            foreach (var c in contacts)
            {
                listToSerialize.Add(new Contact(c.Name, c.Email, c.Id));
            }
            string json = System.Text.Json.JsonSerializer.Serialize(listToSerialize, options);
            System.IO.File.WriteAllText(_filePath, json);
        }

        public List<Contact> GetContacts()
        {
            if (!System.IO.File.Exists(_filePath))
                return new List<Contact>();

            string json = System.IO.File.ReadAllText(_filePath);
            return System.Text.Json.JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }
    }
}
