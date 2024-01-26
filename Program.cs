using System;

// 1. 
public class Person
{
    public int PersonId;
    public string FirstName;
    public string LastName;
    public string FavoriteColour;
    public int Age;
    public bool IsWorking;

    public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
    {
        PersonId = personId;
        FirstName = firstName;
        LastName = lastName;
        FavoriteColour = favoriteColour;
        Age = age;
        IsWorking = isWorking;
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favorite color is {FavoriteColour}");
    }

    public void ChangeFavoriteColour()
    {
        FavoriteColour = "White";
    }

    public int GetAgeInTenYears()
    {
        return Age + 10;
    }

    public override string ToString()
    {
        return $"PersonId: {PersonId}\nFirstName: {FirstName}\nLastName: {LastName}\nFavoriteColour: {FavoriteColour}\nAge: {Age}\nIsWorking: {IsWorking}";
    }
}

//2. 
public class Relation
{
    public string RelationshipType;

    public Relation(string relationshipType)
    {
        RelationshipType = relationshipType;
    }

    public void ShowRelationShip(Person person1, Person person2)
    {
        Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationshipType}");
    }
}

// 3. a to g
public class MainClass
{
    public static void Main()   // a. Create four objects using the provided data
    {
        Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person gina = new Person(2, "Gina", "James", "Green", 18, false);
        Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        // b. Display Gina’s information
        gina.DisplayPersonInfo();  

        // c. Display Mike’s information
        Console.WriteLine(mike);   

        // d. Change Ian’s Favorite Colour and print his information
        ian.ChangeFavoriteColour(); 
        ian.DisplayPersonInfo();    

        // e. Display Mary’s age after ten years
        Console.WriteLine($"Mary Beals's Age in 10 years is: {mary.GetAgeInTenYears()}");

        // f. Creating Relation objects and display relationships
        Relation sisterhood = new Relation("Sisterhood");
        Relation brotherhood = new Relation("Brotherhood");
        sisterhood.ShowRelationShip(gina, mary);
        brotherhood.ShowRelationShip(ian, mike);

        // g. Add all Person objects to a list and use it to display required information
        Person[] people = {ian, gina, mike, mary};

        // Calculate and display the average age of each person.
        double totalAge = 0;
        foreach (var person in people)
        {
            totalAge += person.Age;
        }
        Console.WriteLine($"Average age is: {totalAge / people.Length}");

        // Determine the youngest and the oldest person. 
        Person youngest = gina;     // Gina is the youngest.
        Person oldest = mike;       // Mike is the oldest.
        Console.WriteLine($"The youngest person is: {youngest.FirstName}");
        Console.WriteLine($"The oldest person is: {oldest.FirstName}");

        // Output for Mary and Mike
        Console.WriteLine(mary);
        Console.WriteLine(mike);
    }
}

//End of the program. 