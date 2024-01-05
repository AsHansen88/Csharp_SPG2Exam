
using System.Reflection;

class Program {

public static void Main(String[] args) {

// Opretter en instans af Person og kalder metoden
            Person person = new Person();
            person.Name = "John";
            person.SayHello();

            // Opretter en instans af Person2 og kalder metoden
            Person2 person2 = new Person2();
            person2.SayHello(); // Bemærk: 'name' er privat og kan ikke tilgås direkte

            // Opretter en instans af Person3 og sætter en alder
            Person3 person3 = new Person3();
            person3.Age = 30;
            Console.WriteLine("Age of person3 is " + person3.Age);

            // Opretter en instans af Person4 med konstruktøren
            Person4 person4 = new Person4("Jane");
            Console.WriteLine("Name of person4 is " + person4.Name);

            // Opretter en instans af Employee (som arver fra Person)
            Employee employee = new Employee();
            employee.Name = "Dave";
            employee.Id = 123;
            employee.SayHello();
            Console.WriteLine("Employee ID: " + employee.Id);

            // Dynamisk metode dispatch eksempel
            Person5 person5 = new Student(); // Polymorfi: refererer til en student som en Person5
            person5.SaySomething(); // Kalder den overskrevne metode i Student
        }
    }

    // ... (Indsæt de andre klassedefinitioner her) ...






