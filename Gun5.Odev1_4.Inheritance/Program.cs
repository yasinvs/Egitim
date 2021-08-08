using System;

namespace Gun5.Odev1_4.Inheritance
{
    class Program
    {
        // Kalıtım, Miras Alma
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer(){ FirstName = "Engin" },
                new Student(){ FirstName = "Demiroğ" },
                new Person(){ FirstName = "Salih" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
