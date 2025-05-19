using System;

public class Hammer : Tool
{
    public Hammer(string name, double weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("A tool used for driving nails or breaking things apart"); 
    }

    public override void Use()
    {
        Console.WriteLine("Used to drive nails into surfaces, break objects, or dismantle parts"); 
    }
}