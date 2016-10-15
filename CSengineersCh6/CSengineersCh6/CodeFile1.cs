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
    //now is virtual
    virtual public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }

    //return the name of this type
    //now is virtual
    virtual public string TypeName()
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
    //overrides function in Engineer
    override public float CalculateCharge(float hours)
    {
        if (hours < 1.0F)
            hours = 1.0F; //minimum charge
        return (hours * billingRate);
    }

    //new function becuase it is different than the base version
    //overrides function in Engineer
    override public string TypeName()
    {
        return ("Civil Engineer");
    }
}

class ChemicalEngineer : Engineer
{
    public ChemicalEngineer(string name, float billingRate) :
        base(name, billingRate)
    { }

    //overrides mistakenly omitted
}

class Test
{
    public static void Main()
    {
        //create an array of Engineers
        Engineer[] earray = new Engineer[3];

        earray[0] = new Engineer("George", 15.50F);
        earray[1] = new CivilEngineer("Sir John", 40F);
        earray[2] = new ChemicalEngineer("Dr. Curie", 45.50F);

        Console.WriteLine("{0} charge = {1}",
            earray[0].TypeName(),
            earray[0].CalculateCharge(2F));
        Console.WriteLine("{0} charge = {1}",
            earray[1].TypeName(),
            earray[1].CalculateCharge(0.75F));
        Console.WriteLine("{0} charge = {1}",
            earray[2].TypeName(),
            earray[2].CalculateCharge(0.75F));

    }
}