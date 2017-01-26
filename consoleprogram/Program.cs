using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace consoleprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer p = new SpeechSynthesizer();
            p.Speak("Hey Sanjay  Please look at the results ");
                        

            Gradeclass book = new Gradeclass();
            book.Addgrades(232);
            book.Addgrades(44.67f);
            book.Addgrades(100.3f);
            

            Gradestatistics stats = book.computestats();
            Console.WriteLine("the average grade is:"+ stats .averagesats);
            Console.WriteLine("The Highest grade is:" + stats.Higheststats);
            Console.WriteLine("The lowest grade is:" + stats.Loweststats);
            Console.Read();
        }
    }
}
