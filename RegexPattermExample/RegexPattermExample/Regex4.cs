using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattermExample
{
    class Regex4
    {
        public static void ArrayPattern()
        //Entery ponit
        {
            //string pincode = "^[0-9]{6}$"; //pattern using for alphabets
            string pincode = "^[0-9]{3}[ ]*[0-9]{3}$"; //pattern
            string[] pinCodeArr = { "422010", "482109", "145222", "145 222", "422 010" }; //Array

            Regex4 p = new Regex4(); // create object
            p.ValidPincode(pinCodeArr, pincode);
            Console.WriteLine();
            Console.Read();

        }
        public void ValidPincode(string[] arr, string pincode)
        {
            Console.WriteLine("Validation Indian PIN Code");
            Regex regex = new Regex(pincode);
            IterateLoop(arr, regex);  //calling method
        }
        public void IterateLoop(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool result = regex.IsMatch(arr[i]);
                if (result == true)
                {
                    Console.WriteLine(arr[i] + "---->" + "Valid");
                }
                else
                {
                    Console.WriteLine(arr[i] + "--->" + "Invalid");
                }
            }
        }
    }
}
   