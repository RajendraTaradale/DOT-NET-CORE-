using System;
using System.Collections.Generic;
using System.Linq;

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
        }
    }
}
