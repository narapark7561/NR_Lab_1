using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_Lab_1
{
    class Relation
    {
        public string RelationshipType { get; set; }

        public void ShowRelationShip(Person person1, Person person2)
        {
            Console.WriteLine($"Relationship between {person1.firstName} and {person2.firstName} is: {RelationshipType}");
        }
    }
}
