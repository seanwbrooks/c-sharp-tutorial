using System;

namespace c_sharp_tutorial
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
            if((age >= 5) && (age <= 7)) {
                Console.WriteLine("Go to elementary school");
            } else if ((age > 7) && (age <= 13)) {
                Console.WriteLine("Go to middle school");
            } else {
                Console.WriteLine("You've graduated middle school. Congratulations!");
            }

            // Ternary operation
            bool canDrive = age >= 16 ? true : false;

            switch(age) {
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

            while(i < 10) {
                if(i == 7) {
                    i++;
                    continue;
                }
                if(i == 9) {
                    break;
                }
                if((i % 2) > 0) {
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
                if(x < num) {
                    Console.WriteLine("\nToo Low");
                }
                if(x > num) {
                    Console.WriteLine("\nToo High");
                }

            } while (!guess.Equals(num.ToString()));

            // For
            for (int f = 0; f < 10; f++) {
                if(f % 2 > 0) {
                    Console.WriteLine(f);
                }
            }

            // ForEach
            string randStr = "Here is a random sentence.";

            foreach(char c in randStr) {
                Console.WriteLine(c);
            }

            // Given two strings, write a method to decide if one is a permutation of the other.
            string Sort(string s) {
                char[] sortedS = s.ToCharArray();
                Array.Sort(sortedS);
                return new String(sortedS);
            }

            bool isPermutation(string s, string t) {
                if(s.Length != t.Length) {
                    return false;
                }
                return Sort(s).Equals(Sort(t));
            }

            Console.WriteLine(isPermutation("sean", "nsea"));

            // URLify: Write a method to replace all spaces in a string with '%20'.
            string URLify(string s) {
                string[] strings = Arrayify(s);
                string convertedString = "";
                for (int y = 0; y < strings.Length; y++) {
                    if (String.IsNullOrWhiteSpace(strings[y])) {
                        strings[y] = "%20";
                    }
                    convertedString += strings[y];
                }
                return convertedString;
            }

            string[] Arrayify(String S) {
                string[] strings = new string[S.Length];
                for (int z = 0; z < S.Length; z++) {
                    strings[z] = S[z].ToString();
                }
                return strings;
            }

            Console.WriteLine(URLify(" S E A   N   "));

            // Palindrome Permutation: Given a string, write a function to check if it is a
            // permutation of a palindrome.

            // This solves palindrome (not permutations of palindrome)
            string isPalindrome(String s) {
                char[] reverseString = new char[s.Length];
                for (int a = 0; a < s.Length; a++) {
                    reverseString[a] = s[s.Length - (a + 1)];
                }
                return (new string (reverseString) == s).ToString() 
                                                                 + " (permutations: '" + new string(reverseString) + "', '" 
                                                                     + s + "', etc.)";
            }

            Console.WriteLine(isPalindrome("Hello World"));
            Console.WriteLine(isPalindrome("racecar"));
        }
    }
}
