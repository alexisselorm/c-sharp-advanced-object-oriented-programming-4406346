// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Instantiate some objects
Circle c = new Circle(10);
Rectangle r = new Rectangle(10,20);
Square s = new Square(10);

// TODO: Exercise the ToString() method
Console.WriteLine(c);
Console.WriteLine(r);
Console.WriteLine(s);
Console.WriteLine(s.GetArea());
Console.WriteLine(r.GetArea());
Console.WriteLine(c.GetArea());


// TODO: Use the "is" operator to test an object type


// TODO: Call the GetArea() function on each one


// TODO: Print the area of each shape


// TODO: All of the classes derive from Shape2D, so we can treat each one
// as an instance of the base class. 
