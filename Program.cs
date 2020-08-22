using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void numArray()
        {
            int[] Numbers = new int []
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            Console.WriteLine(String.Join(",", Numbers));
        }


        public static string[] nameArray()
        {
            string[] Names = new string []
            {
                "Tim",
                "Martin",
                "Nikki",
                "Sara"
            };
            
            // Console.WriteLine(String.Join(",", Names));
            return Names;
        }

        static void booleanArray()
        {
            bool[] Booleans = new bool []
            {
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false
            };
            Console.WriteLine(String.Join(",", Booleans));
        }


        public static List<string> flavors()
        {
            List<string> Flavors = new List<string>();
            Flavors.Add("Strawberry Cheesecake");
            Flavors.Add("Chocolate");
            Flavors.Add("Vanilla");
            Flavors.Add("Green Tea");
            Flavors.Add("Cookies n Cream");
            // Console.WriteLine(Flavors.Count);
            // Console.WriteLine(Flavors [2]);
            // Flavors.RemoveAt(2);
            // Console.WriteLine(Flavors.Count);
            return Flavors;
        }


        public static void userInfo(List<string> Flavors, string[] Names)
        {
            Dictionary<string,string> User = new Dictionary<string, string>();
            foreach (string name in Names )
            {
                User.Add(name, null);
            }
            Random rand = new Random();
            foreach (string name in Names)
            {
                int x = rand.Next(Flavors.Count-1);
                User[name] = Flavors[x];
            }
            foreach(var entry in User)
            {
                Console.WriteLine("{0}'s favorite flavor is {1},", entry.Key, entry.Value);
            };
        }

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // numArray();
            // nameArray();
            // booleanArray();
            userInfo(flavors(),nameArray());
        }

    }
}
