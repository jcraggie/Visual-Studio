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
    public float CalculateCharge(float hours)
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

class CivilEngineer : Engineer
{
    public CivilEngineer(string name, float billingRate) :
        base(name, billingRate)
    { }

    //new function because it is different than the base version
    public new float CalculateCharge(float hours)
    {
        if (hours < 1.0F)
            hours = 1.0F; //minimum charge
        return (hours * billingRate);
    }

    //new function becuase it is different than the base version
    public new string TypeName()
    {
        return ("Civil Engineer");
    }
}

class Test
{
    public static void Main()
    {
        Engineer e = new Engineer("George", 15.50F);
        CivilEngineer c = new CivilEngineer("Sir John", 40F);

        Console.WriteLine("{0} charge = {1}",
            e.TypeName(),
            e.CalculateCharge(2F));
        Console.WriteLine("{0} charge = {1}",
            c.TypeName(),
            c.CalculateCharge(0.75F));

    }
}