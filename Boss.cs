using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOPzweiteHerausf
{
    class Boss : Employee
    {

        // Erstelle eine erbende Klasse Boss mit der Eigenschaft CompanyCar und der Methode Lead().
        public string CompanyCar { get; set; }

        public Boss()
        {
            //den rest von Employee GEHT DIREKT SO NICHT, siehe unten
            this.Name = "EmptyName";
            this.FirstName = "EmptyFirstName";
            this.Salary = 45000;
            //das ist nötig
            this.CompanyCar = "DefaultCar";
        }

        //"alte aufrufweise" mit alle parametern direkt
        //public Boss(string name, string firstname, int salary, string companyCar)
        public Boss(string name, string firstname, int salary, string companyCar) :base(name, firstname, salary)
                                                                                  // SO RUFEN WIR DIE Employee Konstruktor
                                                                                  // wir haben alle parameter, die von Employee werden genauso wie in base(bzw Employee) gesetzt
                                                                                  // und sind in CodeBlock nicht mehr erforderlich!
        {
            //this.Name = name;
            //this.FirstName = firstname;
            //this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"\tThe {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)} " +
                              $"{this.FirstName} {this.Name} is leading his {this.CompanyCar}!");
        }


    }
}
