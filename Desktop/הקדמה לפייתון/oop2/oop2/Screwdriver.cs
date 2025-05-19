using System;

public class Screwdriver : Tool
{
    public Screwdriver(string name, double weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("A tool used to drive or remove screws");
    }
    public override void Use()
    {
        Console.WriteLine("Used to insert or remove screws"); 
    }

}