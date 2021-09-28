using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Invite people to enter a set of data they want to get averaged
             * 
             * 
             * */
            Console.Write("Please Say How much Data you want to average? ");
            //sCount is a string to read the number of values into
            string sCount;
            string sData;
            int iData;
            sCount = Console.ReadLine();
            int count = Int16.Parse(sCount);
            //Loop asking the user for their numbers
            // i can be incremented in different ways
            // i = i + 1;   i++;   i += 1;
            float fMean = 0;
            for(int i=0; i < count; i++)//start value; end requirement; what to do after each loop
            {
                Console.Write("Next number: ");
                /*
                 * Will this confuse the user
                 * Should I make this more complex
                 * */
                sData = Console.ReadLine();
                iData = Int16.Parse(sData);
                fMean += iData;
            }
            fMean /= count;
            Console.WriteLine("The average is " + fMean);
            Console.ReadLine();
        }
    }
}
