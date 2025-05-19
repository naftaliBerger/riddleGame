using System;
using System.Xml.Schema;

public class Drill : Tool
{
    public Drill(string name, double weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("A manual or electric device used to drill holes in various materials"); 
    }
    public override void Use()
    {
        Console.WriteLine("Used to make holes in wood, metal, plastic, or walls");
    }

}