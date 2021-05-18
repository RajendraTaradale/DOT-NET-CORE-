using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RT.Coding.Interviews
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region "Object Comparison"

            RTEmployee objRTEmployee = new RTEmployee();
            objRTEmployee.Id = 200;
            objRTEmployee.Name = "Rajendra";
            objRTEmployee.Address = "Pune";

            RTEmployee objRTRetiredEmployee = new RTEmployee();

            objRTRetiredEmployee.Id = 200;
            objRTRetiredEmployee.Name = "Rajendra";
            objRTRetiredEmployee.Address = "Pune";

            if (objRTEmployee.Equals(objRTRetiredEmployee))
            {
                if (Object.Equals(objRTEmployee, objRTRetiredEmployee))
                {
                    //  It Works 
                }
                //  It Works 
            }

            if (((object)objRTEmployee).Equals((object)objRTRetiredEmployee))
            {
                //  It Works 
            }

            RTEmployee objRTOldEmployee = new RTEmployee();

            objRTOldEmployee.Id = 200;
            objRTOldEmployee.Name = "Rajendra";
            objRTOldEmployee.Address = "Pune MH";

            if (objRTEmployee.Equals(objRTOldEmployee))
            {
                //  It Fails  
            }

            if (((object)objRTEmployee).Equals((object)objRTOldEmployee))
            {
                //  It Fails 
            }

            if (objRTEmployee.Name.GetHashCode() == objRTOldEmployee.Name.GetHashCode())
            {
                Console.WriteLine(objRTEmployee.Name.GetHashCode() + "---" + objRTOldEmployee.Name.GetHashCode());
                //  It Works  -1309867900----1309867900
            }

            #endregion

            #region "Dictionary"

            Dictionary<RTEmployee, string> complexColl = new Dictionary<RTEmployee, string>();

            complexColl.Add(objRTEmployee, "Pune");
            complexColl.Add(objRTOldEmployee, "Mumbai");


            // Get and display keys    
            Dictionary<RTEmployee, string>.KeyCollection keys = complexColl.Keys;
            foreach (RTEmployee key in keys)
            {
                Console.WriteLine("Key: {0}", key.Name);
            }

            // Get and display keys    
            Dictionary<RTEmployee, string>.ValueCollection values = complexColl.Values;
            foreach (string v in values)
            {
                Console.WriteLine("values : {0}", v);
            }

            var res = complexColl[new RTEmployee { Name = "Rajendra", Address = "Pune MH", Id = 200 }];


            #endregion

            #region "Combine two arrays without duplicate values in C#"

            int[] itemsOne = { 2, 3, 5, 3, 7, 5 };

            var resone = itemsOne.Distinct<int>();

            int[] itemsTwo = { 2, 3, 5, 3, 7, 5, 8, 9 };

            var allNums = itemsOne.Union(itemsTwo).ToArray();

            string[] animals = { "Joy", "Amol", "Joy", "Praveen", "Vinod", "Amol" };
            string[] birds = { "Hyderbad", "Kolkata", "Chennai", "Hyderbad", "Delhi" };

            var all = animals.Union(birds).ToArray();

            string wordOne = "Rajendra";
            string wordTwo = "Taradale";

            var uniqueword = wordOne.ToCharArray().Union(wordTwo.ToCharArray()).ToArray();

            #endregion

            #region "Thread Safe Concurrent Collection in C#"
            // .Net 4 Multiple threads can safely and efficiently add or remove items from these collections, without requiring additional synchronization in user code
            //ConcurrentStack<T>
            //ConcurrentQueue<T>
            //BlockingCollection<T>
            //ConcurrentBag<T>
            //ConcurrentDictionary<TKey, T>

            #endregion

            #region "String is a palindrome without in built functions"

            var isPal = CheckPalindromeString("madam");
            var isNotPal = CheckPalindromeString("madams");

            var name = "madam";

            bool result = Enumerable.Range(0, name.Length).All(i => name[i] == name[name.Length - 1 - i]);

            bool isPalindrome = name.SequenceEqual(name.Reverse());


            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);

            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{name} is Palindrome");
            }

            #endregion


            #region "Count the occurrence of each character in a string input"
            Countcharacter("Rajendra");
            #endregion

            #region "Remove duplicate characters from a string input"
            removeduplicate("Rajendra");
            #endregion

            #region "Find all possible substring of a given string input"
            findallsubstring("Rajendra");
            #endregion

            #region "Find the sum of digits of a positive integer"
            SumOfDigits(253);
            #endregion

            #region "Find second largest integer in an array using only one loop"
            int[] arr = new int[] { 102, 103, 104, 105, 106 };
            FindSecondLargeInArray(arr);
            #endregion
        }

        static void FindSecondLargeInArray(int[] arr)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max1)
                {
                    max2 = max1;
                    max1 = i;
                }
                else if (i >= max2 && i != max1)
                {
                    max2 = i;
                }
            }
            Console.WriteLine(max2);
        }

        static bool CheckPalindromeString(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            return flag;
        }

        static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
        static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }




    }
}
