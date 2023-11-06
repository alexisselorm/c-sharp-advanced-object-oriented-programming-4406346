// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog {Name="Fido",Age=4,IsTrained=true};
Cat cat = new Cat {Name="MeowingTon", Age=7,IsDeclawed=false};
Console.WriteLine($"Dog: {dog.Name}");
Console.WriteLine($"Cat: {cat.Name}");
// TODO: Initializers can be used on anonymous types
var pet = new {Name="Pet"};
Console.WriteLine(pet.Name);

// TODO: Collections can also be initialized this way
int[] numbers = new int[]{1,2,3,4,5,6};
Console.WriteLine(numbers.Length);

// TODO: Initialize a collection with a set of objects
PetOwner owner = new PetOwner{
    Name="Alexis",
    Pets = new List<Pet>{
        new Dog{ Name="July",Age=5},
        new Cat{ Name="PussInBoots",Age=12}
    }
};
Console.WriteLine(owner.Name);
foreach(Pet pets in  owner.Pets){
Console.WriteLine(pets.Name);
}