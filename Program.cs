using System;

namespace InterfaceExample
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Declare a method that classes must implement
        void Quit();
    }

    // Define a basic Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Properties for Employee (you can expand as needed)
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job. 😢");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee and set the properties
            Employee emp = new Employee()
            {
                FirstName = "John",
                LastName = "Rambo"
            };

            // Use polymorphism: create an object of type IQuittable
            IQuittable quitter = emp;

            // Call the Quit() method on the IQuittable interface
            quitter.Quit();

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
