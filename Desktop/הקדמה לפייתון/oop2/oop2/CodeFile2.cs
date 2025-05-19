using System;

public class ArmoredSoldier: Soldier
{
    public string unit = "Tank crew";
    public override void greet()
    {
        Console.WriteLine(_MA);
    }
}