// Name: Zachary Rose
// Date: 2/2/2023
// Class: CSCI352
// Simple console program based off of the abstract shape factory UML. Concrete class definitions are in ConcreteDefinitions.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4_Turning_UMLs_into_Code_Abstract_Pattern_CSCI352
{
    // all possible implemented manufacturer types, to be used in a concrete phone factory
    enum Manufacturers
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
    interface IDumb
    {
        string getName();
    }

    interface ISmart
    {
        string getName();
    }
    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }
    internal partial class Program
    {   
        // constructs every available factory and prints their products to console, with some extra labels and whitespace for readability
        static void Main(string[] args)
        {
            PhoneTypeChecker phone = new PhoneTypeChecker(Manufacturers.SAMSUNG);
            Console.WriteLine("Samsung: ");
            phone.CheckProducts();
            Console.WriteLine();

            phone = new PhoneTypeChecker(Manufacturers.HTC);
            Console.WriteLine("HTC: ");
            phone.CheckProducts();
            Console.WriteLine();

            phone = new PhoneTypeChecker(Manufacturers.NOKIA);
            Console.WriteLine("Nokia: ");
            phone.CheckProducts();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
