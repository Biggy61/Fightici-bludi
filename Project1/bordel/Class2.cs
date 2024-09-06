/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class2
    {
        public static void Main()
        {
            textToArray();
        }
        public static void textToArray()
        {
            List<String> list = new List<String>();
            String userInput;

            do
            {
                userInput = Console.ReadLine();
                list.Add(userInput);

            } while (userInput.Equals(""));

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        public static void numbers()
        {
            string userInput = Console.ReadLine();
            int userInputInt = int.Parse(userInput);
            for (int i = 0; i < userInputInt; i++)
            {
                Console.WriteLine(i);
            }
        }


    }
}
*/