using System;

public abstract class Tool
{
    public string name;
    public double weight;

    public Tool(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }
    public abstract void Describe();


    public abstract void Use();
    
        
    


}



