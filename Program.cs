using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            // Planet Exercise
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> morePlanets = new List<string> () { "Uranus", "Neptune" };

            planetList.AddRange (morePlanets);
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            planetList.Add ("Pluto");

            List<string> rockyPlanets = planetList.GetRange (0, 4);

            planetList.Remove ("Pluto");

            foreach (string planet in planetList) {
                Console.WriteLine (planet);
            }

            foreach (string rocky in rockyPlanets) {
                Console.WriteLine (rocky);
            }

            // Random Number exercise
            Random random = new Random ();
            List<int> numbers = new List<int> {
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
                random.Next (6),
            };

            for (int i = 0; i < numbers.Count; i++) {
                if (numbers.Contains (i)) {
                    Console.WriteLine ($"The list contains {i}!");
                } else {
                    Console.WriteLine ($"The list does not contain {i}!");
                }
            }
        }
    }
}