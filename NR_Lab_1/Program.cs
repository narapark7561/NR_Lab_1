using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    CPRG 211 
    Lab: Creating Classes
    000694773 Nara Park
*/


namespace NR_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            
            person2.DisplayPersonInfo();

            
            Console.WriteLine(person3);

            
            person1.ChangeFavouriteColor();
            person1.DisplayPersonInfo();

            
            person4.GetAgeInTenYears();

            
            Relation sisterRelation = new Relation { RelationshipType = "Sisterhood" };
            sisterRelation.ShowRelationShip(person2, person4);

            Relation brotherRelation = new Relation { RelationshipType = "Brotherhood" };
            brotherRelation.ShowRelationShip(person1, person3);

            List<Person> people = new List<Person> { person1, person2, person3, person4 };

            double averageAge = people.Average(p => p.age);
            Console.WriteLine($"Average age is: {averageAge}");

            Person youngest = people.OrderBy(p => p.age).First();
            Person oldest = people.OrderByDescending(p => p.age).First();

            Console.WriteLine($"The youngest person is: {youngest.firstName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName}");

            Console.WriteLine(person3);

            Console.WriteLine(person4);

            Console.WriteLine(person3);

            Console.ReadLine();
        }
    }
}