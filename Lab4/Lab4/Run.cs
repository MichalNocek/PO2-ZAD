using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    internal class Run
    {
        public void Execute()
        {
            var contacts = new List<IContact>
            {
                new Contact("Jan Kowalski", "jan.kowalski@example.com", 1.0),
                new Contact("Anna Nowak", "anna.nowak@example.com", 2.0)
            };

            Console.WriteLine("=== Testowanie zapisu do pliku TXT (ContactRepository) ===");
            var txtRepo = new ContactRepository("contacts.txt");
            txtRepo.Save(contacts);
            var loadedTxt = txtRepo.GetContacts();
            foreach (var c in loadedTxt)
            {
                Console.WriteLine($"Imię: {c.Name}, Email: {c.Email}, ID: {c.Id}");
            }

            Console.WriteLine("\n=== Testowanie zapisu do formatu JSON (JsonContactRepository) ===");
            var jsonRepo = new JsonContactRepository("contacts.json");
            jsonRepo.Save(contacts);
            var loadedJson = jsonRepo.GetContacts();
            foreach (var c in loadedJson)
            {
                Console.WriteLine($"Imię: {c.Name}, Email: {c.Email}, ID: {c.Id}");
            }
        }
    }
}
