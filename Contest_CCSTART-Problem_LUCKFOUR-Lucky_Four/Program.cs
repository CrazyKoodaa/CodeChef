using System;
using System.Text.RegularExpressions;

namespace Contest_CCSTART_Problem_LUCKFOUR_Lucky_Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             * int iNumbersToCome;
            iNumbersToCome = Convert.ToInt32(Console.ReadLine());

            
            
            string[] iNumbers = new string [iNumbersToCome];

            for (int i = 0; i < iNumbersToCome; i++)
            {
                iNumbers[i] =Console.ReadLine();
            }

            for (int i = 0; i < iNumbersToCome; i++)
            {
                int iCount = Regex.Matches(iNumbers[i], "4").Count;
                Console.WriteLine(iCount);
            }
            
            /*

	                int T = int.Parse(Console.ReadLine());
		            for (int i = 0; i < T; i++)
		            {
		                string input = Console.ReadLine();
		                int answer = 0;
		                foreach(var a in input){
		                    if(a == '4'){
		                        answer++;
		                    }
		                }
		                Console.WriteLine(answer);
		            }
            
            */

        }
    }
}
