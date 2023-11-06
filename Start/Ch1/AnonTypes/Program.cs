// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types
var myobj = new {
    Name="Alexis",
    Street = "123 Main Street",
    Address= new {
        Country="Ghana",
        Part="West Africa"
    }
};

// TODO: Anonymous types can be declared using "new" and { }, similar to JS



// Anonymous types are read-only and cannot be modified
// myobj.Name="Alex";
// myobj.Name = "Jane Doe"; # will cause an error

Console.WriteLine(myobj);
Console.WriteLine(myobj.Name);
Console.WriteLine(myobj.Address.Country);

// TODO: To change a value, use non-destructive mutation and "with" clause
var myobj2 = myobj with {Name="Fefe",Street="saa"};

Console.WriteLine(myobj2.Name);
myobj = myobj2;
Console.WriteLine(myobj);
Console.WriteLine(myobj.GetType().GetProperty("Job"));


// TODO: You can check to see if an anonymous object contains a property
