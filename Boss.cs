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
            //den rest von Employee
            this.CompanyCar = "DefaultCar";
        }

        public Boss(string name, string firstname, int salary, string companyCar)
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"\tThe {this.ToString().Remove(0, "VererbungUndMehrZuOOPzweiteHerausf".ToString().Length + 1)} " +
                              $"{this.FirstName} {this.Name} is leading his {this.CompanyCar}!");
        }


    }
}
