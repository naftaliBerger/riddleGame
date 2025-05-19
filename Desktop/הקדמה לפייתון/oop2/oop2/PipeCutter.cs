using System;

public class PipeCutter: Tool
{
    public PipeCutter(string name, double weight) : base(name, weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine("A tool used to make precise cuts in pipes, usually metal or plastic");
    }
    public override void Use()
    {
        Console.WriteLine("Used to cut metal or plastic pipes, especially in plumbing");
    }

}