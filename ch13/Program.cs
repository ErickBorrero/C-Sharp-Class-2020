using System;
using System.Collections.Generic;
using System.Linq;

namespace ch13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***** Fun with LINQ to objects *****\n");
            QueryOverStrings();
            Console.ReadLine();

        }

        static void QueryOverStrings()
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2"};

            IEnumerable<string> subset = 
                from game in currentVideoGames
                where game.Contains(" ")
                orderby game
                select game;

                ReflectOverQueryResults(subset);

            foreach (string s in subset)
            {
                System.Console.WriteLine("Item: {0}", s);
            }
        }
    
        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            System.Console.WriteLine($"***** Info about your query using {queryType} *****");
            System.Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            System.Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }
    
        static void QueryOverInts()
        {
            int[] numbers = {10, 20, 30, 40 , 1, 2, 3, 8};

            var subset = from i in numbers where i < 10 select i;

            foreach (var i in subset)
            {
                System.Console.WriteLine("{0} < 10", i);
            }
        }

        static void ImmediateExecution()
        {
            int[] numbers = {10, 20, 30, 40 , 1, 2, 3, 8};

            int[] subsetArray = (from i in numvers where i < 10 select i).ToArray<int>();

            int[] subsetList = (from i in numbers where i < 10 select i).ToList<int>();
        }
    }
    
}
