using System;

namespace GenericAnimalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create generic animal object
            Animal<string> myAnimal = new Animal<string>("Blue Penguin");

            // Add animal information
            string animalHabitat = "New Zealand";
            bool endangered = false;
            bool extinct = false;
            int averageLifespan = 6;

            // Print out animal information
            Console.WriteLine($"Animal name: {myAnimal.getAnimal()}");
            Console.WriteLine($"Habitat: {animalHabitat}");
            Console.WriteLine($"Endangered: {endangered}");
            Console.WriteLine($"Extinct: {extinct}");
            Console.WriteLine($"Average lifespan: {averageLifespan}");
        }
    }
    // Create generic class 
    public class Animal<T>
    {
        private T data;
        //Set animalName to data
        public Animal(T animalName)
        {
            data = animalName;
        }
        public T getAnimal()
        {
            return data;
        }
    }
}
