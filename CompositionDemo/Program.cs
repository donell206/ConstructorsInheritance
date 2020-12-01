using CompositionDemo.Models;
using System;

namespace CompositionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Street = "Victor allard ";
            address.City= "Vorst";
            address.PostCode = "9000";
            address.Country = "Belgie";

            Student student = new Student();

            student.FirstName = "Toon";
            student.LastName = "ToonLM";
            student.School = "Intec";
            student.Address = address;




            Console.WriteLine($"First Name: {student.FirstName} Last Name :{student.LastName}");
            Console.WriteLine($"Address: {student.Address.Street}{address.City}");

        }
    }
}
