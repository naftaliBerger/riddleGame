using System;

public class Wrench : Tool
{
    public Wrench(string name, double weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("A tool used to tighten or loosen bolts and nuts");
    }
    public override void Use()
    {
        Console.WriteLine("Used to tighten or loosen nuts and bolts");
    }

}