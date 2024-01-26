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
    class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

      
        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking) //creates person objects and assigns attributes
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

       
        public void DisplayPersonInfo()      
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"{personId}: {fullName}'s favorite color is {favoriteColour}");
        }
        public void ChangeFavouriteColor() 
        {
            favoriteColour = "White";
        }
        public void GetAgeInTenYears() 
        {
            int agePlusTen = age + 10;
            Console.WriteLine($"{firstName} {lastName}'s age in 10 years is: {agePlusTen}");
        }
        public override string ToString() 
        {
            return ($"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavouriteColor: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}");
        }

    }




}
