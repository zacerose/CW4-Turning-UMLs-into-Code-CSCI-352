using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4_Turning_UMLs_into_Code_Abstract_Pattern_CSCI352
{
    internal class Program
    {
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
        
        // Implement IPhoneFactory in different file?
        static void Main(string[] args)
        {
        }
    }
}
