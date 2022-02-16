using System;

namespace Chararrayfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "car", "bus", "apple", "plain" };
            char checking = 'a';
            foreach (string item in Chararrayfinder(arr, checking))
            {
                Console.WriteLine(item);
            }
        }
        static string[] Chararrayfinder(string[] arr, char b)
        {
            string[] finially = new string[0];

            foreach (string item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == b)
                    {

                        Array.Resize(ref finially, finially.Length + 1);


                        finially[finially.Length - 1] = item;
                        break;
                    }

                }
            }

            return finially;
        }



        
    }
}
