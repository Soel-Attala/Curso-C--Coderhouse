using Lesson6_Inheritance;
using System;
class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("E169", 40325485, "Julian Garcia", "balcarce 526");

        Student student1 = new Student("Engenieer", 39239548, "Rodrigo Perez", "9 de julio 234");

        Person person1 = employee1;
        Person person2 = student1;

        person1.ShowData();
        person2.ShowData();
        employee1.ShowData();
        Person.EmergencyNumber();

        Console.WriteLine();

        // Student student2 = person1; we cant do this, because a student cant be a person1, because the son cant be equal to the father class
        // All person can be a student, but student cant be a person




    }
}

