using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvitation
{
    class Program
    {
        static void Main(string[] args)
        {
            double validNames = 0, invalidNames = 0;//числата трябва да са double защото накрая се отпечатва резултат с десетична запетая
            bool IsInvalidName = false;
            while (true)
            {
                string name = Console.ReadLine();
                IsInvalidName = false;
                if (name == "Statistic") break;
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetter(name[i]) == false) //проверява дали настоящия символ е буква или не е
                    {
                        Console.WriteLine("Invalid name!");
                        invalidNames++;
                        IsInvalidName = true;
                        break;
                    }
                }
                // Изписване на имената коректно: първата буква е главна, останалите не
                if (IsInvalidName == false)
                {
                    name = name[0].ToString().ToUpper() + name.Substring(1).ToLower(); //прави първата буква главна а останалите малки
                    validNames++;
                    Console.WriteLine(name);
                    IsInvalidName = false;
                }
            }
            Console.WriteLine($"Valid names are {validNames / (validNames + invalidNames) * 100:F2}% from {validNames + invalidNames} names.");
            Console.WriteLine($"Invalid names are {invalidNames / (validNames + invalidNames) * 100:F2}% from {validNames + invalidNames} names.");
        }
    }
}
//using System;
 //using System.Collections.Generic;
 //using System.Linq;
 //using System.Text;
 //using System.Threading.Tasks;

//namespace PartyInvitation
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double validNames = 0, invalidNames = 0;//числата трябва да са double защото накрая се отпечатва резултат с десетична запетая
//            bool IsInvalidName = false;
//            while (true)
//            {
//                string name = Console.ReadLine();
//                IsInvalidName = false;
//                if (name == "Statistic") break;
//                for (int i = 0; i < name.Length; i++)
//                {
//                    if (char.IsLetter(name[i]) == false) //проверява дали настоящия символ е буква или не е
//                    {
//                        Console.WriteLine("Invalid name!");
//                        invalidNames++;
//                        IsInvalidName = true;
//                        break;
//                    }
//                }
//                // Изписване на имената коректно: първата буква е главна, останалите не
//                if (IsInvalidName == false)
//                {
//                    // name = name[0].ToString().ToUpper() + name.Substring(1).ToLower(); //прави първата буква главна а останалите малки
//                    char[] nameAsArray = name.ToCharArray();

//                    if (nameAsArray[0] >= 97 && nameAsArray[0] <= 122)
//                    {
//                        nameAsArray[0] = (char)(nameAsArray[0] - 32);
//                    }
//                    for (int i = 1; i < nameAsArray.Length; i++)
//                    {
//                        if (nameAsArray[i] >= 65 && nameAsArray[i] <= 90)
//                        {
//                            nameAsArray[i] = (char)(nameAsArray[i] + 32);
//                        }
//                    }
//                    name = string.Join("", nameAsArray);
//                    validNames++;
//                    Console.WriteLine(name);
//                    IsInvalidName = false;
//                }
//            }
//            Console.WriteLine($"Valid names are {validNames / (validNames + invalidNames) * 100:F2}% from {validNames + invalidNames} names.");
//            Console.WriteLine($"Invalid names are {invalidNames / (validNames + invalidNames) * 100:F2}% from {validNames + invalidNames} names.");
//        }
//    }
//}