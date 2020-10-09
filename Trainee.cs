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

        //"alte aufrufweise" mit alle parametern direkt

        //public Trainee (string name, string firstname, int salary, int workingHours, int schoolHours)
        //{
        //    this.Name = name;
        //    this.FirstName = firstname;
        //    this.Salary = salary;
        //    this.WorkingHours = workingHours;
        //    this.SchoolHours = schoolHours;
        //}

        // SO RUFEN WIR DIE Employee Konstruktor
        // wir haben alle parameter, die von Employee werden genauso wie in base(bzw Employee) gesetzt
        // und sind in CodeBlock nicht mehr erforderlich!
        public Trainee(string name, string firstname, int salary, int workingHours, int schoolHours):base(name,firstname,salary)
        {

            //den rest von Employee GEHT DIREKT SO NICHT
            //this.Name = name;
            //this.FirstName = firstname;
            //this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
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

        //public override void Work()           //virtual in Employee um es überschreiben zu dürfen
            //oder hier  mit new  zum ausblenden bzw auch übberschreiben, theoretisch ist new nicht nötig, aber so ist es explizit und eindeutiger
        public new void Work()
        {

            Console.WriteLine($"The {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)} " +
                $"{this.FirstName} {this.Name} works only for {this.WorkingHours} hours a day!" +
                $"\n\tand learns only for {this.SchoolHours} hours a day!" +
                $"\n\tHis Position is {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)}" +
                $"\n\tHis Salary is {this.Salary}");

            Console.WriteLine("\nTEST BASE: We can call the 'original' Employee.Work() \nfrom the Trainee Method using base.work. it works!:");
                base.Work();

        }
    }
}
