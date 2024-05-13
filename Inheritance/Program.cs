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
            var hawk = new Bird();
            hawk.Name = "Red Hawk";
            hawk.species = "Raptor";
            hawk.canFly = true;
            hawk.Habitat = "North America";
            hawk.hasfeathers = true;
            hawk.Eats = "Meat";
            hawk.canSwim = false;
            hawk.Movement = "Flying";



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var dragon = new Reptile();
            dragon.Name = "Bearded Dragon";
            dragon.Habitat = " Australia";
            dragon.Movement = "Ground";
            dragon.Eats = "Omnivorous";
            dragon.hasLegs = 4;
            dragon.hasTail = true;
            dragon.isVenomous = false;
            dragon.canClimb = true;

            Console.WriteLine($"The {dragon.Name} lives in {dragon.Habitat} running around on the {dragon.Movement} with its {dragon.hasLegs} legs and long tail {dragon.hasTail} which it can use it long tail as balance to climb trees {dragon.canClimb}. Looking for bugs and plants as it is {dragon.Eats} its is not venomous {dragon.isVenomous} ");
            Console.WriteLine();
            Console.WriteLine( $"The {hawk.Name} is a {hawk.species} that spends is time {hawk.Movement} {hawk.canFly} in {hawk.Habitat} they are covered in feathers {hawk.hasfeathers}. There diet is mostly {hawk.Eats}, they avoid water as they cant not swim {hawk.canSwim}");





        }
    }
}
