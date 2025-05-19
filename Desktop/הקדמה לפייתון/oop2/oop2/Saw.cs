using System;

public class Saw : Tool
{
    public Saw(string name, double weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("A tool with a serrated blade used for cutting wood, plastic, or meta");
    }
    public override void Use()
    {
        Console.WriteLine("Used to cut through wood, plastic, or metal");
    }

}