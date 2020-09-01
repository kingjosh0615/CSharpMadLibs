using System;

namespace CSharpMadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       This program will allow you to make yor own zaaaaaannny mad libs!
       Author: Joshua
       */


            // Let the user know that the program is starting:
            Console.WriteLine("Alrighty, the mad lib is starting!");

            // Give the Mad Lib a title:
            string title = "Smitty's Zany Day";

            Console.WriteLine(title);


            // Define user input and variables:
            Console.WriteLine("The name of our main character is Smitty, now you have to fill in the details about his crazy day.");
            // Adjectives

            Console.WriteLine("Alright we need a first adjective.");
            string adjectiveOne = Console.ReadLine();
            Console.WriteLine("Now we need a second adjective.");
            string adjectiveTwo = Console.ReadLine();
            Console.WriteLine("Finally we need a third adjective.");
            string adjectiveThree = Console.ReadLine();

            // Verb
            Console.WriteLine("Now we need a verb!");
            string verbOne = Console.ReadLine();

            // Nouns
            Console.WriteLine("Time for the first noun.");
            string nounOne = Console.ReadLine();
            Console.WriteLine("And the second noun.");
            string nounTwo = Console.ReadLine();
            Console.WriteLine("Then the third noun.");
            string nounThree = Console.ReadLine();

            // Misc
            Console.WriteLine("Now time for some random items. We need...");
            Console.WriteLine("an animal");
            string animal = Console.ReadLine();
            Console.WriteLine("a food");
            string food = Console.ReadLine();
            Console.WriteLine("a fruit");
            string fruit = Console.ReadLine();
            Console.WriteLine("a superhero");
            string superhero = Console.ReadLine();
            Console.WriteLine("a country");
            string country = Console.ReadLine();
            Console.WriteLine("a liquid");
            string liquid = Console.ReadLine();
            Console.WriteLine("a year");
            string year = Console.ReadLine();
            Console.WriteLine("a name");
            string name = Console.ReadLine();
            Console.WriteLine("any living thing or inanimate object");
            string miscItem = Console.ReadLine();

            // The template for the story:
            string story = $"This morning Smitty woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, " +
                $"a bunch of {animal}s were protesting to keep {food} in stores. They began to {verbOne} to the rhythm of the {nounOne}, " +
                $"which made all the {fruit}s very {adjectiveThree}. Concerned, Smitty texted {superhero}, who flew Smitty to {country} and " +
                $"dropped Smitty in a puddle of frozen {liquid}. Smitty woke up in the year {year}, in a world where {nounTwo}s ruled the world. " +
                $"Smitty however wasn't concerned, because he brought his trusty {nounThree}. Smitty eventually settled down with a nice {nounTwo} " +
                $"named {name} and they adopted a bunch of {miscItem}s.";
            // Print the story:
            Console.WriteLine(story);
        }
    }
}
