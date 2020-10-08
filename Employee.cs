using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOPzweiteHerausf
{
    class Employee
    {
        // Mitarbeiterklasse Namens "Employee"
        // als Basisklasse (Superklasse) mit den Eigenschaften Name, 
        // Firstname, Salary und die Methoden Work() und Pause().
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }



        //DefaultKonstruktor
        public Employee()
        {
            this.Name = "EmptyName";
            this.FirstName = "EmptyFirstName";
            this.Salary = 45000;
        }

        //Konstruktor
        public Employee(string name, string firstname, int salary)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
        }

        //public virtual void Work()           //virtual um es überschreiben zu dürfen (in Trainee mit override)
        public void Work()           //nicht virtual und in Trainee wird via new überschrieben!
        {
            //Name und Klassenname zeigen!
            Console.WriteLine($"{this.FirstName} {this.Name} is now working! " +
                $"\n\tHis Position is {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length+1)}" +
                $"\n\tHis Salary is {this.Salary}");
        }
        public void Pause()
        {

            Console.WriteLine("\tTaking a short Pause!\n");
        }
    }
}
