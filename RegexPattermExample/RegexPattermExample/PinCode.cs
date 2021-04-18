using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPattermExample
{
    class PinCode
    {

        public static void Pincode()
        {
            string pincode = "^[0-9]{3}[]*[0-9]{3}$";
            string[] pinCodeArr = { "422010", "A42109", "40C820", "145225" };
            PinCode p = new PinCode();

            p.ValidPincode(pinCodeArr, pincode);
            Console.WriteLine();
            Console.Read();

        }

        public void ValidPincode(string[] arr, string pincode)
        {
            Console.WriteLine("Validation Indian PIN Code");
            Regex regex = new Regex(pincode);
            IterateLoop(arr, regex);
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
    