using System;

class Engineer
{
    //constructor
    public Engineer(string name, float billingRate)
    {
        this.name = name;
        this.billingRate = billingRate;
    }

    //figure out the charge based on the engineer's rate
    public float Calculatecharge(float hours)
    {
        return (hours * billingRate);
    }

    //return the name of this type
    public string TypeName()
    {
        return ("Engineer");
    }

    private string name;
    protected float billingRate;
}

class Test
{
    public static void Main()
    {
        Engineer engineer = new Engineer("Hank", 21.20F);
        Console.WriteLine("Name is: {0}", engineer.TypeName());
    }
}