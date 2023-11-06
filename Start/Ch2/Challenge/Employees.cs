// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {
    public Employee() {}

    private readonly int _id;
    // YOUR CODE GOES HERE
    public Employee(int Id, string fullName, string department){
        ID=Id;
        FullName=fullName;
        Department=department;
    }

    public required int ID{
        get;
        init;
    }
    public required string Department {get;set;}

    public string FullName {get;set;}

    public virtual void AdjustPay(decimal percentage){

    }



    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

// DEFINE OTHER CLASSES HERE
public class HourlyEmployee : Employee {
    
    public HourlyEmployee(){}
    public decimal PayRate {get;set;}
    public override void AdjustPay(decimal percentage)
    {
        PayRate += PayRate * percentage;
    }
}

public class SalariedEmployee : Employee {
    
    public SalariedEmployee(){}
    public decimal Salary {get;set;}

    public override void AdjustPay(decimal percentage)
    {
        Salary+= Salary * percentage;
    }
}
