using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungUndMehrZuOOPzweiteHerausf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vererbung2\n");

            Employee mitarbeiter1 = new Employee("Redondo", "Andrés", 55555);
            mitarbeiter1.Work();
            mitarbeiter1.Pause();

            Boss chef = new Boss("Burns", "Montgomery", 999999, "Porsche");
            chef.Work();
            chef.Lead();
            chef.Pause();

            Trainee azubi = new Trainee("Müller", "Florenz", 11111, 4,5);
            azubi.Work();
            azubi.Learn();
            azubi.Pause();
            Console.WriteLine();

            Console.ReadKey();
            //Meine Lösung scheint  gut zu funktionieren!!
        }


        // Erstelle eine Hauptklasse mit der Methode Main, dann eine Mitarbeiterklasse Namens "Employee"
        // als Basisklasse (Superklasse) mit den Eigenschaften Name, 
        // Firstname, Salary und die Methoden Work() und Pause().
        // Erstelle eine erbende Klasse Boss mit der Eigenschaft CompanyCar und der Methode Lead().
        // Erstelle eine weitere erbende Klasse von Empployee - Trainee (Auszubildende) mit den Eigenschaften WorkingHours
        // und SchoolHours und eine Methode Learn();
        // Überschreibe die Methode Work() der Trainee-Klasse, so dass sie Folgendes anzeigen
        // die Arbeitszeit des Auszubildenden.

        // Vergiss nicht, die Konstruktoren zu erstellen.

        // Lege ein Objekt  jeder der drei Klassen (mit beliebigen Werten) an
        // und rufe die Methoden Lead() von Boss und Work() von Trainee auf.
        // Gib einfach den jeweiligen Text aus, was die jeweiligen Mitarbeiter tun.
    }
}
