using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOPzweiteHerausf
{
    class Trainee : Employee
    {
        
        // Erstelle eine weitere erbende Klasse von Empployee - Trainee (Auszubildende) mit den Eigenschaften WorkingHours
        // und SchoolHours und eine Methode Learn();
        // Überschreibe die Methode Work() der Trainee-Klasse, so dass sie Folgendes anzeigen
        // die Arbeitszeit des Auszubildenden.
        // Vergiss nicht, die Konstruktoren zu erstellen.
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }
        public Trainee()
        {

        }

        public Trainee (string name, string firstname, int salary, int workingHours)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
            this.WorkingHours = workingHours;
        }

        public void Learn()
        {
            Console.WriteLine($"\tThe {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)} " +
                $"{this.FirstName} {this.Name} is learning!");

            //AR testen unterschied??
            //beide zeigen "VererbungUndMehrZuOOPzweiteHerausf.Trainee"
            //Console.WriteLine(base.ToString());
            //Console.WriteLine(this.ToString());
        }

        public override void Work()           //virtual um es überschreiben zu dürfen
        {

            Console.WriteLine($"The {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)} " +
                $"{this.FirstName} {this.Name} works only for {this.WorkingHours} a day!" +
                $"\n\tHis Position is {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)}" +
                $"\n\tHis Salary is {this.Salary}"); 
        }
    }
}
