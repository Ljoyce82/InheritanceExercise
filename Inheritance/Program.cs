using System;
using System.Threading.Channels;

namespace Inheritance
{
    class Program
    { 
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common
         

        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class

        

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class

        
    
        static void Main(string[] args)
        {

        /*Create an object of your Bird class
         *  give values to your members using the object of your Bird class
         * 
         * Creatively display the class member values 
         */
        Bird myBird = new Bird();
        Reptile myReptile = new Reptile();

            Console.WriteLine("The " + myBird.Name + " " + myBird.Movement + "s " + myBird.Description + " Looking for " + myBird.Eats + " To eat and sees the " + myReptile.Name +" " + myReptile.Movement + " with it's " + myReptile.Description + " Looking for " + myReptile.Eats);
       
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */









        }
    }
}
