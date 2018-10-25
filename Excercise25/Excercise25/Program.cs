using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise25
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a sentence:  ");
            bool userAnswer = true;
            while (userAnswer)
            {
            string sentence = Console.ReadLine();       
            string[] words = sentence.Split(' ');
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }
             Console.Write("Would you like to continue (y/n)?:  ");
             string continueUser = Console.ReadLine();
             userAnswer = continueUser.Equals("y", StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine("Goodbye!!!");



      
        }
    }
}
