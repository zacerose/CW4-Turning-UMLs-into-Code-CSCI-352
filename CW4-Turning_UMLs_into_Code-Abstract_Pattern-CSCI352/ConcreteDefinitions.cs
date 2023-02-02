// Name: Zachary Rose
// Date: 2/2/2023
// Class: CSCI352
// Contains all concrete classes based off of the interfaces in the namespace. Each manufacterer has an associated factory, and an IDumb and ISmart phone model.
using CW4_Turning_UMLs_into_Code_Abstract_Pattern_CSCI352;
using System;

// constructs the appropriate factory for the given manufacterer and prints out the associated phone models to console
class PhoneTypeChecker
{
    public IPhoneFactory factory;
    public Manufacturers manu;

    // parameterized constructor, gives the manufacterer
    // @Manufacterers m manufacterer to associate internal factory with
    public PhoneTypeChecker(Manufacturers m)
    {
        manu = m;
    }
    // constructs the appropriate factory for the given manufacterer and prints out the associated phone models to console
    public void CheckProducts()
    {
        switch (manu)
        {
            case Manufacturers.SAMSUNG:
                factory = new SamsungFactory();
                break;
            case Manufacturers.HTC:
                factory = new HTCFactory();
                break;
            case Manufacturers.NOKIA:
                factory = new NokiaFactory();
                break;
        }
        if (factory != null)
        {
            Console.WriteLine("Smart: " + factory.GetSmart().getName());
            Console.WriteLine("Dumb: " + factory.GetDumb().getName());
        }
    }
}
// Nokia smart phone
class Lumia : ISmart
{
    public string getName()
    {
        return "Lumia";
    }
}

// Samsung smart phone
class GalaxyS2 : ISmart
{
    public string getName()
    {
        return "GalaxyS2";
    }
}

// HTC smart phone
class Titan : ISmart
{
    public string getName()
    {
        return "Titan";
    }
}

// Nokia dumb phone
class Asha : IDumb
{
    public string getName()
    {
        return "Asha";
    }
}

// HTC dumb phone
class Genie : IDumb
{
    public string getName()
    {
        return "Genie";
    }
}

// Samsung dumb phone
class Primo : IDumb
{
    public string getName()
    {
        return "Primo";
    }
}

// Samsung phone factory, can return the related smart and dumb phone models
class SamsungFactory : IPhoneFactory
{
    public ISmart GetSmart()
    {
        return new GalaxyS2();
    }
    public IDumb GetDumb()
    {
        return new Primo();
    }
}

// HTC phone factory, can return the related smart and dumb phone models
class HTCFactory : IPhoneFactory
{
    public ISmart GetSmart()
    {
        return new Titan();
    }
    public IDumb GetDumb()
    {
        return new Genie();
    }
}

// Nokia phone factory, canr eturn the related smart and dumb phone models
class NokiaFactory : IPhoneFactory
{
    public ISmart GetSmart()
    {
        return new Lumia();
    }
    public IDumb GetDumb()
    {
        return new Asha();
    }
}