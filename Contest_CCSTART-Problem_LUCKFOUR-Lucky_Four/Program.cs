using System;
using System.Text.RegularExpressions;

namespace Contest_CCSTART_Problem_LUCKFOUR_Lucky_Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int iNumbersToCome = 0, answer = 0;
            string[] sNumbers;

            iNumbersToCome = Convert.ToInt32(Console.ReadLine());
            sNumbers = new string[iNumbersToCome];

            for (int i = 0; i < iNumbersToCome; i++)
                sNumbers[i] = Console.ReadLine();

            for (int i = 0; i < iNumbersToCome; i++)
            {
                // Next 2 lines is the regex Version of counting "4"s
                //int iCount = Regex.Matches(iNumbers[i], "4").Count;
                //Console.WriteLine(iCount);

                // or these line without #using System.Text.RegularExpressions;
                answer = 0;
                foreach (var a in sNumbers[i])
                    if (a == '4')
                        answer++;
                Console.WriteLine(answer);
            }
        }
    }
}
