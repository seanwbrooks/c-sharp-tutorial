using System;
using System.Collections.Generic;

namespace csharptutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic input/output
            Console.Write("What is your name ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Data types
            bool canVote = true;
            char grade = 'A';

            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maxium value of 79,228,162,514,264,337,593,543,950,335
            // If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimal precision
            double maxDouble = double.MaxValue;

            Console.WriteLine("Max Int: " + maxInt);

            // Shorthand declaration
            var anotherName = "Tom";

            // Display variable data type
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());

            // A couple of Math functions
            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            // Casting
            double pi = 31.4;
            int intPi = (int)pi;

            // Random
            Random rand = new Random();
            Console.WriteLine("Random Number between 1 and 10 " + (rand.Next(1, 11)));

            // Relational Operators: >, <, >=, <=, ==, !=
            // Logical Operators: &&, ||, ^, !

            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age <= 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("You've graduated middle school. Congratulations!");
            }

            // Ternary operation
            bool canDrive = age >= 16 ? true : false;

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }

            // Looping
            // While
            int i = 0;

            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }
                if (i == 9)
                {
                    break;
                }
                if ((i % 2) > 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            // Do While
            string guess;
            Random randNum = new Random();
            int num = randNum.Next(1, 11);

            do
            {
                Console.WriteLine("Guess a number (between 1 and 10) ");
                guess = Console.ReadLine();

                int x = 0;
                Int32.TryParse(guess, out x);
                if (x < num)
                {
                    Console.WriteLine("\nToo Low");
                }
                if (x > num)
                {
                    Console.WriteLine("\nToo High");
                }

            } while (!guess.Equals(num.ToString()));

            // For
            for (int f = 0; f < 10; f++)
            {
                if (f % 2 > 0)
                {
                    Console.WriteLine(f);
                }
            }

            // ForEach
            string randStr = "Here is a random sentence.";

            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }

            // Given two strings, write a method to decide if one is a permutation of the other.
            string Sort(string s)
            {
                char[] sortedS = s.ToCharArray();
                Array.Sort(sortedS);
                return new String(sortedS);
            }

            bool isPermutation(string s, string t)
            {
                if (s.Length != t.Length)
                {
                    return false;
                }
                return Sort(s).Equals(Sort(t));
            }

            Console.WriteLine(isPermutation("sean", "nsea"));

            // URLify: Write a method to replace all spaces in a string with '%20'.
            string URLify(string s)
            {
                string[] strings = Arrayify(s);
                string convertedString = "";
                for (int y = 0; y < strings.Length; y++)
                {
                    if (String.IsNullOrWhiteSpace(strings[y]))
                    {
                        strings[y] = "%20";
                    }
                    convertedString += strings[y];
                }
                return convertedString;
            }

            string[] Arrayify(String S)
            {
                string[] strings = new string[S.Length];
                for (int z = 0; z < S.Length; z++)
                {
                    strings[z] = S[z].ToString();
                }
                return strings;
            }

            Console.WriteLine(URLify(" S E A   N   "));

            // Palindrome Permutation: Given a string, write a function to check if it is a
            // permutation of a palindrome.

            // This solves palindrome (not permutations of palindrome)
            string IsPalindrome(String s)
            {
                char[] reverseString = new char[s.Length];
                for (int a = 0; a < s.Length; a++)
                {
                    reverseString[a] = s[s.Length - (a + 1)];
                }
                return (new string(reverseString) == s).ToString()
                                                                 + " (permutations: '" + new string(reverseString) + "', '"
                                                                     + s + "', etc.)";
            }

            Console.WriteLine(IsPalindrome("Hello World"));
            Console.WriteLine(IsPalindrome("racecar"));

            // Another solution
            //String CanBePalindrome(String s) {

            //}

            // Back to C# Tutorial
            // String functions
            string sampString = "A bunch of random words.";
            Console.WriteLine("Index of bunch" + sampString.IndexOf("bunch"));
            Console.WriteLine("2nd Word " + sampString.Substring(2, 6));
            sampString = sampString.Replace("words.", "characters.    ");
            sampString = sampString.Trim();
            Console.WriteLine("After a word replace and trim " + sampString);

            string[] names = new string[3] { "Matt", "Angela", "Karen" };
            Console.WriteLine("Name List " + String.Join(", ", names));

            // Formats
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#} {3:0, 0}", 1.56, 15.567, .56, 1000);
            Console.WriteLine(fmtStr);

            // String Builders
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("This is the first sentence. ");
            sb.AppendFormat("My name is {0} and I live in {1}", "Sean", "Massachusetts");
            sb.Replace("a", "z");
            sb.Remove(5, 7);
            Console.WriteLine(sb);

            // Arrays
            int[] randArray = new int[5];
            int[] randArray2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Length" + randArray2.Length);
            Console.WriteLine("Item 0 " + randArray2[0]);

            for (int b = 0; b < randArray2.Length; b++)
            {
                Console.WriteLine("{0} : {1}", b, randArray2[b]);
            }

            foreach (int n in randArray2)
            {
                Console.WriteLine(n);
            }

            int[,] multArray = new int[5, 3];
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            foreach (int nu in multArray2)
            {
                Console.WriteLine(nu);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int u = 0; u < multArray2.GetLength(1); u++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, u, multArray2[x, u]);
                }
            }

            // Lists
            System.Collections.Generic.List<int> numList = new System.Collections.Generic.List<int>();
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

            int[] randInts = { 1, 2, 3, 4, 5 };
            numList.AddRange(randInts);

            System.Collections.Generic.List<int> numList2 = new System.Collections.Generic.List<int>(randArray);
            System.Collections.Generic.List<int> numList3 = new System.Collections.Generic.List<int>(new int[] { 1, 2, 3, 4 });

            numList.Insert(1, 10);
            numList.Remove(5);
            numList.RemoveAt(2);

            for (int g = 0; g < numList.Count; g++)
            {
                Console.WriteLine(numList[g]);
            }

            Console.WriteLine("4 is in index " + numList3.IndexOf(4));
            Console.WriteLine("5 is in List " + numList3.Contains(5));

            System.Collections.Generic.List<string> strList = new System.Collections.Generic.List<string>(new string[] { "Tom", "Rando" });

            strList.Sort();

            // Exception Handling
            try
            {
                Console.Write("Divide 10 by ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", input, (10 / input));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            // Objects/Classes
            Animal spot = new Animal(15, 10, "Spot", "Woof");
            Console.WriteLine("{0} says {1}", spot.name, spot.sound);
            Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());
            Console.WriteLine(spot.toString());
            Console.WriteLine(spot.getSum(1.2, 2.7));

            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrr"
            };

            Dog fred = new Dog
            {
                name = "Fred",
                height = 10,
                weight = 11,
                sound = "Eee",
                favFood = "clementines"
            };

            Console.WriteLine(fred.toString());

            // Build a function that takes a string and returns the first recurring char
            string reoccurringChar(string s)
            {
                char[] chars = s.ToCharArray();
                List<char> checkedChars = new List<char>();
                string recurringChar = null;

                for (int c = 0; c < chars.Length; c++)
                {
                    if(checkedChars.Contains(chars[c])) {
                        recurringChar = chars[c].ToString();
                        break;
                    } else {
                        checkedChars.Add(chars[c]);
                    }
                }
                return recurringChar;
            }

            Console.WriteLine(reoccurringChar("badcedc"));
        }
    }
}