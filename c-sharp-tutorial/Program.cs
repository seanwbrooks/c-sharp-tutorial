using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharptutorial
{
    class Program
    {
        protected internal static void Main(string[] args)
        {
            //    // Basic input/output
            //    Console.Write("What is your name ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Hello " + name);

            //    // Shorthand declaration
            //    var anotherName = "Tom";

            //    // Display variable data type
            //    Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());

            //    // A couple of Math functions
            //    Console.WriteLine("5 + 3 = " + (5 + 3));
            //    Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            //    // Casting
            //    double pi = 31.4;
            //    int intPi = (int)pi;

            //    // Random
            //    Random rand = new Random();
            //    Console.WriteLine("Random Number between 1 and 10 " + (rand.Next(1, 11)));

            //    // Relational Operators: >, <, >=, <=, ==, !=
            //    // Logical Operators: &&, ||, ^, !

            //    int age = 17;
            //    if ((age >= 5) && (age <= 7))
            //    {
            //        Console.WriteLine("Go to elementary school");
            //    }
            //    else if ((age > 7) && (age <= 13))
            //    {
            //        Console.WriteLine("Go to middle school");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You've graduated middle school. Congratulations!");
            //    }

            //    // Ternary operation
            //    bool canDrive = age >= 16 ? true : false;

            //    switch (age)
            //    {
            //        case 0:
            //            Console.WriteLine("Infant");
            //            break;
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Toddler");
            //            break;
            //        default:
            //            Console.WriteLine("Child");
            //            break;
            //    }

            //    // Looping
            //    // While
            //    int i = 0;

            //    while (i < 10)
            //    {
            //        if (i == 7)
            //        {
            //            i++;
            //            continue;
            //        }
            //        if (i == 9)
            //        {
            //            break;
            //        }
            //        if ((i % 2) > 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        i++;
            //    }

            //    // Do While
            //    string guess;
            //    Random randNum = new Random();
            //    int num = randNum.Next(1, 11);

            //    do
            //    {
            //        Console.WriteLine("Guess a number (between 1 and 10) ");
            //        guess = Console.ReadLine();

            //        int x = 0;
            //        Int32.TryParse(guess, out x);
            //        if (x < num)
            //        {
            //            Console.WriteLine("\nToo Low");
            //        }
            //        if (x > num)
            //        {
            //            Console.WriteLine("\nToo High");
            //        }

            //    } while (!guess.Equals(num.ToString()));

            //    // For
            //    for (int f = 0; f < 10; f++)
            //    {
            //        if (f % 2 > 0)
            //        {
            //            Console.WriteLine(f);
            //        }
            //    }

            //    // ForEach
            //    string randStr = "Here is a random sentence.";

            //    foreach (char c in randStr)
            //    {
            //        Console.WriteLine(c);
            //    }

            //    // Given two strings, write a method to decide if one is a permutation of the other.
            //    string Sort(string s)
            //    {
            //        char[] sortedS = s.ToCharArray();
            //        Array.Sort(sortedS);
            //        return new String(sortedS);
            //    }

            //    bool isPermutation(string s, string t)
            //    {
            //        if (s.Length != t.Length)
            //        {
            //            return false;
            //        }
            //        return Sort(s).Equals(Sort(t));
            //    }

            //    Console.WriteLine(isPermutation("sean", "nsea"));

            //    // URLify: Write a method to replace all spaces in a string with '%20'.
            //    string URLify(string s)
            //    {
            //        string[] strings = Arrayify(s);
            //        string convertedString = "";
            //        for (int y = 0; y < strings.Length; y++)
            //        {
            //            if (String.IsNullOrWhiteSpace(strings[y]))
            //            {
            //                strings[y] = "%20";
            //            }
            //            convertedString += strings[y];
            //        }
            //        return convertedString;
            //    }

            //    string[] Arrayify(String S)
            //    {
            //        string[] strings = new string[S.Length];
            //        for (int z = 0; z < S.Length; z++)
            //        {
            //            strings[z] = S[z].ToString();
            //        }
            //        return strings;
            //    }

            //    Console.WriteLine(URLify(" S E A   N   "));

            //    // Palindrome Permutation: Given a string, write a function to check if it is a
            //    // permutation of a palindrome.

            //    // This solves palindrome (not permutations of palindrome)
            //    string IsPalindrome(String s)
            //    {
            //        char[] reverseString = new char[s.Length];
            //        for (int a = 0; a < s.Length; a++)
            //        {
            //            reverseString[a] = s[s.Length - (a + 1)];
            //        }
            //        return (new string(reverseString) == s).ToString()
            //                                                         + " (permutations: '" + new string(reverseString) + "', '"
            //                                                             + s + "', etc.)";
            //    }

            //    Console.WriteLine(IsPalindrome("Hello World"));
            //    Console.WriteLine(IsPalindrome("racecar"));

            //    // Another solution
            //    //String CanBePalindrome(String s) {

            //    //}

            //    // Back to C# Tutorial
            //    // String functions
            //    string sampString = "A bunch of random words.";
            //    Console.WriteLine("Index of bunch" + sampString.IndexOf("bunch"));
            //    Console.WriteLine("2nd Word " + sampString.Substring(2, 6));
            //    sampString = sampString.Replace("words.", "characters.    ");
            //    sampString = sampString.Trim();
            //    Console.WriteLine("After a word replace and trim " + sampString);

            //    string[] names = new string[3] { "Matt", "Angela", "Karen" };
            //    Console.WriteLine("Name List " + String.Join(", ", names));

            //    // Formats
            //    string fmtStr = String.Format("{0:c} {1:00.00} {2:#} {3:0, 0}", 1.56, 15.567, .56, 1000);
            //    Console.WriteLine(fmtStr);

            //    // String Builders
            //    StringBuilder sb = new StringBuilder();

            //    sb.Append("This is the first sentence. ");
            //    sb.AppendFormat("My name is {0} and I live in {1}", "Sean", "Massachusetts");
            //    sb.Replace("a", "z");
            //    sb.Remove(5, 7);
            //    Console.WriteLine(sb);

            //    // Arrays
            //    int[] randArray = new int[5];
            //    int[] randArray2 = { 1, 2, 3, 4, 5 };
            //    Console.WriteLine("Array Length" + randArray2.Length);
            //    Console.WriteLine("Item 0 " + randArray2[0]);

            //    for (int b = 0; b < randArray2.Length; b++)
            //    {
            //        Console.WriteLine("{0} : {1}", b, randArray2[b]);
            //    }

            //    foreach (int n in randArray2)
            //    {
            //        Console.WriteLine(n);
            //    }

            //    int[,] multArray = new int[5, 3];
            //    int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            //    foreach (int nu in multArray2)
            //    {
            //        Console.WriteLine(nu);
            //    }

            //    for (int x = 0; x < multArray2.GetLength(0); x++)
            //    {
            //        for (int u = 0; u < multArray2.GetLength(1); u++)
            //        {
            //            Console.WriteLine("{0} | {1} : {2}", x, u, multArray2[x, u]);
            //        }
            //    }

            //    // Lists
            //    List<int> numList = new List<int>();
            //    numList.Add(5);
            //    numList.Add(15);
            //    numList.Add(25);

            //    int[] randInts = { 1, 2, 3, 4, 5 };
            //    numList.AddRange(randInts);

            //    List<int> numList2 = new List<int>(randArray);
            //    List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            //    numList.Insert(1, 10);
            //    numList.Remove(5);
            //    numList.RemoveAt(2);

            //    for (int g = 0; g < numList.Count; g++)
            //    {
            //        Console.WriteLine(numList[g]);
            //    }

            //    Console.WriteLine("4 is in index " + numList3.IndexOf(4));
            //    Console.WriteLine("5 is in List " + numList3.Contains(5));

            //    List<string> strList = new List<string>(new string[] { "Tom", "Rando" });

            //    strList.Sort();

            //    // Exception Handling
            //    try
            //    {
            //        Console.Write("Divide 10 by ");
            //        int input = int.Parse(Console.ReadLine());
            //        Console.WriteLine("10 / {0} = {1}", input, (10 / input));
            //    }
            //    catch (DivideByZeroException ex)
            //    {
            //        Console.WriteLine("Can't divide by zero");
            //        Console.WriteLine(ex.GetType().Name);
            //        Console.WriteLine(ex.Message);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.GetType().Name);
            //        Console.WriteLine(ex.Message);
            //    }

            //    // Objects/Classes
            //    Animal spot = new Animal(15, 10, "Spot", "Woof");
            //    Console.WriteLine("{0} says {1}", spot.name, spot.sound);
            //    Console.WriteLine("Number of Animals " + Animal.getNumOfAnimals());
            //    Console.WriteLine(spot.toString());
            //    Console.WriteLine(spot.getSum(1.2, 2.7));

            //    Animal grover = new Animal
            //    {
            //        name = "Grover",
            //        height = 16,
            //        weight = 18,
            //        sound = "Grrr"
            //    };

            //    Dog fred = new Dog
            //    {
            //        name = "Fred",
            //        height = 10,
            //        weight = 11,
            //        sound = "Eee",
            //        favFood = "clementines"
            //    };

            //    Console.WriteLine(fred.toString());

            //    // Build a function that takes a string and returns the first recurring char
            //    string reoccurringChar(string s)
            //    {
            //        char[] chars = s.ToCharArray();
            //        List<char> checkedChars = new List<char>();
            //        string recurringChar = null;

            //        for (int c = 0; c < chars.Length; c++)
            //        {
            //            if(checkedChars.Contains(chars[c])) {
            //                recurringChar = chars[c].ToString();
            //                break;
            //            } else {
            //                checkedChars.Add(chars[c]);
            //            }
            //        }
            //        return recurringChar;
            //    }

            //    Console.WriteLine(reoccurringChar("badcedc"));

            //    // Back to polymorphisms: abstract, interface, and operator (See Shape.cs)
            //    Shape rect = new Rectangle(5, 5);
            //    Shape tri = new Triangle(5, 5);

            //    Console.WriteLine("Rect Area " + rect.area());
            //    Console.WriteLine("Tri Area " + tri.area());

            //    Rectangle combRect = new Rectangle(5, 5) + new Rectangle(2, 3);
            //    Console.WriteLine("combRect Area " + combRect.area());

            //    // Calling our KeyValue class
            //    KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            //    superman.key = "Superman";
            //    superman.value = "Clark Kent";

            //    KeyValue<string, int> samsungTV = new KeyValue<string, int>("", 0);
            //    samsungTV.key = "a 50 in Samsung TV";
            //    samsungTV.value = 12345;

            //    superman.showData();
            //    samsungTV.showData();

            //    // Enums
            //    Temperature micTemp = Temperature.Low;

            //    switch(micTemp) {
            //        case Temperature.Freeze:
            //            Console.WriteLine("Temp on Freezing");
            //            break;
            //        case Temperature.Low:
            //            Console.WriteLine("Temp on Low");
            //            break;
            //        case Temperature.Warm:
            //            Console.WriteLine("Temp on Warm");
            //            break;
            //        case Temperature.Boil:
            //            Console.WriteLine("Temp on Boil");
            //            break;
            //    }

            //    // Struct
            //    Customers Sean = new Customers();
            //    Sean.createCust("Sean", 34.5, 1);
            //    Sean.showCust();

            //    // Stream writers/readers
            //    string[] custs = new string[] { "Dakota", "Sean", "Karen" };
            //    string file = "test.txt";

            //    //using (StreamWriter writer = new StreamWriter(file))
            //    //{
            //    //    foreach (string cust in custs)
            //    //    {
            //    //        writer.WriteLine(cust);
            //    //    }
            //    //}

            //    string custName = "";
            //    using (StreamReader sr = new StreamReader("test.xlsx"))
            //    {
            //        while ((custName = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(custName);
            //        }
            //    }
            //}

            //// The following can be outside of the Program.cs file, but needs to be within
            //// the namespace csharptutorial
            //// Generics/Generic class
            //// We don't know the data type for Key and Value
            //class KeyValue<TKey, TValue>
            //{
            //    // Define getters and setters
            //    public TKey key { get; set; }
            //    public TValue value { get; set; }

            //    public KeyValue(TKey k, TValue v)
            //    {
            //        key = k;
            //        value = v;
            //    }

            //    public void showData()
            //    {
            //        Console.WriteLine("{0} is {1}", this.key, this.value);
            //    }
            //}

            // There are three types of edits that can be performed on strings: insert, remove, and replace.
            // Given two strings, write a function to check if they are one  edit away.
            bool oneEditAway(string str, string chk)
            {
                if (str.Length == chk.Length) {
                    return oneEditReplace(str, chk);
                } else if (str.Length + 1 == chk.Length) {
                    return oneInsertAway(str, chk);
                } else if (str.Length - 1 == chk.Length) {
                    return oneInsertAway(chk, str);
                }
                return false;
            }

            bool oneEditReplace(string str, string chk) {
                bool foundDifference = false;
                for (int i = 0; i < str.Length; i++) {
                    if (str[i] != chk[i]) {
                        if (foundDifference) {
                            return false;
                        }
                        foundDifference = true;
                    }
                }
                return true;
            }

            /* Check if you can insert a char into str to make chk */
            bool oneInsertAway(string str, string chk) {
                int index1 = 0;
                int index2 = 0;

                while (index2 < chk.Length && index1 < str.Length) {
                    if (str[index1] != chk[index2]) {
                        if (index1 != index2) {
                            return false;
                        }
                        index2++;
                    } else {
                        index1++;
                        index2++;
                    }
                }
                return true;
            }

            // Implement a method to perform basic string compression using the counts of repeated chars.
            string compressString(string str)
            {
                // initialize
                string compressed_str = "";
                int countConsecutive = 0;
                for (int y = 0; y < str.Length; y++)
                {
                    countConsecutive++;
                    if (y + 1 >= str.Length || str[y] != str[y + 1])
                    {
                        compressed_str += str[y].ToString() + countConsecutive.ToString();
                        countConsecutive = 0;
                    } 
                }
                return compressed_str.Length < str.Length ? compressed_str : str;
            }

            Console.WriteLine(compressString("aabccccaaa"));
        }
    }
}
